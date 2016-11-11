using System.Collections.Generic;
using System.Linq;
using InferenceLibrary.Rules;

namespace InferenceLibrary
{
    /// <summary>
    /// Used for calculating output (sharp) values based on rule conclusion values 
    /// 
    /// </summary>
    public class Defuzzifier
    {
        private readonly IEnumerable<FuzzyConclusion> _conclusions;

        /// <summary>
        /// How many steps should the MinMax linguistic variable range be split into?
        /// </summary>
        public const int RangeStepsCount = 100;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conclusions">Conclusions with calculated premise modifiers</param>
        public Defuzzifier(IEnumerable<FuzzyConclusion> conclusions)
        {
            _conclusions = conclusions;
        }

        /// <summary>
        /// Calculates output (sharp) value based on rules conclusion values using Mean of Maxima method
        /// </summary>
        /// <returns>Numerical value for a linguistic variable</returns>
        public double Defuzzify()
        {
            var minX = _conclusions.Select(c => c.MembershipFunction.Min).Min();
            var maxX = _conclusions.Select(c => c.MembershipFunction.Max).Max();

            var max = 0.0;
            var startMax = 0.0;
            var len = 0.0;
            var step = 1.0;
            if (maxX - minX > 100)
            {
                step = (maxX - minX)/RangeStepsCount;
            }
            for (var i = minX; i <= maxX; i += step)
            {
                var maxFuzVal = _conclusions.Select(c => c.PremiseModifier * c.MembershipFunction.Fuzzify(i)).Max();
                if (max < maxFuzVal)
                {
                    max = maxFuzVal;
                    startMax = i;
                    len = 0.0;
                }
                else if (max == maxFuzVal && 0 < maxFuzVal)
                {
                    len += step;
                }
            }

            var mid = startMax + len / 2.0;

            return mid;
        }
    }
}
