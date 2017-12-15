using System;

namespace W5O2
{
    public class GeenKaartStatus : IPinAutomaatStatus
    {
        private PinAutomaat pinAutomaat;

        public GeenKaartStatus(PinAutomaat pinAutomaat)
        {
            this.pinAutomaat = pinAutomaat;
        }

        public void GeldOpvragen(int hoeveelheid)
        {
            Console.WriteLine("Voer eerst uw kaart in.");
        }

        public void KaartInvoeren()
        {
            if(pinAutomaat.BedragInAutomaat == 0)
            {
                Console.WriteLine("Geen geld in automaat.");
                Console.WriteLine("Uw kaart is uitgeworpen.\n");
                pinAutomaat.ZetAutomaatStatus(pinAutomaat.GeefGeenGeldStatus());
                return;
            }
            Console.WriteLine("Geef uw pincode a.u.b.\n");
            pinAutomaat.ZetAutomaatStatus(pinAutomaat.GeefKaartAanwezigStatus());
        }

        public void KaartUitwerpen()
        {
            Console.WriteLine("Geen kaart aanwezig.");
        }

        public void PincodeInvoeren(int pincode)
        {
            Console.WriteLine("Geen kaart aanwezig.");
        }
    }
}