using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3O1.Controllers;

namespace W3O1.Views
{
    public partial class ControlPanel : Form
    {
        private ITreinController controller;

        public ControlPanel()
        {
            controller = new TreinController();
            InitializeComponent();
        }

        private void btn_VolgendStation_Click(object sender, EventArgs e)
        {
            try
            {
                controller.VolgendStation();
            }
            catch (IndexOutOfRangeException)
            {
                controller.KeerOm();
            }
        }
    }
}
