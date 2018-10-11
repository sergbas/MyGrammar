using System;

namespace MyGrammar.Parser
{
    public class LogicalVariable : LogicalExpression
    {
        private String variableName;

        public LogicalVariable(String variableName) : base("var")
        {
            this.variableName = variableName;
        }


        public String getVariableName()
        {
            return variableName;
        }

    }
}