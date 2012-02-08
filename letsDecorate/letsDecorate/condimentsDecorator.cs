using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public abstract class CondimentDecorator : Pizza
    {
        public override abstract String getDescription();
    }
}
