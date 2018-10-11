using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;

namespace MyGrammar
{
    class Program
    {
        static void Main(string[] args)
        {
            RulesListener rulesListener = new RulesListener();
            Parser.Parser.Parse(@"if -(A + 2) > 0.5 then be_careful;", rulesListener);

            Console.ReadLine();

        }

        public class RulesListener : GrammarRulesBaseListener
        {
            public RulesListener()
            {
                SearchList = new List<string>();
            }

            public List<string> SearchList { get; set; }
            
            public override void EnterCondition([NotNull] GrammarRulesParser.ConditionContext context)
            {
                //var LocalID = context?. primitive_expression()?.LOCAL_ID()?.GetText();
                //if (!string.IsNullOrEmpty(LocalID))
                //    SearchList.Add(LocalID.Replace("@", ""));
                SearchList.Add(context.GetText());
                base.EnterCondition(context);
            }

            public override void ExitCondition([NotNull] GrammarRulesParser.ConditionContext context)
            {
                //var LocalID = context?. primitive_expression()?.LOCAL_ID()?.GetText();
                //if (!string.IsNullOrEmpty(LocalID))
                //    SearchList.Add(LocalID.Replace("@", ""));
                SearchList.Add(context.GetText());
                base.ExitCondition(context);
            }

            public override void EnterConclusion(GrammarRulesParser.ConclusionContext context)
            {
                SearchList.Add(context.GetText());
                base.EnterConclusion(context);
            }

            public override void EnterLogicalEntity(GrammarRulesParser.LogicalEntityContext context)
            {
                SearchList.Add(context.GetText());
                base.EnterLogicalEntity(context);
            }

            public override void ExitLogicalEntity(GrammarRulesParser.LogicalEntityContext context)
            {
                SearchList.Add(context.GetText());
                base.ExitLogicalEntity(context);
            }
        }
    }
}
