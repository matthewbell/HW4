using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class KalmataOlives : CondimentDecorator
    {
        Pizza pizza;
        public KalmataOlives(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override String getDescription()
        {
            return pizza.getDescription() + ", Kalmata Olives";
        }
        public override double cost()
        {
            return .85 + pizza.cost();
        }
    }
}
