//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ProdyC.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ProdyCParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IProdyCVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>progLine</c>
	/// labeled alternative in <see cref="ProdyCParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgLine([NotNull] ProdyCParser.ProgLineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ProdyCParser.functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctions([NotNull] ProdyCParser.FunctionsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ProdyCParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] ProdyCParser.FunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnBlockLine</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnBlockLine([NotNull] ProdyCParser.FnBlockLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnBodyLine</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnBodyLine([NotNull] ProdyCParser.FnBodyLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnBodyLineMore</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnBodyLineMore([NotNull] ProdyCParser.FnBodyLineMoreContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnReturnExprLine</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnReturnExprLine([NotNull] ProdyCParser.FnReturnExprLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>fnReturnLine</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFnReturnLine([NotNull] ProdyCParser.FnReturnLineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ProdyCParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParams([NotNull] ProdyCParser.ParamsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lineStmt</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineStmt([NotNull] ProdyCParser.LineStmtContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lineIf</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineIf([NotNull] ProdyCParser.LineIfContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lineWhile</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineWhile([NotNull] ProdyCParser.LineWhileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lineFor</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineFor([NotNull] ProdyCParser.LineForContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lineEOL</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineEOL([NotNull] ProdyCParser.LineEOLContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>funcInvocLine</c>
	/// labeled alternative in <see cref="ProdyCParser.funcInvoc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncInvocLine([NotNull] ProdyCParser.FuncInvocLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>stmtAtrib</c>
	/// labeled alternative in <see cref="ProdyCParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmtAtrib([NotNull] ProdyCParser.StmtAtribContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>stmtInput</c>
	/// labeled alternative in <see cref="ProdyCParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmtInput([NotNull] ProdyCParser.StmtInputContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>stmtOutput</c>
	/// labeled alternative in <see cref="ProdyCParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStmtOutput([NotNull] ProdyCParser.StmtOutputContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>lineFuncInvoc</c>
	/// labeled alternative in <see cref="ProdyCParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineFuncInvoc([NotNull] ProdyCParser.LineFuncInvocContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>inputRead</c>
	/// labeled alternative in <see cref="ProdyCParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInputRead([NotNull] ProdyCParser.InputReadContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>outputWriteVar</c>
	/// labeled alternative in <see cref="ProdyCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputWriteVar([NotNull] ProdyCParser.OutputWriteVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>outputWriteStr</c>
	/// labeled alternative in <see cref="ProdyCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputWriteStr([NotNull] ProdyCParser.OutputWriteStrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>outputWriteExpr</c>
	/// labeled alternative in <see cref="ProdyCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOutputWriteExpr([NotNull] ProdyCParser.OutputWriteExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tipoInt</c>
	/// labeled alternative in <see cref="ProdyCParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTipoInt([NotNull] ProdyCParser.TipoIntContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tipoString</c>
	/// labeled alternative in <see cref="ProdyCParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTipoString([NotNull] ProdyCParser.TipoStringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tipoFloat</c>
	/// labeled alternative in <see cref="ProdyCParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTipoFloat([NotNull] ProdyCParser.TipoFloatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>tipoBool</c>
	/// labeled alternative in <see cref="ProdyCParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTipoBool([NotNull] ProdyCParser.TipoBoolContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ifstIf</c>
	/// labeled alternative in <see cref="ProdyCParser.ifst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfstIf([NotNull] ProdyCParser.IfstIfContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ifstIfElse</c>
	/// labeled alternative in <see cref="ProdyCParser.ifst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfstIfElse([NotNull] ProdyCParser.IfstIfElseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>whilestWhile</c>
	/// labeled alternative in <see cref="ProdyCParser.whilest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhilestWhile([NotNull] ProdyCParser.WhilestWhileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>whilestDoWhile</c>
	/// labeled alternative in <see cref="ProdyCParser.whilest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhilestDoWhile([NotNull] ProdyCParser.WhilestDoWhileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>forstFor</c>
	/// labeled alternative in <see cref="ProdyCParser.forst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForstFor([NotNull] ProdyCParser.ForstForContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>blockLine</c>
	/// labeled alternative in <see cref="ProdyCParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockLine([NotNull] ProdyCParser.BlockLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>condRelop</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondRelop([NotNull] ProdyCParser.CondRelopContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>condExpr</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondExpr([NotNull] ProdyCParser.CondExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>condAnd</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondAnd([NotNull] ProdyCParser.CondAndContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>condOr</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondOr([NotNull] ProdyCParser.CondOrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>condNot</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondNot([NotNull] ProdyCParser.CondNotContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>atribVar</c>
	/// labeled alternative in <see cref="ProdyCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtribVar([NotNull] ProdyCParser.AtribVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>atribVarStr</c>
	/// labeled alternative in <see cref="ProdyCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtribVarStr([NotNull] ProdyCParser.AtribVarStrContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprPlus</c>
	/// labeled alternative in <see cref="ProdyCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprPlus([NotNull] ProdyCParser.ExprPlusContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprMinus</c>
	/// labeled alternative in <see cref="ProdyCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprMinus([NotNull] ProdyCParser.ExprMinusContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>exprTerm</c>
	/// labeled alternative in <see cref="ProdyCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprTerm([NotNull] ProdyCParser.ExprTermContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>termMult</c>
	/// labeled alternative in <see cref="ProdyCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermMult([NotNull] ProdyCParser.TermMultContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>termDiv</c>
	/// labeled alternative in <see cref="ProdyCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermDiv([NotNull] ProdyCParser.TermDivContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>termFactor</c>
	/// labeled alternative in <see cref="ProdyCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTermFactor([NotNull] ProdyCParser.TermFactorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>factorExpr</c>
	/// labeled alternative in <see cref="ProdyCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactorExpr([NotNull] ProdyCParser.FactorExprContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>factorVar</c>
	/// labeled alternative in <see cref="ProdyCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactorVar([NotNull] ProdyCParser.FactorVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>factorNum</c>
	/// labeled alternative in <see cref="ProdyCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactorNum([NotNull] ProdyCParser.FactorNumContext context);
}