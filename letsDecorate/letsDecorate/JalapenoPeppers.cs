using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class JalapenoPeppers : CondimentDecorator
    {
        Pizza pizza;
        public JalapenoPeppers(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override String getDescription()
        {
            return pizza.getDescription() + ", Jalapeño Peppers";
        }
        public override double cost()
        {
            return .55 + pizza.cost();
        }
    }
}
