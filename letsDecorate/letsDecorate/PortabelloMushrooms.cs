using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class PortabelloMushrooms : CondimentDecorator
    {
        Pizza pizza;
        public PortabelloMushrooms(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override String getDescription()
        {
            return pizza.getDescription() + ", Portabello Mushrooms";
        }
        public override double cost()
        {
            return .55 + pizza.cost();
        }
    }
}
