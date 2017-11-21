using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1O1
{
    class BoekHandel
    {
        public ICollection<BoekHandelItem> items;

        public BoekHandel()
        {
            items = new List<BoekHandelItem>();
        }

        public void VoegToe(BoekHandelItem item)
        {
            items.Add(item);
        }

        public void PrintOverzicht()
        {
            Console.WriteLine("== Boekhandel overzicht == \n");
            foreach (BoekHandelItem item in items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("========================== \n");
        }
    }
}
