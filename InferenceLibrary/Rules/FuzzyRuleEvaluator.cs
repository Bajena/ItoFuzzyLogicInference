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
            return _rule.Conditions.Min(c => FuzzifyCondition(c));
        }

        private double FuzzifyCondition(FuzzyCondition c)
        {
            var result = c.MembershipFunction.Fuzzify(c.InputValue);
            InferenceDetails.Instance.FuzzificationResults[c.MembershipFunction] = result;
            return result;
        }
    }
}
