//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Projects/MyGrammar\GrammarRules.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IGrammarRulesListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class GrammarRulesBaseListener : IGrammarRulesListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammarRulesParser.rule_set"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRule_set([NotNull] GrammarRulesParser.Rule_setContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammarRulesParser.rule_set"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRule_set([NotNull] GrammarRulesParser.Rule_setContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammarRulesParser.single_rule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingle_rule([NotNull] GrammarRulesParser.Single_ruleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammarRulesParser.single_rule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingle_rule([NotNull] GrammarRulesParser.Single_ruleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammarRulesParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondition([NotNull] GrammarRulesParser.ConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammarRulesParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondition([NotNull] GrammarRulesParser.ConditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammarRulesParser.conclusion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConclusion([NotNull] GrammarRulesParser.ConclusionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammarRulesParser.conclusion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConclusion([NotNull] GrammarRulesParser.ConclusionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalEntity</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalEntity([NotNull] GrammarRulesParser.LogicalEntityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalEntity</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalEntity([NotNull] GrammarRulesParser.LogicalEntityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ComparisonExpression</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparisonExpression([NotNull] GrammarRulesParser.ComparisonExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ComparisonExpression</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparisonExpression([NotNull] GrammarRulesParser.ComparisonExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalExpressionInParen</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalExpressionInParen([NotNull] GrammarRulesParser.LogicalExpressionInParenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalExpressionInParen</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalExpressionInParen([NotNull] GrammarRulesParser.LogicalExpressionInParenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalExpressionAnd</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalExpressionAnd([NotNull] GrammarRulesParser.LogicalExpressionAndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalExpressionAnd</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalExpressionAnd([NotNull] GrammarRulesParser.LogicalExpressionAndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalExpressionOr</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalExpressionOr([NotNull] GrammarRulesParser.LogicalExpressionOrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalExpressionOr</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalExpressionOr([NotNull] GrammarRulesParser.LogicalExpressionOrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ComparisonExpressionWithOperator</c>
	/// labeled alternative in <see cref="GrammarRulesParser.comparison_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparisonExpressionWithOperator([NotNull] GrammarRulesParser.ComparisonExpressionWithOperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ComparisonExpressionWithOperator</c>
	/// labeled alternative in <see cref="GrammarRulesParser.comparison_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparisonExpressionWithOperator([NotNull] GrammarRulesParser.ComparisonExpressionWithOperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ComparisonExpressionParens</c>
	/// labeled alternative in <see cref="GrammarRulesParser.comparison_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparisonExpressionParens([NotNull] GrammarRulesParser.ComparisonExpressionParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ComparisonExpressionParens</c>
	/// labeled alternative in <see cref="GrammarRulesParser.comparison_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparisonExpressionParens([NotNull] GrammarRulesParser.ComparisonExpressionParensContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammarRulesParser.comparison_operand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparison_operand([NotNull] GrammarRulesParser.Comparison_operandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammarRulesParser.comparison_operand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparison_operand([NotNull] GrammarRulesParser.Comparison_operandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammarRulesParser.comp_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComp_operator([NotNull] GrammarRulesParser.Comp_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammarRulesParser.comp_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComp_operator([NotNull] GrammarRulesParser.Comp_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionMult</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArithmeticExpressionMult([NotNull] GrammarRulesParser.ArithmeticExpressionMultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionMult</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArithmeticExpressionMult([NotNull] GrammarRulesParser.ArithmeticExpressionMultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionMinus</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArithmeticExpressionMinus([NotNull] GrammarRulesParser.ArithmeticExpressionMinusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionMinus</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArithmeticExpressionMinus([NotNull] GrammarRulesParser.ArithmeticExpressionMinusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionParens</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArithmeticExpressionParens([NotNull] GrammarRulesParser.ArithmeticExpressionParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionParens</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArithmeticExpressionParens([NotNull] GrammarRulesParser.ArithmeticExpressionParensContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionNumericEntity</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArithmeticExpressionNumericEntity([NotNull] GrammarRulesParser.ArithmeticExpressionNumericEntityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionNumericEntity</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArithmeticExpressionNumericEntity([NotNull] GrammarRulesParser.ArithmeticExpressionNumericEntityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionDiv</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArithmeticExpressionDiv([NotNull] GrammarRulesParser.ArithmeticExpressionDivContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionDiv</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArithmeticExpressionDiv([NotNull] GrammarRulesParser.ArithmeticExpressionDivContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionPlus</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArithmeticExpressionPlus([NotNull] GrammarRulesParser.ArithmeticExpressionPlusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionPlus</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArithmeticExpressionPlus([NotNull] GrammarRulesParser.ArithmeticExpressionPlusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionNegation</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArithmeticExpressionNegation([NotNull] GrammarRulesParser.ArithmeticExpressionNegationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionNegation</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArithmeticExpressionNegation([NotNull] GrammarRulesParser.ArithmeticExpressionNegationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalConst</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_entity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalConst([NotNull] GrammarRulesParser.LogicalConstContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalConst</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_entity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalConst([NotNull] GrammarRulesParser.LogicalConstContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalVariable</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_entity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalVariable([NotNull] GrammarRulesParser.LogicalVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalVariable</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_entity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalVariable([NotNull] GrammarRulesParser.LogicalVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NumericConst</c>
	/// labeled alternative in <see cref="GrammarRulesParser.numeric_entity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericConst([NotNull] GrammarRulesParser.NumericConstContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NumericConst</c>
	/// labeled alternative in <see cref="GrammarRulesParser.numeric_entity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericConst([NotNull] GrammarRulesParser.NumericConstContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NumericVariable</c>
	/// labeled alternative in <see cref="GrammarRulesParser.numeric_entity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericVariable([NotNull] GrammarRulesParser.NumericVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NumericVariable</c>
	/// labeled alternative in <see cref="GrammarRulesParser.numeric_entity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericVariable([NotNull] GrammarRulesParser.NumericVariableContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
