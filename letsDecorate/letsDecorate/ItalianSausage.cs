using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class ItalianSausage : CondimentDecorator
    {
        Pizza pizza;
        public ItalianSausage(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override String getDescription()
        {
            return pizza.getDescription() + ", Italian Sausage";
        }
        public override double cost()
        {
            return 1.00 + pizza.cost();
        }
    }
}
