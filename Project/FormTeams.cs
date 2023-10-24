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
    public partial class FormTeams : Form
    {
        public FormTeams()
        {
            InitializeComponent();
        }

        private void FormTeams_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
