using System;

namespace MyGrammar.Parser
{
    public class NumericConstant : NumericEntity
    {
        private Decimal value;

        public NumericConstant(Decimal value) : base("const")
        {
            this.value = value;
        }

        public Decimal getValue()
        {
            return value;
        }
    }
  
}