namespace MyGrammar.Parser
{
    public class OrExpression : LogicalExpression
    {
        private LogicalExpression left;
        private LogicalExpression right;

        public OrExpression(LogicalExpression left, LogicalExpression right) : base("or")
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