using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenceLibrary
{
    /// <summary>
    /// Represents a linguistic variable - e.g. "Age"
    /// </summary>
    public class LinguisticVariable
    {
        public LinguisticVariable(string id, string displayName, IEnumerable<MembershipFunction> membershipFunctions, string displayUnit = "")
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("id must be present");
            }
            if (string.IsNullOrWhiteSpace(displayName))
            {
                throw new ArgumentException("displayName must be present");
            }
            if (membershipFunctions == null || !membershipFunctions.Any())
            {
                throw new ArgumentException("membershipFunctions must be present");
            }
            Id = id;
            DisplayName = displayName;
            MembershipFunctions = membershipFunctions;
            DisplayUnit = displayUnit;
        }

        /// <summary>
        /// Internal id for search purposes (e.g. "age")
        /// </summary>
        public string Id { get; private set; }
        /// <summary>
        /// Name for display purposes (e.g. "Salary value")
        /// </summary>
        public string DisplayName { get; }
        /// <summary>
        /// Unit for display purposes (e.g. "years")
        /// </summary>
        public string DisplayUnit { get; private set; }
        /// <summary>
        /// Membership functions for this variable - e.g. ("slow", "medium", "fast") for "speed" variable
        /// </summary>
        public IEnumerable<MembershipFunction> MembershipFunctions { get; private set; }
    }
}
