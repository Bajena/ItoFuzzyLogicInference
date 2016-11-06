using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenceLibrary
{
    public class MembershipFunction
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double X3 { get; set; }
        public double X4 { get; set; }

        public double Min => X1;
        public double Max => X4;

        public double Fuzzify(double value)
        {
            if (X1 <= value && value < X2)
                return (value - X1) / (X2 - X1);
            if (X2 <= value && value <= X3)
                return 1;
            if (X3 < value && value <= X4)
                return (X4 - value) / (X4 - X3);
            return 0;
        }
    }
}
