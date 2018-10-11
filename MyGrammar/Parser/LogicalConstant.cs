namespace MyGrammar.Parser
{
    public class LogicalConstant : LogicalExpression
    {
    private bool value;

    private LogicalConstant(bool value) : base ("const")
    {
        this.value = value;
    }


    public bool getValue()
    {
        return value;
    }

    public static LogicalConstant getTrue()
    {
        return new LogicalConstant(true);
    }

    public static LogicalConstant getFalse()
    {
        return new LogicalConstant(false);
    }
}
}