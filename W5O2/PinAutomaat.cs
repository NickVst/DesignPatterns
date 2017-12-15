namespace W5O2
{
    public class PinAutomaat
    {
        private IPinAutomaatStatus automaatStatus;

        private int bedragInAutomaat = 2000;
        private CorrectePinStatus correctePinStatus;
        private GeenGeldStatus geenGeldAanwezig;
        private KaartAanwezigStatus kaartAanwezig;
        private GeenKaartStatus kaartNietAanwezig;

        public int BedragInAutomaat
        {
            get { return bedragInAutomaat; }
            set { bedragInAutomaat = value; }
        }

        public PinAutomaat()
        {
            correctePinStatus = new CorrectePinStatus(this);
            geenGeldAanwezig = new GeenGeldStatus(this);
            kaartAanwezig = new KaartAanwezigStatus(this);
            kaartNietAanwezig = new GeenKaartStatus(this);

            automaatStatus = GeefGeenKaartAanwezigStatus();
        }

        public CorrectePinStatus GeefCorrectePinStatus()
        {
            return correctePinStatus;
        }

        public GeenGeldStatus GeefGeenGeldStatus()
        {
            return geenGeldAanwezig;
        }

        public GeenKaartStatus GeefGeenKaartAanwezigStatus()
        {
            return kaartNietAanwezig;
        }

        public KaartAanwezigStatus GeefKaartAanwezigStatus()
        {
            return kaartAanwezig;
        }

        public void GeldOpvragen(int hoeveelheid)
        {
            automaatStatus.GeldOpvragen(hoeveelheid);
        }

        public void KaartInvoeren()
        {
            automaatStatus.KaartInvoeren();
        }

        public void KaartUitwerpen()
        {
            automaatStatus.KaartUitwerpen();
        }

        public void PincodeInvoeren(int pincode)
        {
            automaatStatus.PincodeInvoeren(pincode);
        }

        public void ZetAutomaatStatus(IPinAutomaatStatus automaatStatus)
        {
            this.automaatStatus = automaatStatus;
        }

        public void ZetBedragInAutomaat(int hoeveelheid)
        {
            this.BedragInAutomaat += hoeveelheid;
        }
    }
}