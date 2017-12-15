using System;

namespace W5O2
{
    public class KaartAanwezigStatus : IPinAutomaatStatus
    {
        private PinAutomaat pinAutomaat;

        public KaartAanwezigStatus(PinAutomaat pinAutomaat)
        {
            this.pinAutomaat = pinAutomaat;
        }

        public void GeldOpvragen(int hoeveelheid)
        {
            Console.WriteLine("Geef eerst uw pin.");
        }

        public void KaartInvoeren()
        {
            Console.WriteLine("Een kaart is al aanwezig.");
        }

        public void KaartUitwerpen()
        {
            Console.WriteLine("Uw kaart is uitgeworpen.");
            pinAutomaat.ZetAutomaatStatus(pinAutomaat.GeefGeenKaartAanwezigStatus());
        }

        public void PincodeInvoeren(int pincode)
        {
            if (pincode == 1234)
            {
                Console.WriteLine("U heeft de correcte pincode ingevoerd.\n");
                pinAutomaat.ZetAutomaatStatus(pinAutomaat.GeefCorrectePinStatus());
            }
            else
            {
                Console.WriteLine("Verkeerde pincode, probeer opnieuw.");
            }
        }
    }
}