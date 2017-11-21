using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    class StandardLife : ILife
    {
        public bool CellShouldLive(bool livingCell, int neighbourCount)
        {
            if (neighbourCount == 2)
            {
                return livingCell;
            }
            else if (neighbourCount == 3)
            {
                return true;
            }
            return false;
        }
    }
}
