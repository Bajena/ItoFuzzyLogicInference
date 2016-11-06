using System.Linq;

namespace InferenceLibrary.Rules
{
    class FuzzyRuleEvaluator
    {
        private readonly FuzzyRule _rule;

        public FuzzyRuleEvaluator(FuzzyRule rule)
        {
            _rule = rule;
        }
        /// <summary>
        /// Calculates a conclusion's PremiseModifier based on left side conditions
        /// </summary>
        /// <returns>Numerical (sharp) value - based on conditions and their input values</returns>
        public double Evaluate()
        {
            return _rule.Conditions.Min(c => c.MembershipFunction.Fuzzify(c.InputValue));
        }
    }
}
