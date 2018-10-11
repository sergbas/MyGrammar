using System;

namespace MyGrammar.Parser
{
    public class NumericVariable : NumericEntity
    {
        private String variableName;

        public NumericVariable(String variableName) : base("var")
        {
            this.variableName = variableName;
        }

        public String getVariableName()
        {
            return variableName;
        }

    }
}