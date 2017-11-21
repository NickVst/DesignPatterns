using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1O3.Items
{
    class PotloodSlijper : IPotloodSlijper
    {
        public void Slijp(IPotlood potlood)
        {
            potlood.NaGeslepen();
        }
    }
}
