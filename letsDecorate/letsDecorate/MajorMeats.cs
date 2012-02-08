using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class MajorMeats : Pizza
    {
        public MajorMeats()
        {
            description = "Major Meats Pizza";
        }
        public override double cost()
        {
            return 17.99;
        }
    }
}
