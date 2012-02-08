using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public abstract class Pizza
    {
        public String description = "Unknown Pizza";
        public virtual String getDescription()
        {
            return description;
        }
        public abstract double cost();
    }
}
