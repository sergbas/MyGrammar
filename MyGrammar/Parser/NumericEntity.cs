using System;

namespace MyGrammar.Parser
{
    public abstract class NumericEntity : ArithmeticExpression, ComparisonOperand {
    private String type;

    public NumericEntity(String type)
    {
        this.type = type;
    }

    public String getType()
    {
        return type;
    }
}
}