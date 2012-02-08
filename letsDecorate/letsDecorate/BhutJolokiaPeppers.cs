using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class BhutJolokiaPeppers : CondimentDecorator
    {
        Pizza pizza;
        public BhutJolokiaPeppers(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override String getDescription()
        {
            return pizza.getDescription() + ", Bhut Jolokia Peppers";
        }
        public override double cost()
        {
            return .85 + pizza.cost();
        }
    }
}
