using System.Collections.Generic;
using System.Linq;
using InferenceLibrary;
using InferenceLibrary.Rules;

namespace ItoFuzzyLogicInference
{
    public class DataRepository
    {
        public IEnumerable<FuzzyRule> FuzzyRules { get; set; }

        public IEnumerable<LinguisticVariable> LinguisticVariables { get; set; }

        public IEnumerable<LinguisticVariable> ConclusionVariables
        {
            get { return FuzzyRules.Select(r => r.Conclusion.MembershipFunction.LinguisticVariable).Distinct(); }
        }
        public IEnumerable<FuzzyCondition> ConditionsForVariable(LinguisticVariable variable)
        {
            return
                FuzzyRules.SelectMany(r => r.Conditions).Where(c => c.MembershipFunction.LinguisticVariable.Id == variable.Id);
            
        }

        public IEnumerable<LinguisticVariable> InputVariables(LinguisticVariable conclusionVariable)
        {
            return FuzzyRules.SelectMany(
                r => r.Conditions.Select(c => c.MembershipFunction.LinguisticVariable)
            ).Distinct();
        }
    }
}
