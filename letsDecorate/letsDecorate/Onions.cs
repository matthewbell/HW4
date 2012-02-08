using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class Onions : CondimentDecorator
    {
        Pizza pizza;
        public Onions(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override String getDescription()
        {
            return pizza.getDescription() + ", Onions";
        }
        public override double cost()
        {
            return .55 + pizza.cost();
        }
    }
}
