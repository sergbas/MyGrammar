using System;
using System.Collections.Generic;
using static GrammarRulesParser;

namespace MyGrammar.Parser
{
    public class TreeBuilder : GrammarRulesBaseListener
    {
        private RuleSet ruleSet = new RuleSet();
        private Rule rule = new Rule();
        private LogicalExpression condition = null;

        private Stack<LogicalExpression> logicalExpressions = new Stack<LogicalExpression>();
        private Stack<ComparisonOperand> comparisonOperands = new Stack<ComparisonOperand>();
        private Stack<ArithmeticExpression> arithmeticExpressions = new Stack<ArithmeticExpression>();

        public RuleSet getRuleSet()
        {
            return ruleSet;
        }

        override public void EnterRule_set(Rule_setContext ctx)
        {
            //ruleSet == null;
            //rule == null;
            //condition == null;

            //assert logicalExpressions.empty();
            //assert comparisonOperands.empty();
            //assert arithmeticExpressions.empty();
            
            this.ruleSet = new RuleSet();
        }

        override public void EnterSingle_rule(Single_ruleContext ctx)
        {
            this.rule = new Rule();
        }

        override public void ExitConclusion(ConclusionContext ctx)
        {
            this.rule.setConclusion(ctx.GetText());
        }

        override public void Els(ConclusionContext ctx)
        {
            this.rule.setConclusion(ctx.GetText());
        }

        override public void ExitSingle_rule(Single_ruleContext ctx)
        {
            this.rule.setCondition(this.logicalExpressions.Pop());
            this.ruleSet.addRule(this.rule);
            this.rule = null;
        }

        override public void ExitNumericVariable(NumericVariableContext ctx)
        {
            this.arithmeticExpressions.Push(new NumericVariable(ctx.GetText()));
        }

        override public void ExitNumericConst(NumericConstContext ctx)
        {
            //DecimalFormatSymbols symbols = new DecimalFormatSymbols();
            //symbols.setDecimalSeparator('.');
            //String pattern = "#0.0#";

            //DecimalFormat decimalFormat = new DecimalFormat(pattern, symbols);
            //decimalFormat.setParseBigDecimal(true);
            //BigDecimal value;
            //try
            //{
            //    value = (BigDecimal)decimalFormat.parse(ctx.GetText());
            //}
            //catch (ParseException e)
            //{
            //    throw new RuntimeException(e);
            //}
            this.arithmeticExpressions.Push(new NumericConstant(Decimal.Parse(ctx.GetText())));
        }

        override public void EnterNumericConst(NumericConstContext ctx)
        {
            base.EnterNumericConst(ctx);
        }

        override public void ExitArithmeticExpressionMult(ArithmeticExpressionMultContext ctx)
        {
            exitRealArithmeticExpression("*");
        }

        override public void ExitArithmeticExpressionDiv(ArithmeticExpressionDivContext ctx)
        {
            exitRealArithmeticExpression("/");
        }

        override public void ExitArithmeticExpressionPlus(ArithmeticExpressionPlusContext ctx)
        {
            exitRealArithmeticExpression("+");
        }

        override public void ExitArithmeticExpressionMinus(ArithmeticExpressionMinusContext ctx)
        {
            exitRealArithmeticExpression("-");
        }

        protected void exitRealArithmeticExpression(String op)
        {
            // popping order matters
            ArithmeticExpression right = this.arithmeticExpressions.Pop();
            ArithmeticExpression left = this.arithmeticExpressions.Pop();
            RealArithmeticExpression expr = new RealArithmeticExpression(op, left, right);
            this.arithmeticExpressions.Push(expr);
        }

        override public void ExitArithmeticExpressionNegation(
            ArithmeticExpressionNegationContext ctx)
        {
            Negation negation = new Negation(this.arithmeticExpressions.Pop());
            this.arithmeticExpressions.Push(negation);
        }

        override public void ExitComparison_operand(Comparison_operandContext ctx)
        {
            ArithmeticExpression expr = this.arithmeticExpressions.Pop();
            this.comparisonOperands.Push(expr);
        }

        override public void ExitComparisonExpressionWithOperator(
            ComparisonExpressionWithOperatorContext ctx)
        {
            // popping order matters
            ComparisonOperand right = this.comparisonOperands.Pop();
            ComparisonOperand left = this.comparisonOperands.Pop();
            String op = ctx.GetChild(1).GetText();
            ComparisonExpression expr = new ComparisonExpression(op, left, right);
            this.logicalExpressions.Push(expr);
        }

        override public void ExitLogicalConst(LogicalConstContext ctx)
        {
            switch (ctx.GetText().ToUpper())
            {
                case "TRUE":
                    this.logicalExpressions.Push(LogicalConstant.getTrue());
                    break;
                case "FALSE":
                    this.logicalExpressions.Push(LogicalConstant.getFalse());
                    break;
                default:
                    throw new Exception("Unknown logical constant: " + ctx.GetText());
            }
        }

        override public void ExitLogicalVariable(LogicalVariableContext ctx)
        {
            LogicalVariable variable = new LogicalVariable(ctx.GetText());
            this.logicalExpressions.Push(variable);
        }

        override public void ExitLogicalExpressionOr(LogicalExpressionOrContext ctx)
        {
            // popping order matters
            LogicalExpression right = logicalExpressions.Pop();
            LogicalExpression left = logicalExpressions.Pop();
            OrExpression expr = new OrExpression(left, right);
            this.logicalExpressions.Push(expr);
        }

        override public void ExitLogicalExpressionAnd(LogicalExpressionAndContext ctx)
        {
            // popping order matters
            LogicalExpression right = logicalExpressions.Pop();
            LogicalExpression left = logicalExpressions.Pop();
            AndExpression expr = new AndExpression(left, right);
            this.logicalExpressions.Push(expr);
        }
    }
}