using Antlr4.Runtime.Misc;
using MyGrammar.Parser;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyGrammar
{
    class Program
    {
        static void Main(string[] args)
        {
            CompilerTest ct = new CompilerTest("if ((A > 2) OR (A < 3)) then TheConclusion else AnotherAction;",
                    createRuleSet(new ComparisonExpression("=",
                        new NumericVariable("A"),
                        new NumericConstant(1))));
            ct.testRule();
            /*
            RulesListener rulesListener = new RulesListener();
            (new  Parser.Parser()).Parse(@"
if A > 1 then xxx;
//if (A + 2) > 0.5 then be_careful;", rulesListener);
*/
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

        private static Conclusion standardConclusion = new Conclusion("TheConclusion");

        private static RuleSet createRuleSet(LogicalExpression condition)
        {
            RuleSet ruleSet = new RuleSet();
            //foreach (LogicalExpression condition in conditions)
            {
                Rule rule = new Rule(condition, standardConclusion);
                ruleSet.addRule(rule);
            }
            return ruleSet;
        }

        public class CompilerTest
        {

            /*
    public static Collection<Object[]> data()
            {
                return Arrays.asList(new Object[][]{
                {
                    "if A = 1 then TheConclusion;",
                    createRuleSet(new ComparisonExpression("=",
                        new NumericVariable("A"),
                        new NumericConstant(BigDecimal.valueOf(1))))
                },

                {
                    "if (true) then TheConclusion;",
                    createRuleSet(LogicalConstant.getTrue())
                },

                {
                    "if a + 2 < 1 and c or b then TheConclusion;",
                    createRuleSet(new OrExpression(
                        new AndExpression(
                            new ComparisonExpression(
                                "<",
                                new RealArithmeticExpression(
                                    "+",
                                    new NumericVariable("a"),
                                    new NumericConstant(BigDecimal.valueOf(2))),
                                new NumericConstant(BigDecimal.valueOf(1))
                            ),
                            new LogicalVariable("c")
                        ),
                        new LogicalVariable("b")
                    ))
                },
        });
            }
            */
            private String stringToCompile;
            private RuleSet targetRuleSet;

            public CompilerTest(String stringToCompile, RuleSet targetRuleSet)
            {
                this.stringToCompile = stringToCompile;
                this.targetRuleSet = targetRuleSet;
            }

            public void testRule()
            {
                Parser.Parser compiler = new Parser.Parser();
                RuleSet gotRuleSet = compiler.compile(stringToCompile);
                //assertEquals(gotRuleSet, targetRuleSet);
            }
        }
    }
}
