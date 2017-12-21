using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3O1
{
    public partial class ControlPanel : Form
    {

        private ITreinController treinController;
        // ...

        internal ControlPanel(ITreinController treinController, I)
        {
            this.treinController = treinController;

            InitializeComponent();
        }

        private void btn_volgendStation_Click(object sender, EventArgs e)
        {
            treinController.VolgendStation();
        }

        private void btn_nieuwDisplay_Click(object sender, EventArgs e)
        {
            ReisInfoDisplay display = new ReisInfoDisplay(...);
//            treinController.AddObserver(display);
            display.Show();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            treinController.Reverse();
        }

        private void btn_lijstDisplay_Click(object sender, EventArgs e)
        {
            
        }
    }
}
