using System.Collections.Generic;
using System;
using System.Linq;

namespace InferenceLibrary.Rules
{
    /// <summary>
    /// Represents an (IF-THEN) fuzzy rule 
    /// </summary>
    public class FuzzyRule
    {
        /// <summary>
        /// IF (left) part of the rule - a set of AND connected conditions
        /// </summary>
        public IEnumerable<FuzzyCondition> Conditions { get; private set; }
        /// <summary>
        /// THEN (right) part of the rule
        /// </summary>
        public FuzzyConclusion Conclusion { get; private set; }

        public FuzzyRule(IEnumerable<FuzzyCondition> conditions, FuzzyConclusion conclusion)
        {

            if (conditions == null || !conditions.Any())
            {
                throw new ArgumentException("conditions must be present");
            }
            Conditions = conditions;
            Conclusion = conclusion;
        }

        /// <summary>
        /// Calculates a conclusion's PremiseModifier based on left side conditions
        /// </summary>
        /// <returns>Numerical (sharp) value - based on conditions and their input values</returns>
        public double Evaluate()
        {
            return new FuzzyRuleEvaluator(this).Evaluate();
        }
    }
}
