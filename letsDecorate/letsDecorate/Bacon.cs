using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class Bacon : CondimentDecorator
    {
        Pizza pizza;
        public Bacon(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override String getDescription()
        {
            return pizza.getDescription() + ", Bacon";
        }
        public override double cost()
        {
            return 1.00 + pizza.cost();
        }
    }
}
