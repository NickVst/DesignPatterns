using System;

namespace W5O2
{
    public class CorrectePinStatus : IPinAutomaatStatus
    {

        private PinAutomaat pinAutomaat;

        public CorrectePinStatus(PinAutomaat pinAutomaat)
        {
            this.pinAutomaat = pinAutomaat;
        }

        public void GeldOpvragen(int hoeveelheid)
        {
            if (hoeveelheid > pinAutomaat.BedragInAutomaat)
            {
                Console.WriteLine("Niet genoeg geld in automaat.");
            }
            else
            {
                pinAutomaat.BedragInAutomaat -= hoeveelheid;
                Console.WriteLine("{0} uit automaat gehaald.", hoeveelheid);
                pinAutomaat.KaartUitwerpen();
            }
        }

        public void KaartInvoeren()
        {
            Console.WriteLine("U heeft uw kaart al ingevoerd.");
        }

        public void KaartUitwerpen()
        {
            Console.WriteLine("Uw kaart is uitgeworpen.\n");
            pinAutomaat.ZetAutomaatStatus(pinAutomaat.GeefGeenKaartAanwezigStatus());
        }

        public void PincodeInvoeren(int pincode)
        {
            Console.WriteLine("U heeft uw pincode al ingevoerd.");
            Console.WriteLine();
        }
    }
}