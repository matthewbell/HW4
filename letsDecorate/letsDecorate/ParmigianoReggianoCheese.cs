using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class ParmigianoReggianoCheese : CondimentDecorator
    {
        Pizza pizza;
        public ParmigianoReggianoCheese(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override String getDescription()
        {
            return pizza.getDescription() + ", Parmigiano Reggiano Cheese";
        }
        public override double cost()
        {
            return .85 + pizza.cost();
        }
    }
}
