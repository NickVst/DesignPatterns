using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6O1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[[shop creating expensive computers]]");
            ComputerShop shop1 = new HighBudgetShop();
            shop1.AssembleMachine();

            Console.WriteLine();

            Console.WriteLine("[[shop creating cheap computers]]");
            ComputerShop shop2 = new LowBudgetShop();
            shop2.AssembleMachine();

            Console.ReadKey();
        }
    }
}
