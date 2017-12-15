using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3O1
{
    class Program
    {
        static void Main(string[] args)
        {
            ITreinReis treinReis = new TreinReis();
            
            ITreinController treinController = new TreinController(treinReis);

            ControlPanel panel = new ControlPanel(treinController);
            panel.ShowDialog();
        }
    }
}
