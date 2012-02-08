using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class Pepperoni : CondimentDecorator
    {
        Pizza pizza;
        public Pepperoni(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override String getDescription()
        {
            return pizza.getDescription() + ", Pepperoni";
        }
        public override double cost()
        {
            return 1.00 + pizza.cost();
        }
    }
}
