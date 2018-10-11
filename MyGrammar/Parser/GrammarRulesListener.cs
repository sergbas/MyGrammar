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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="GrammarRulesParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface IGrammarRulesListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammarRulesParser.rule_set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRule_set([NotNull] GrammarRulesParser.Rule_setContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammarRulesParser.rule_set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRule_set([NotNull] GrammarRulesParser.Rule_setContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammarRulesParser.single_rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingle_rule([NotNull] GrammarRulesParser.Single_ruleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammarRulesParser.single_rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingle_rule([NotNull] GrammarRulesParser.Single_ruleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammarRulesParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition([NotNull] GrammarRulesParser.ConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammarRulesParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition([NotNull] GrammarRulesParser.ConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammarRulesParser.conclusion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConclusion([NotNull] GrammarRulesParser.ConclusionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammarRulesParser.conclusion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConclusion([NotNull] GrammarRulesParser.ConclusionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalEntity</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalEntity([NotNull] GrammarRulesParser.LogicalEntityContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalEntity</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalEntity([NotNull] GrammarRulesParser.LogicalEntityContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ComparisonExpression</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparisonExpression([NotNull] GrammarRulesParser.ComparisonExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ComparisonExpression</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparisonExpression([NotNull] GrammarRulesParser.ComparisonExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalExpressionInParen</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalExpressionInParen([NotNull] GrammarRulesParser.LogicalExpressionInParenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalExpressionInParen</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalExpressionInParen([NotNull] GrammarRulesParser.LogicalExpressionInParenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalExpressionAnd</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalExpressionAnd([NotNull] GrammarRulesParser.LogicalExpressionAndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalExpressionAnd</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalExpressionAnd([NotNull] GrammarRulesParser.LogicalExpressionAndContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalExpressionOr</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalExpressionOr([NotNull] GrammarRulesParser.LogicalExpressionOrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalExpressionOr</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalExpressionOr([NotNull] GrammarRulesParser.LogicalExpressionOrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ComparisonExpressionWithOperator</c>
	/// labeled alternative in <see cref="GrammarRulesParser.comparison_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparisonExpressionWithOperator([NotNull] GrammarRulesParser.ComparisonExpressionWithOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ComparisonExpressionWithOperator</c>
	/// labeled alternative in <see cref="GrammarRulesParser.comparison_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparisonExpressionWithOperator([NotNull] GrammarRulesParser.ComparisonExpressionWithOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ComparisonExpressionParens</c>
	/// labeled alternative in <see cref="GrammarRulesParser.comparison_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparisonExpressionParens([NotNull] GrammarRulesParser.ComparisonExpressionParensContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ComparisonExpressionParens</c>
	/// labeled alternative in <see cref="GrammarRulesParser.comparison_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparisonExpressionParens([NotNull] GrammarRulesParser.ComparisonExpressionParensContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammarRulesParser.comparison_operand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparison_operand([NotNull] GrammarRulesParser.Comparison_operandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammarRulesParser.comparison_operand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparison_operand([NotNull] GrammarRulesParser.Comparison_operandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammarRulesParser.comp_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComp_operator([NotNull] GrammarRulesParser.Comp_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammarRulesParser.comp_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComp_operator([NotNull] GrammarRulesParser.Comp_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionMult</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticExpressionMult([NotNull] GrammarRulesParser.ArithmeticExpressionMultContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionMult</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticExpressionMult([NotNull] GrammarRulesParser.ArithmeticExpressionMultContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionMinus</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticExpressionMinus([NotNull] GrammarRulesParser.ArithmeticExpressionMinusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionMinus</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticExpressionMinus([NotNull] GrammarRulesParser.ArithmeticExpressionMinusContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionParens</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticExpressionParens([NotNull] GrammarRulesParser.ArithmeticExpressionParensContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionParens</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticExpressionParens([NotNull] GrammarRulesParser.ArithmeticExpressionParensContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionNumericEntity</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticExpressionNumericEntity([NotNull] GrammarRulesParser.ArithmeticExpressionNumericEntityContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionNumericEntity</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticExpressionNumericEntity([NotNull] GrammarRulesParser.ArithmeticExpressionNumericEntityContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionDiv</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticExpressionDiv([NotNull] GrammarRulesParser.ArithmeticExpressionDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionDiv</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticExpressionDiv([NotNull] GrammarRulesParser.ArithmeticExpressionDivContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionPlus</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticExpressionPlus([NotNull] GrammarRulesParser.ArithmeticExpressionPlusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionPlus</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticExpressionPlus([NotNull] GrammarRulesParser.ArithmeticExpressionPlusContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpressionNegation</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticExpressionNegation([NotNull] GrammarRulesParser.ArithmeticExpressionNegationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpressionNegation</c>
	/// labeled alternative in <see cref="GrammarRulesParser.arithmetic_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticExpressionNegation([NotNull] GrammarRulesParser.ArithmeticExpressionNegationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalConst</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_entity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalConst([NotNull] GrammarRulesParser.LogicalConstContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalConst</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_entity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalConst([NotNull] GrammarRulesParser.LogicalConstContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalVariable</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_entity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalVariable([NotNull] GrammarRulesParser.LogicalVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalVariable</c>
	/// labeled alternative in <see cref="GrammarRulesParser.logical_entity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalVariable([NotNull] GrammarRulesParser.LogicalVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NumericConst</c>
	/// labeled alternative in <see cref="GrammarRulesParser.numeric_entity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericConst([NotNull] GrammarRulesParser.NumericConstContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NumericConst</c>
	/// labeled alternative in <see cref="GrammarRulesParser.numeric_entity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericConst([NotNull] GrammarRulesParser.NumericConstContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NumericVariable</c>
	/// labeled alternative in <see cref="GrammarRulesParser.numeric_entity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericVariable([NotNull] GrammarRulesParser.NumericVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NumericVariable</c>
	/// labeled alternative in <see cref="GrammarRulesParser.numeric_entity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericVariable([NotNull] GrammarRulesParser.NumericVariableContext context);
}
