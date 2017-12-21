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
    public partial class ReisInfoDisplay : Form, ITreinDisplay
    {
        public ReisInfoDisplay(ITreinReis reis)
        {
            InitializeComponent();
            reis.AddObserver(this);
        }

        void ITreinDisplay.Update(Station station)
        {
            lbl_toonHuidigStation.Text = station.VolgendStation;
            lbl_toonSpoor.Text = station.AankomstSpoor;
        }
    }
}
