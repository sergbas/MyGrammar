using System;

namespace MyGrammar.Parser
{
    public class RealArithmeticExpression : ArithmeticExpression
    {
        private String _operator;
        private ArithmeticExpression left;
        private ArithmeticExpression right;

        public RealArithmeticExpression(String _operator, ArithmeticExpression left, ArithmeticExpression right)
        {
            this._operator = _operator;
            this.left = left;
            this.right = right;
        }

        public String getType() { return "arith"; }

        public String getOperator()
        {
            return _operator;
        }

        public ArithmeticExpression getLeft()
        {
            return left;
        }


        public ArithmeticExpression getRight()
        {
            return right;
        }
    }
}