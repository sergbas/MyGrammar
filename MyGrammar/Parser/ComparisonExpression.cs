using System;

namespace MyGrammar.Parser
{
    public class ComparisonExpression : LogicalExpression
    {
        private String _operator;
        private ComparisonOperand left;
        private ComparisonOperand right;

        public ComparisonExpression(String _operator, ComparisonOperand left, ComparisonOperand right) : base("comp")
        {
            this._operator = _operator;
            this.left = left;
            this.right = right;
        }

        public String getOperator()
        {
            return _operator;
        }

        public ComparisonOperand getLeft()
        {
            return left;
        }

        public ComparisonOperand getRight()
        {
            return right;
        }
    }
}
