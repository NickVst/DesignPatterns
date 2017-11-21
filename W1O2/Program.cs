using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1O2.Vliegbaar;

namespace W1O2
{
    class Program
    {
        static void Main(string[] args)
        {
            IVliegbaar s = new Superman();
            IVliegbaar v = new Vliegtuig();

            MaakVlucht(s);
            MaakVlucht(v);

            Console.ReadLine();
        }

        static void MaakVlucht(IVliegbaar vliegbaar)
        {
            vliegbaar.Opstijgen();
            for (int i = 0; i < 3; i++)
            {
                vliegbaar.Vliegen();
            }
            vliegbaar.Landen();
            Console.WriteLine();
        }
    }
}
