using System;

namespace InferenceLibrary
{
    /// <summary>
    /// Trapezoid function used for calculating how well does the value describe a variable semantic value
    /// </summary>
    public class MembershipFunction
    {
        public MembershipFunction(string id, string displayName)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("id must be present");
            }
            if (string.IsNullOrWhiteSpace(displayName))
            {
                throw new ArgumentException("displayName must be present");
            }
            Id = id;
            DisplayName = displayName;
        }
        public MembershipFunction(string id, string displayName, double x1, double x2, double x3, double x4)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("id must be present");
            }
            if (string.IsNullOrWhiteSpace(displayName))
            {
                throw new ArgumentException("displayName must be present");
            }
            Id = id;
            DisplayName = displayName;
            X1 = x1;
            X2 = x2;
            X3 = x3;
            X4 = x4;
        }

        /// <summary>
        /// Internal id - used for search purposes. E.g. "slow"
        /// </summary>
        public string Id { get; private set; }
        /// <summary>
        /// Name used for display purposes only - E.g. "Very old"
        /// </summary>
        public string DisplayName { get; private set; }
        /// <summary>
        /// X value for left 0 value
        /// </summary>
        public double X1 { get; set; }
        /// <summary>
        /// X value for left 1 value
        /// </summary>
        public double X2 { get; set; }
        /// <summary>
        /// X value for right 1 value
        /// </summary>
        public double X3 { get; set; }
        /// <summary>
        /// X value for right 0 value
        /// </summary>
        public double X4 { get; set; }
        /// <summary>
        /// Min X value
        /// </summary>
        public double Min => X1;
        /// <summary>
        /// Max X value
        /// </summary>
        public double Max => X4;

        /// <summary>
        /// Calculates a degree of how well does the value fit the semantic value (e.g. how well does value: 60 describe age - "old") 
        /// </summary>
        /// <param name="value">Value from [0-1] range</param>
        /// <returns></returns>
        public double Fuzzify(double value)
        {
            //TODO: Add reverse trapezoid/triangle

            if (X1 <= value && value < X2)
            {
                return (value - X1)/(X2 - X1);
            }
            if (X2 <= value && value <= X3)
            {
                return 1;
            }
            if (X3 < value && value <= X4)
            {
                return (X4 - value)/(X4 - X3);
            }
            return 0;
        }
    }
}
