using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyGrammar.Parser
{
    public class RuleSet
    {
        private List<Rule> rules;

        public RuleSet()
        {
            this.rules = new List<Rule>();
        }

        private RuleSet(Collection<Rule> rules)
        {
            this.rules = new List<Rule>(rules);
        }

        public List<Rule> getRules()
        {
            return rules;
        }

        public void addRule(Rule rule)
        {
            this.rules.Add(rule);
        }
    }
}