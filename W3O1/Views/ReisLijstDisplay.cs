using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3O1.Views
{
    public partial class ReisLijstDisplay : Form, ITreinDisplay
    {
        public ReisLijstDisplay()
        {
            InitializeComponent();
        }

        void ITreinDisplay.Update(Station station)
        {
            throw new NotImplementedException();
        }
    }
}
