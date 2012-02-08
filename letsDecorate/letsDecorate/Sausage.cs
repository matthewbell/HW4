using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class Sausage : CondimentDecorator
    {
        Pizza pizza;
        public Sausage(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override String getDescription()
        {
            return pizza.getDescription() + ", Sausage";
        }
        public override double cost()
        {
            return 1.00 + pizza.cost();
        }
    }
}
