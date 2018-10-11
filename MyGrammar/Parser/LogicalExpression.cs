using System;

namespace MyGrammar.Parser
{
    public abstract class LogicalExpression
    {
        private String type;

        public LogicalExpression(String type)
        {
            this.type = type;
        }

        public String getType()
        {
            return type;
        }
    }
}