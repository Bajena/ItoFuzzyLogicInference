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
            return _rule.Conditions.Min(c => EvaluateCondition(c));
        }

        private double EvaluateCondition(FuzzyCondition condition)
        {
            var fuzzified = FuzzifyCondition(condition);
            return condition.Negated ? 1 - fuzzified : fuzzified;
        }

        private double FuzzifyCondition(FuzzyCondition condition)
        {
            var result = condition.MembershipFunction.Fuzzify(condition.InputValue);
            InferenceDetails.Instance.FuzzificationResults[condition.MembershipFunction] = result;
            return result;
        }
    }
}
