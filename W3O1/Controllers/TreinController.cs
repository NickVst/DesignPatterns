using W3O1.Models;

namespace W3O1.Controllers
{
    public class TreinController : ITreinController
    {
        public ITreinReis TreinReis { get; set; }

        public TreinController()
        {
            TreinReis = new TreinReis();
        }

        public void VolgendStation()
        {
            TreinReis.VolgendStation();
        }

        public void KeerOm()
        {
            TreinReis.KeerOm();
        }
    }
    
}