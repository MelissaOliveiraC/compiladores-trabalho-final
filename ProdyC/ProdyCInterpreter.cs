using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
//using Grammar;

// executa código-fonte .ProdyC

namespace Interpreter.ProdyC
{
    public class Simbolo
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public object Value { get; set; }

        public Simbolo(string type, string id, object value = null)
        {
            Type = type;
            Id = id;
            Value = value;
        }
    }
    public class ProdyCInterpreter : ProdyCBaseVisitor<object?>
    {
        private Dictionary<string, IParseTree> _functions;

        public ProdyCInterpreter(Dictionary<string, IParseTree> functions)
        {
            this._functions = functions;
        }

        public Dictionary<string, object?> Variables {get; protected set;} = new Dictionary<string, object?>();

        #region I/O declaration

        public override object? VisitInputRead([NotNull] ProdyCParser.InputReadContext context)
        {
            var input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
            {
                string varName = context.VAR().GetText();
                string varType = context.tipo().GetText();
                if (varType == "int" || varType == "double" || varType == "float")
                {
                    if (!double.TryParse(input, out double doubleValue))
                    {
                        Console.WriteLine("Variável " +'"'+ varName +'"' + " apenas aceita inputs do tipo " + '"'+varType+'"');
                        return null;
                    }
                }
                else
                {
                    Variables[varName] = new Simbolo(context.tipo().GetText(), varName, input);
                }
                if (varType == "string"){
                    if(double.TryParse(input, out double doubleValue)){
                        Console.WriteLine("Variável " +'"'+ varName +'"' + " apenas aceita inputs do tipo " + '"'+varType+'"');
                        return null;
                    }
                }else
                {
                    Variables[varName] = new Simbolo(context.tipo().GetText(), varName, input);
                }
                
            }

            return null;
        }
        public override object? VisitOutputWriteVar([NotNull] ProdyCParser.OutputWriteVarContext context)
        {
            var varName = context.VAR().GetText();
            if (Variables.ContainsKey(varName))
                Console.WriteLine(Variables[varName]);
            else
                Console.WriteLine("Variável "+'"'+ varName +'"'+ " não foi declarada");
            return null;
        }

        public override object? VisitOutputWriteStr([NotNull] ProdyCParser.OutputWriteStrContext context)
        {
            var varName = context.STR().GetText();
            Console.WriteLine(varName.Replace("\"", ""));
            return null;
        }

        public override object? VisitOutputWriteExpr([NotNull] ProdyCParser.OutputWriteExprContext context)
        {
            object? v = Visit(context.expr());
            if (v != null)
                Console.WriteLine(v);
            return null;
        }
        #endregion

        #region Variable and Expression Statements
        protected (Double, Double) GetDoubles(IParseTree tree1, IParseTree tree2)
        {
            var t1 = Visit(tree1);
            var t2 = Visit(tree2);
            Double.TryParse(t1?.ToString(), out var d1);
            Double.TryParse(t2?.ToString(), out var d2);
            return (d1, d2);
        }

        public override object? VisitAtribVar([NotNull] ProdyCParser.AtribVarContext context)
        {
            var varName = context.VAR().GetText();
            object? v = Visit(context.expr());
            Variables[varName] = v;
            return null;
        }

        public override object VisitExprPlus([NotNull] ProdyCParser.ExprPlusContext context)
        {
            var d = GetDoubles(context.term(), context.expr());
            return d.Item1 + d.Item2;
        }

        public override object VisitExprMinus([NotNull] ProdyCParser.ExprMinusContext context)
        {
            var d = GetDoubles(context.term(), context.expr());
            return d.Item1 - d.Item2;
        }

        public override object? VisitExprTerm([NotNull] ProdyCParser.ExprTermContext context)
        {
            return Visit(context.term());
        }

        public override object? VisitTermMult([NotNull] ProdyCParser.TermMultContext context)
        {
            var d = GetDoubles(context.factor(), context.term());
            return d.Item1 * d.Item2;
        }

        public override object? VisitTermDiv([NotNull] ProdyCParser.TermDivContext context)
        {
            var d = GetDoubles(context.factor(), context.term());
            return d.Item1 / d.Item2;
        }

        public override object? VisitTermFactor([NotNull] ProdyCParser.TermFactorContext context)
        {
            return Visit(context.factor());
        }

        public override object? VisitFactorVar([NotNull] ProdyCParser.FactorVarContext context)
        {
            var varName = context.VAR().GetText();
            if (Variables.ContainsKey(varName))
                return Variables[varName];

            Console.WriteLine("Variável "+'"'+ varName +'"'+ " não foi declarada");
            return null;
        }

        public override object? VisitFactorNum([NotNull] ProdyCParser.FactorNumContext context)
        {
            var txtNum = context.NUM().GetText();
            return Double.Parse(txtNum);
        }

        public override object? VisitFactorExpr([NotNull] ProdyCParser.FactorExprContext context)
        {
            return Visit(context.expr());
        }
        #endregion

        #region Control Statements
        public override object? VisitIfstIf([NotNull] ProdyCParser.IfstIfContext context)
        {
            var cond = Visit(context.cond());
            if (cond != null && (bool)cond)
                Visit(context.block());
            return null;
        }

        public override object? VisitIfstIfElse([NotNull] ProdyCParser.IfstIfElseContext context)
        {
            var cond = Visit(context.cond());
            if (cond != null && (bool)cond)
                Visit(context.b1);
            else
                Visit(context.b2);
            return null;
        }
        public override object? VisitWhilestWhile([NotNull] ProdyCParser.WhilestWhileContext context)
        {
            var cond = Visit(context.cond());
            while (cond != null && (bool)cond)
            {
                Visit(context.block());
                cond = Visit(context.cond());
            }
            return null;
        }
        public override object? VisitWhilestDoWhile([NotNull] ProdyCParser.WhilestDoWhileContext context)
        {
            var cond = Visit(context.cond());
            do
            {
                Visit(context.block());
                cond = Visit(context.cond());
            } while (cond != null && (bool)cond);
            return null;
        }
        public override object? VisitForstFor([NotNull] ProdyCParser.ForstForContext context)
        {
            foreach (var atrib in context.atrib())
            {
                Visit(atrib);
            }

            var cond = Visit(context.cond());
            
            while (cond != null && (bool)cond)
            {
                Visit(context.block());
                Visit(context.atrib(1));
                cond = Visit(context.cond());
            }
            return null;
        }   
        public override object? VisitCondExpr([NotNull] ProdyCParser.CondExprContext context)
        {
            object? v = Visit(context.expr()); 
            return v != null && (Double)v != 0;
        }

        public override object? VisitCondRelop([NotNull] ProdyCParser.CondRelopContext context)
        {
            var d = GetDoubles(context.e1, context.e2);
            switch (context.RELOP.Type)
            {
                case ProdyCLexer.EQ:
                    return d.Item1 == d.Item2;
                case ProdyCLexer.NE:
                    return d.Item1 != d.Item2;
                case ProdyCLexer.LT:
                    return d.Item1 < d.Item2;
                case ProdyCLexer.LE:
                    return d.Item1 <= d.Item2;
                case ProdyCLexer.GT:
                    return d.Item1 > d.Item2;
                case ProdyCLexer.GE:
                    return d.Item1 >= d.Item2;
            }
            return null;
        }

        public override object? VisitCondAnd([NotNull] ProdyCParser.CondAndContext context)
        {
            object? v1 = Visit(context.c1);
            object? v2 = Visit(context.c2);
            return v1 != null && v2 != null && (bool)v1 && (bool)v2;
        }

        public override object? VisitCondOr([NotNull] ProdyCParser.CondOrContext context)
        {
            object? v1 = Visit(context.c1);
            object? v2 = Visit(context.c2);
            return v1 != null && (bool)v1 || v2 != null && (bool)v2;
        }

        public override object? VisitCondNot([NotNull] ProdyCParser.CondNotContext context)
        {
            object? v = Visit(context.cond());
            return v != null && !(bool)v;
        }
        #endregion

        #region Functions

       public override object? VisitFuncInvocLine([NotNull] ProdyCParser.FuncInvocLineContext context)
        {
            //Console.WriteLine("VisitFuncInvocLine");
            var funcName = context.VAR().GetText();
            var function = _functions[funcName];

            if (function != null)
            {
                return Visit(function);
            }

            return null;
        }

        #endregion

    }
}