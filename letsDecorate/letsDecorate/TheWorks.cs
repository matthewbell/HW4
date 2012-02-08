using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class TheWorks : Pizza
    {
        public TheWorks()
        {
            description = "The Works Pizza";
        }
        public override double cost()
        {
            return 18.99;
        }
    }
}
