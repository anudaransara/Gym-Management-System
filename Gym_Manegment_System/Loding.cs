using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Manegment_System
{
    public partial class Loding : Form
    {
        public Loding()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 3;

            if (panel3.Width >= 606)
            {
                timer1.Stop();
                loging_form fm1 = new loging_form();
                fm1.Show();
                this.Hide();
            }
        }
    }
}
