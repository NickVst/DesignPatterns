using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1O1.Items
{
    class Weekblad : BoekHandelItem
    {
        public DateTime UitgifteDag { get; set; }

        public Weekblad(string titel, float prijs, int aantal, DateTime uitgifteDag) : base(titel, prijs, aantal)
        {
            UitgifteDag = uitgifteDag;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine("Uitgifte dag: " + UitgifteDag.ToString("yyyy MMMM dd"));
            return sb.ToString();
        }
    }
}
