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
    public partial class FormMain : Form
    {
        FormPlayers players;
        FormTeams teams;
        FormMatches matches;
        FormSettings settings;
        FormTables tables;
        FormSub1 sub1;
        FormSub2 sub2;
        FormSub3 sub3;
        public FormMain()
        {
            InitializeComponent();
        }

        bool menuExpand = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 225)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 55)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 81)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnlPlayers.Width = sidebar.Width;
                    pnlTeams.Width = sidebar.Width;
                    pnlTables.Width = sidebar.Width;
                    pnlMatchces.Width = sidebar.Width;
                    pnlSettings.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 280)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnlPlayers.Width = sidebar.Width;
                    pnlTeams.Width = sidebar.Width;
                    pnlTables.Width = sidebar.Width;
                    pnlMatchces.Width = sidebar.Width;
                    pnlSettings.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (players == null)
            {
                players = new FormPlayers();
                players.FormClosed += FormPlayers_FormClosed;
                players.MdiParent = this;
                players.Dock = DockStyle.Fill;
                players.Show();
            }
            else
            {
                players.Activate();
            }
        }

        private void FormPlayers_FormClosed(object sender, FormClosedEventArgs e)
        {
            players = null;
        }

        private void btnSub1_Click(object sender, EventArgs e)
        {
            if (sub1 == null)
            {
                sub1 = new FormSub1();
                sub1.FormClosed += FormSub1_FormClosed;
                sub1.MdiParent = this;
                sub1.Dock = DockStyle.Fill;
                sub1.Show();
            }
            else
            {
                sub1.Activate();
            }
        }

        private void FormSub1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub1 = null;
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
            if (sub2 == null)
            {
                sub2 = new FormSub2();
                sub2.FormClosed += FormSub2_FormClosed;
                sub2.MdiParent = this;
                sub2.Dock = DockStyle.Fill;
                sub2.Show();
            }
            else
            {
                sub2.Activate();
            }
        }

        private void FormSub2_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub2 = null;
        }

        private void btnSub3_Click(object sender, EventArgs e)
        {
            if (sub3 == null)
            {
                sub3 = new FormSub3();
                sub3.FormClosed += FormSub3_FormClosed;
                sub3.MdiParent = this;
                sub3.Dock = DockStyle.Fill;
                sub3.Show();
            }
            else
            {
                sub3.Activate();
            }
        }

        private void FormSub3_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub3 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (teams == null)
            {
                teams = new FormTeams();
                teams.FormClosed += FormTeams_FormClosed;
                teams.MdiParent = this;
                teams.Dock = DockStyle.Fill;
                teams.Show();
            }
            else
            {
                teams.Activate();
            }
        }

        private void FormTeams_FormClosed(object sender, FormClosedEventArgs e)
        {
            teams = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (matches == null)
            {
                matches = new FormMatches();
                matches.FormClosed += FormMatches_FormClosed;
                matches.MdiParent = this;
                matches.Dock = DockStyle.Fill;
                matches.Show();
            }
            else
            {
                matches.Activate();
            }
        }

        private void FormMatches_FormClosed(object sender, FormClosedEventArgs e)
        {
            matches = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tables == null)
            {
                tables = new FormTables();
                tables.FormClosed += FormTables_FormClosed;
                tables.MdiParent = this;
                tables.Dock = DockStyle.Fill;
                tables.Show();
            }
            else
            {
                tables.Activate();
            }
        }

        private void FormTables_FormClosed(object sender, FormClosedEventArgs e)
        {
            tables = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new FormSettings();
                settings.FormClosed += FormSettings_FormClosed;
                settings.MdiParent = this;
                settings.Dock = DockStyle.Fill;
                settings.Show();
            }
            else
            {
                settings.Activate();
            }
        }

        private void FormSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
        }
    }
}
