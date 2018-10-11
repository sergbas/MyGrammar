using System;

namespace MyGrammar.Parser
{
    public class Negation : ArithmeticExpression
    {
        private ArithmeticExpression expression;

        public Negation(ArithmeticExpression expression)
        {
            this.expression = expression;
        }

        public String getType() { return "neg"; }

        public ArithmeticExpression getExpression()
        {
            return expression;
        }
    }
}