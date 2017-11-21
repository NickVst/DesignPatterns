using System;
using System.Text;

namespace W2O3
{
    public class Nummer
    {
        public string Naam { get; set; }
        public string Artiest { get; set; }
        public TimeSpan Duur { get; set; }

        public Nummer(string naam, string artiest, TimeSpan duur)
        {
            Naam = naam;
            Artiest = artiest;
            Duur = duur;
        }
        
    }
}