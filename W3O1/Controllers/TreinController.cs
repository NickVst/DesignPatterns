namespace W3O1
{
    internal class TreinController : ITreinController
    {

        private ITreinReis treinReis;

        public TreinController(ITreinReis treinReis)
        {
            this.treinReis = treinReis;
        }

        public void VolgendStation()
        {
            treinReis.VolgendStation();
        }

        public void AddObserver(ITreinDisplay treinDisplay)
        {
            treinReis.AddObserver(treinDisplay);
        }

        public void Reverse()
        {
            treinReis.Reverse();
        }
    }
}