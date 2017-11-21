using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1O1.Items
{
    class CD : BoekHandelItem
    {
        public string Genre { get; set; }

        public CD(string titel, float prijs, int aantal, string genre) : base(titel, prijs, aantal)
        {
            Genre = genre;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine("Genre: " + Genre);
            return sb.ToString();
        }
    }
}
