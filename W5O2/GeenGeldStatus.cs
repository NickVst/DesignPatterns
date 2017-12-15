using System;

namespace W5O2
{
    public class GeenGeldStatus : IPinAutomaatStatus
    {
        private PinAutomaat pinAutomaat;

        public GeenGeldStatus(PinAutomaat pinAutomaat)
        {
            this.pinAutomaat = pinAutomaat;
        }

        public void GeldOpvragen(int hoeveelheid)
        {
            Console.WriteLine("Geen geld in automaat.");
            pinAutomaat.KaartUitwerpen();
        }

        public void KaartInvoeren()
        {
            Console.WriteLine("Geen geld in automaat.");
            pinAutomaat.KaartUitwerpen();
        }

        public void KaartUitwerpen()
        {
            Console.WriteLine("Uw kaart is uitgeworpen.");
        }

        public void PincodeInvoeren(int pincode)
        {
            Console.WriteLine("Geen geld in automaat.");
        }
    }
}