using System;

namespace MyGrammar.Parser
{
    public class Conclusion
    {
        private String name;

        public Conclusion(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }
    }
}