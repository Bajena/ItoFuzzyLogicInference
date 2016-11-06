using System.Linq;

namespace InferenceLibrary.Rules
{
    class FuzzyRuleEvaluator
    {
        private FuzzyRule _rule;

        public FuzzyRuleEvaluator(FuzzyRule rule)
        {
            _rule = rule;
        }

        public double Evaluate()
        {
            return _rule.Conditions.Min(c => c.MembershipFunction.Fuzzify(c.InputValue));
        }
    }
}
