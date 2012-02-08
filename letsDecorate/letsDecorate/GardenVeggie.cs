using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class GardenVeggie : Pizza
    {
        public GardenVeggie()
        {
            description = "Garden Veggie Pizza";
        }
        public override double cost()
        {
            return 16.99;
        }
    }
}
