using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InferenceLibrary.Rules;

namespace InferenceLibrary
{
    public class Inference
    {
        public IEnumerable<FuzzyRule> Rules { get; }


        public Inference(IEnumerable<FuzzyRule> rules)
        {
            Rules = rules;
        }

        public double Infere()
        {
            foreach (FuzzyRule rule in Rules)
            {
                rule.Conclusion.PremiseModifier = rule.Evaluate();
            }

            return new Defuzzifier(Rules.Select(r => r.Conclusion)).Defuzzify();
        }
    }
}
