using System;

namespace W3O1
{
    internal class Station
    {
        public string VolgendStation { get; set; }
        public string AankomstSpoor { get; set; }
        public DateTime AankomstTijd { get; set; }
        public DateTime VertrekTijd { get; set; }

        public Station(string volgendStation, string aankomstSpoor, DateTime aankomstTijd, DateTime vertrekTijd)
        {
            VolgendStation = volgendStation;
            AankomstSpoor = aankomstSpoor;
            AankomstTijd = aankomstTijd;
            VertrekTijd = vertrekTijd;
        }

    }
}