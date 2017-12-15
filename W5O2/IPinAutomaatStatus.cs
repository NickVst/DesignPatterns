namespace W5O2
{
    public interface IPinAutomaatStatus
    {

        void GeldOpvragen(int hoeveelheid);

        void KaartInvoeren();

        void KaartUitwerpen();

        void PincodeInvoeren(int pincode);
    }
}