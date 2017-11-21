using W3O1.Models;

namespace W3O1.Controllers
{
    interface ITreinController
    {
        ITreinReis TreinReis { get; set; }

        void VolgendStation();
        void KeerOm();
        
    }
}