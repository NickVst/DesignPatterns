using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1O2.Vliegbaar
{
    class Vliegtuig : IVliegbaar
    {
        public void Opstijgen()
        {
            Console.WriteLine("Vliegtuig stijgt op");
        }

        public void Vliegen()
        {
            Console.WriteLine("Vliegtuig is aan het vliegen");
        }

        public void Landen()
        {
            Console.WriteLine("Vliegtuig landt");
        }
    }
}
