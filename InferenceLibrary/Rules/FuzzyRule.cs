using System.Collections.Generic;

namespace InferenceLibrary.Rules
{
    public class FuzzyRule
    {
        public List<FuzzyCondition> Conditions { get; set; }
        public FuzzyConclusion Conclusion { get; set; }

        public double Evaluate()
        {
            return new FuzzyRuleEvaluator(this).Evaluate();
        }
    }
}
