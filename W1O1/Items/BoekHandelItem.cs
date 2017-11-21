using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1O1
{
    abstract class BoekHandelItem
    {
        public string Titel { get; set; }
        public float Prijs { get; set; }
        public int Aantal { get; set; }

        public BoekHandelItem(string titel, float prijs, int aantal)
        {
            Titel = titel;
            Prijs = prijs;
            Aantal = aantal;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Titel: " + Titel);
            sb.AppendLine("Prijs: " + Prijs);
            sb.AppendLine("Aantal: " + Aantal);
            return sb.ToString();
        }
    }
}
