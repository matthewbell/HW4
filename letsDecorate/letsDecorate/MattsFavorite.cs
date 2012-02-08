using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace letsDecorate
{
    public class MattsFavorite : Pizza
    {
        public MattsFavorite()
        {
            description = "Matt's Favorite Pizza";
        }
        public override double cost()
        {
            return 17.99;
        }
    }
}
