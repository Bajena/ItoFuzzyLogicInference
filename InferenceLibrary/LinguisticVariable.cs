using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenceLibrary
{
    public class LinguisticVariable
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string DisplayUnit { get; set; }
        public List<MembershipFunction> MembershipFunctions { get; set; }
    }
}
