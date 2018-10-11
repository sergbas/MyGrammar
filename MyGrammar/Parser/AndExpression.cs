namespace MyGrammar.Parser
{
    public class AndExpression : LogicalExpression
    {
        private LogicalExpression left;
        private LogicalExpression right;

        public AndExpression(LogicalExpression left, LogicalExpression right) : base("and")
        {
            this.left = left;
            this.right = right;
        }

        public LogicalExpression getLeft()
        {
            return left;
        }

        public LogicalExpression getRight()
        {
            return right;
        }
    }
}