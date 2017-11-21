using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3O1.Models
{
    public class Station
    {
        // Je kunt niet een member met dezelfde naam als de klasse hebben..
        public string Naam { get; set; }
        public string AankomstSpoor { get; set; }
        public DateTime AankomstTijd { get; set; }
        public DateTime VertrekTijd { get; set; }

        public Station(string naam, string aankomstSpoor, DateTime aankomstTijd, DateTime vertrekTijd)
        {
            Naam = naam;
            AankomstSpoor = aankomstSpoor;
            AankomstTijd = aankomstTijd;
            VertrekTijd = vertrekTijd;
        }

    }
}
