using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
//using Grammar;

namespace Interpreter.Lang
{
    public class SemanticProdyCListener : ProdyCBaseListener
    {
        public Dictionary<string, IParseTree> Functions { get; protected set; } = new Dictionary<string, IParseTree>();
        public HashSet<string> Variables { get; private set; } = new HashSet<string>();
        public Boolean HasErrors { get; private set; } = false;
        public List<string> ErrorMessages { get; private set; } = new List<string>();
        public override void ExitInputRead([NotNull] ProdyCParser.InputReadContext context)
        {
            var varName = context.VAR().GetText();
            Variables.Add(varName);
        }

        public override void ExitAtribVar([NotNull] ProdyCParser.AtribVarContext context)
        {
            var varName = context.VAR().GetText();
            Variables.Add(varName);
        }

        public override void ExitOutputWriteVar([NotNull] ProdyCParser.OutputWriteVarContext context)
        {
            var varName = context.VAR().GetText();
            if (!Variables.Contains(varName))
            {
                HasErrors = true;
                ErrorMessages.Add("Variável não declarada " + varName);
            }
        }

        public override void ExitFunction([NotNull] ProdyCParser.FunctionContext context)
        {
            var fnName = context.VAR().GetText();
            
            if (Functions.ContainsKey(fnName))
            {
                HasErrors = true;
                ErrorMessages.Add("Função " + fnName + " já declarada");
            } 
            else 
            {
                Functions.Add(fnName, context);
            }
        }
    }
}