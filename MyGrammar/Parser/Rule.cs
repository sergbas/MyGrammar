using System;

namespace MyGrammar.Parser
{
    public class Rule
    {
        private LogicalExpression condition;

        private Conclusion conclusion;

        public Rule()
        {
        }

        public Rule(LogicalExpression condition, Conclusion conclusion)
        {
            this.condition = condition;
            this.conclusion = conclusion;
        }

        public LogicalExpression getCondition()
        {
            return condition;
        }

        public void setCondition(LogicalExpression condition)
        {
            this.condition = condition;
        }

        public Conclusion getConclusion()
        {
            return conclusion;
        }

        public void setConclusion(String conclusion)
        {
            this.conclusion = new Conclusion(conclusion);
        }


    }
}