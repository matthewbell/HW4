using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class ArtichokeHearts : CondimentDecorator
    {
        Pizza pizza;
        public ArtichokeHearts(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override String getDescription()
        {
            return pizza.getDescription() + ", Artichoke Hearts";
        }
        public override double cost()
        {
            return .85 + pizza.cost();
        }
    }
}
