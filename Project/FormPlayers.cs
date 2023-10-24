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
    public partial class FormPlayers : Form
    {
        public FormPlayers()
        {
            InitializeComponent();
        }

        private void FormPlayers_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
