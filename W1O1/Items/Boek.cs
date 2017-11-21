using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1O1.Items
{
    class Boek : BoekHandelItem
    {
        public string Auteur { get; set; }

        public Boek(string titel, float prijs, int aantal, string auteur) : base(titel, prijs, aantal)
        {
            Auteur = auteur;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine("Auteur: " + Auteur);
            return sb.ToString();
        }
    }
}
