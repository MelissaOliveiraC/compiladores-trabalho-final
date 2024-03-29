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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ProdyCParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IProdyCListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>progLine</c>
	/// labeled alternative in <see cref="ProdyCParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgLine([NotNull] ProdyCParser.ProgLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>progLine</c>
	/// labeled alternative in <see cref="ProdyCParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgLine([NotNull] ProdyCParser.ProgLineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProdyCParser.functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctions([NotNull] ProdyCParser.FunctionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProdyCParser.functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctions([NotNull] ProdyCParser.FunctionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProdyCParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] ProdyCParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProdyCParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] ProdyCParser.FunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnBlockLine</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnBlockLine([NotNull] ProdyCParser.FnBlockLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnBlockLine</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnBlockLine([NotNull] ProdyCParser.FnBlockLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnBodyLine</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnBodyLine([NotNull] ProdyCParser.FnBodyLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnBodyLine</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnBodyLine([NotNull] ProdyCParser.FnBodyLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnBodyLineMore</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnBodyLineMore([NotNull] ProdyCParser.FnBodyLineMoreContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnBodyLineMore</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnBodyLineMore([NotNull] ProdyCParser.FnBodyLineMoreContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnReturnExprLine</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnReturnExprLine([NotNull] ProdyCParser.FnReturnExprLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnReturnExprLine</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnReturnExprLine([NotNull] ProdyCParser.FnReturnExprLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fnReturnLine</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFnReturnLine([NotNull] ProdyCParser.FnReturnLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fnReturnLine</c>
	/// labeled alternative in <see cref="ProdyCParser.fnBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFnReturnLine([NotNull] ProdyCParser.FnReturnLineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProdyCParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParams([NotNull] ProdyCParser.ParamsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProdyCParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParams([NotNull] ProdyCParser.ParamsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>lineStmt</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLineStmt([NotNull] ProdyCParser.LineStmtContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lineStmt</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLineStmt([NotNull] ProdyCParser.LineStmtContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>lineIf</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLineIf([NotNull] ProdyCParser.LineIfContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lineIf</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLineIf([NotNull] ProdyCParser.LineIfContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>lineWhile</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLineWhile([NotNull] ProdyCParser.LineWhileContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lineWhile</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLineWhile([NotNull] ProdyCParser.LineWhileContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>lineFor</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLineFor([NotNull] ProdyCParser.LineForContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lineFor</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLineFor([NotNull] ProdyCParser.LineForContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>lineEOL</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLineEOL([NotNull] ProdyCParser.LineEOLContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lineEOL</c>
	/// labeled alternative in <see cref="ProdyCParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLineEOL([NotNull] ProdyCParser.LineEOLContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>funcInvocLine</c>
	/// labeled alternative in <see cref="ProdyCParser.funcInvoc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFuncInvocLine([NotNull] ProdyCParser.FuncInvocLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>funcInvocLine</c>
	/// labeled alternative in <see cref="ProdyCParser.funcInvoc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFuncInvocLine([NotNull] ProdyCParser.FuncInvocLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stmtAtrib</c>
	/// labeled alternative in <see cref="ProdyCParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmtAtrib([NotNull] ProdyCParser.StmtAtribContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stmtAtrib</c>
	/// labeled alternative in <see cref="ProdyCParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmtAtrib([NotNull] ProdyCParser.StmtAtribContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stmtInput</c>
	/// labeled alternative in <see cref="ProdyCParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmtInput([NotNull] ProdyCParser.StmtInputContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stmtInput</c>
	/// labeled alternative in <see cref="ProdyCParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmtInput([NotNull] ProdyCParser.StmtInputContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stmtOutput</c>
	/// labeled alternative in <see cref="ProdyCParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmtOutput([NotNull] ProdyCParser.StmtOutputContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stmtOutput</c>
	/// labeled alternative in <see cref="ProdyCParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmtOutput([NotNull] ProdyCParser.StmtOutputContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>lineFuncInvoc</c>
	/// labeled alternative in <see cref="ProdyCParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLineFuncInvoc([NotNull] ProdyCParser.LineFuncInvocContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lineFuncInvoc</c>
	/// labeled alternative in <see cref="ProdyCParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLineFuncInvoc([NotNull] ProdyCParser.LineFuncInvocContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>inputRead</c>
	/// labeled alternative in <see cref="ProdyCParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInputRead([NotNull] ProdyCParser.InputReadContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>inputRead</c>
	/// labeled alternative in <see cref="ProdyCParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInputRead([NotNull] ProdyCParser.InputReadContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>outputWriteVar</c>
	/// labeled alternative in <see cref="ProdyCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutputWriteVar([NotNull] ProdyCParser.OutputWriteVarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>outputWriteVar</c>
	/// labeled alternative in <see cref="ProdyCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutputWriteVar([NotNull] ProdyCParser.OutputWriteVarContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>outputWriteStr</c>
	/// labeled alternative in <see cref="ProdyCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutputWriteStr([NotNull] ProdyCParser.OutputWriteStrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>outputWriteStr</c>
	/// labeled alternative in <see cref="ProdyCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutputWriteStr([NotNull] ProdyCParser.OutputWriteStrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>outputWriteExpr</c>
	/// labeled alternative in <see cref="ProdyCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutputWriteExpr([NotNull] ProdyCParser.OutputWriteExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>outputWriteExpr</c>
	/// labeled alternative in <see cref="ProdyCParser.output"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutputWriteExpr([NotNull] ProdyCParser.OutputWriteExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>tipoInt</c>
	/// labeled alternative in <see cref="ProdyCParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTipoInt([NotNull] ProdyCParser.TipoIntContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>tipoInt</c>
	/// labeled alternative in <see cref="ProdyCParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTipoInt([NotNull] ProdyCParser.TipoIntContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>tipoString</c>
	/// labeled alternative in <see cref="ProdyCParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTipoString([NotNull] ProdyCParser.TipoStringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>tipoString</c>
	/// labeled alternative in <see cref="ProdyCParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTipoString([NotNull] ProdyCParser.TipoStringContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>tipoFloat</c>
	/// labeled alternative in <see cref="ProdyCParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTipoFloat([NotNull] ProdyCParser.TipoFloatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>tipoFloat</c>
	/// labeled alternative in <see cref="ProdyCParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTipoFloat([NotNull] ProdyCParser.TipoFloatContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>tipoBool</c>
	/// labeled alternative in <see cref="ProdyCParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTipoBool([NotNull] ProdyCParser.TipoBoolContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>tipoBool</c>
	/// labeled alternative in <see cref="ProdyCParser.tipo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTipoBool([NotNull] ProdyCParser.TipoBoolContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ifstIf</c>
	/// labeled alternative in <see cref="ProdyCParser.ifst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfstIf([NotNull] ProdyCParser.IfstIfContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ifstIf</c>
	/// labeled alternative in <see cref="ProdyCParser.ifst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfstIf([NotNull] ProdyCParser.IfstIfContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ifstIfElse</c>
	/// labeled alternative in <see cref="ProdyCParser.ifst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfstIfElse([NotNull] ProdyCParser.IfstIfElseContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ifstIfElse</c>
	/// labeled alternative in <see cref="ProdyCParser.ifst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfstIfElse([NotNull] ProdyCParser.IfstIfElseContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>whilestWhile</c>
	/// labeled alternative in <see cref="ProdyCParser.whilest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhilestWhile([NotNull] ProdyCParser.WhilestWhileContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>whilestWhile</c>
	/// labeled alternative in <see cref="ProdyCParser.whilest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhilestWhile([NotNull] ProdyCParser.WhilestWhileContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>whilestDoWhile</c>
	/// labeled alternative in <see cref="ProdyCParser.whilest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhilestDoWhile([NotNull] ProdyCParser.WhilestDoWhileContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>whilestDoWhile</c>
	/// labeled alternative in <see cref="ProdyCParser.whilest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhilestDoWhile([NotNull] ProdyCParser.WhilestDoWhileContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>forstFor</c>
	/// labeled alternative in <see cref="ProdyCParser.forst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForstFor([NotNull] ProdyCParser.ForstForContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>forstFor</c>
	/// labeled alternative in <see cref="ProdyCParser.forst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForstFor([NotNull] ProdyCParser.ForstForContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>blockLine</c>
	/// labeled alternative in <see cref="ProdyCParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockLine([NotNull] ProdyCParser.BlockLineContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>blockLine</c>
	/// labeled alternative in <see cref="ProdyCParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockLine([NotNull] ProdyCParser.BlockLineContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>condRelop</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondRelop([NotNull] ProdyCParser.CondRelopContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>condRelop</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondRelop([NotNull] ProdyCParser.CondRelopContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>condExpr</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondExpr([NotNull] ProdyCParser.CondExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>condExpr</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondExpr([NotNull] ProdyCParser.CondExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>condAnd</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondAnd([NotNull] ProdyCParser.CondAndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>condAnd</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondAnd([NotNull] ProdyCParser.CondAndContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>condOr</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondOr([NotNull] ProdyCParser.CondOrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>condOr</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondOr([NotNull] ProdyCParser.CondOrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>condNot</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondNot([NotNull] ProdyCParser.CondNotContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>condNot</c>
	/// labeled alternative in <see cref="ProdyCParser.cond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondNot([NotNull] ProdyCParser.CondNotContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>atribVar</c>
	/// labeled alternative in <see cref="ProdyCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtribVar([NotNull] ProdyCParser.AtribVarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>atribVar</c>
	/// labeled alternative in <see cref="ProdyCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtribVar([NotNull] ProdyCParser.AtribVarContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>atribVarStr</c>
	/// labeled alternative in <see cref="ProdyCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtribVarStr([NotNull] ProdyCParser.AtribVarStrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>atribVarStr</c>
	/// labeled alternative in <see cref="ProdyCParser.atrib"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtribVarStr([NotNull] ProdyCParser.AtribVarStrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprPlus</c>
	/// labeled alternative in <see cref="ProdyCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprPlus([NotNull] ProdyCParser.ExprPlusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprPlus</c>
	/// labeled alternative in <see cref="ProdyCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprPlus([NotNull] ProdyCParser.ExprPlusContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprMinus</c>
	/// labeled alternative in <see cref="ProdyCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprMinus([NotNull] ProdyCParser.ExprMinusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprMinus</c>
	/// labeled alternative in <see cref="ProdyCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprMinus([NotNull] ProdyCParser.ExprMinusContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprTerm</c>
	/// labeled alternative in <see cref="ProdyCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprTerm([NotNull] ProdyCParser.ExprTermContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprTerm</c>
	/// labeled alternative in <see cref="ProdyCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprTerm([NotNull] ProdyCParser.ExprTermContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>termMult</c>
	/// labeled alternative in <see cref="ProdyCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTermMult([NotNull] ProdyCParser.TermMultContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>termMult</c>
	/// labeled alternative in <see cref="ProdyCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTermMult([NotNull] ProdyCParser.TermMultContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>termDiv</c>
	/// labeled alternative in <see cref="ProdyCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTermDiv([NotNull] ProdyCParser.TermDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>termDiv</c>
	/// labeled alternative in <see cref="ProdyCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTermDiv([NotNull] ProdyCParser.TermDivContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>termFactor</c>
	/// labeled alternative in <see cref="ProdyCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTermFactor([NotNull] ProdyCParser.TermFactorContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>termFactor</c>
	/// labeled alternative in <see cref="ProdyCParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTermFactor([NotNull] ProdyCParser.TermFactorContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>factorExpr</c>
	/// labeled alternative in <see cref="ProdyCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactorExpr([NotNull] ProdyCParser.FactorExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>factorExpr</c>
	/// labeled alternative in <see cref="ProdyCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactorExpr([NotNull] ProdyCParser.FactorExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>factorVar</c>
	/// labeled alternative in <see cref="ProdyCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactorVar([NotNull] ProdyCParser.FactorVarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>factorVar</c>
	/// labeled alternative in <see cref="ProdyCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactorVar([NotNull] ProdyCParser.FactorVarContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>factorNum</c>
	/// labeled alternative in <see cref="ProdyCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactorNum([NotNull] ProdyCParser.FactorNumContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>factorNum</c>
	/// labeled alternative in <see cref="ProdyCParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactorNum([NotNull] ProdyCParser.FactorNumContext context);
}
