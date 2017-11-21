using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1O1.Items;

namespace W1O1
{
    class Program
    {
        static void Main(string[] args)
        {
            BoekHandel handel = new BoekHandel();

            handel.VoegToe(new Boek("Boek", 15.99f, 57, "Auteur"));
            handel.VoegToe(new CD("CD", 1.99f, 78, "Genre"));
            handel.VoegToe(new Boek("Boek2", 5.99f, 14, "Auteur2"));
            handel.VoegToe(new Weekblad("Weekblad", 14.49f, 148, DateTime.Now.AddDays(-124)));

            handel.PrintOverzicht();

            Console.ReadKey();
        }
    }
}
