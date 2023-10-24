using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI2
{
    public partial class FormPlash : Form
    {
        public FormPlash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 15;
            if (panel2.Width >= 549)
            {
                timer1.Stop();
                FormMain frm = new FormMain();
                frm.Show();
                this.Hide();
            }
        }
    }
}
