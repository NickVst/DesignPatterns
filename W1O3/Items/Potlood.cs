using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1O3.Items
{
    class Potlood : IPotlood
    {
        public bool IsScherp { get; }

        private int maxTeSchrijven;
        private int geschrevenKarakters;

        public Potlood(int maxTeSchrijven)
        {
            this.maxTeSchrijven = maxTeSchrijven;
            NaGeslepen();
        }

        public void Schrijf(string boodschap)
        {
            foreach (char c in boodschap)
            {
                if (geschrevenKarakters < maxTeSchrijven)
                {
                    Console.Write(c);
                }
                else
                {
                    Console.Write('#');
                }
                geschrevenKarakters++;
            }
            Console.WriteLine();
        }

        public void NaGeslepen()
        {
            geschrevenKarakters = 0;
        }
    }
}
