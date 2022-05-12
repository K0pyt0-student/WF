using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void PickupRB_CheckedChanged(object sender, EventArgs e)
        {
            if (PickupRB.Checked == true) ;
        }

        private void BigWeightRB_CheckedChanged(object sender, EventArgs e)
        {
            if (BigWeightRB.Checked == true) ;
        }

        private void TrainRB_CheckedChanged(object sender, EventArgs e)
        {
            if (TrainRB.Checked == true) ;
        }
    }
}
