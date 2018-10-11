using System;
using System.Collections.Generic;

namespace MyGrammar
{
    class Program
    {
        static void Main(string[] args)
        {
            RulesListener rulesListener = new RulesListener();
            Parser.Parser.Parse(@"if a>1 and x<10000 or a>=b then conclusion", rulesListener);

            Console.ReadLine();

        }

        public class RulesListener : GrammarRulesBaseListener
        {
            public RulesListener()
            {
                SearchList = new List<string>();
            }

            public List<string> SearchList { get; set; }
            /*
            public override void EnterRule_set([NotNull] GrammarRulesParser.ExpressionContext context)
            {
                var LocalID = context?.primitive_expression()?.LOCAL_ID()?.GetText();
                if (!string.IsNullOrEmpty(LocalID))
                    SearchList.Add(LocalID.Replace("@", ""));
                base.EnterExpression(context);
            }*/
        }
    }
}
