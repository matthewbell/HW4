using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class GreenPeppers : CondimentDecorator
    {
        Pizza pizza;
        public GreenPeppers(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override String getDescription()
        {
            return pizza.getDescription() + ", Green Peppers";
        }
        public override double cost()
        {
            return .55 + pizza.cost();
        }
    }
}
