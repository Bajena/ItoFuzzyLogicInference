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

        public IEnumerable<MembershipFunction> ConclusionMembershipFunctions
        {
            get { return FuzzyRules.Select(r => r.Conclusion.MembershipFunction); }
        }
    }
}
