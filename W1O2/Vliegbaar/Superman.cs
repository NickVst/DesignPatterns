using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1O2.Vliegbaar
{
    class Superman: IVliegbaar
    {
        public void Opstijgen()
        {
            Console.WriteLine("Superman stijgt op");
        }

        public void Vliegen()
        {
            Console.WriteLine("Superman is aan het vliegen");
        }

        public void Landen()
        {
            Console.WriteLine("Superman landt");
        }
    }
}
