namespace UI2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPlayers = new System.Windows.Forms.Panel();
            this.pnlTeams = new System.Windows.Forms.Panel();
            this.pnlMatchces = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.pnlTables = new System.Windows.Forms.Panel();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSub1 = new System.Windows.Forms.Button();
            this.btnSub2 = new System.Windows.Forms.Button();
            this.btnSub3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.pnlPlayers.SuspendLayout();
            this.pnlTeams.SuspendLayout();
            this.pnlMatchces.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlTables.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Premier League Mangement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sidebar
            // 
            this.sidebar.AutoScroll = true;
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.pnlPlayers);
            this.sidebar.Controls.Add(this.pnlTeams);
            this.sidebar.Controls.Add(this.pnlMatchces);
            this.sidebar.Controls.Add(this.pnlTables);
            this.sidebar.Controls.Add(this.pnlSettings);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 50);
            this.sidebar.Margin = new System.Windows.Forms.Padding(5);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(376, 640);
            this.sidebar.TabIndex = 1;
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.BackColor = System.Drawing.Color.White;
            this.pnlPlayers.Controls.Add(this.button2);
            this.pnlPlayers.Location = new System.Drawing.Point(3, 88);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(277, 55);
            this.pnlPlayers.TabIndex = 3;
            // 
            // pnlTeams
            // 
            this.pnlTeams.BackColor = System.Drawing.Color.White;
            this.pnlTeams.Controls.Add(this.button1);
            this.pnlTeams.Location = new System.Drawing.Point(3, 149);
            this.pnlTeams.Name = "pnlTeams";
            this.pnlTeams.Size = new System.Drawing.Size(277, 55);
            this.pnlTeams.TabIndex = 4;
            // 
            // pnlMatchces
            // 
            this.pnlMatchces.BackColor = System.Drawing.Color.White;
            this.pnlMatchces.Controls.Add(this.button3);
            this.pnlMatchces.Location = new System.Drawing.Point(3, 210);
            this.pnlMatchces.Name = "pnlMatchces";
            this.pnlMatchces.Size = new System.Drawing.Size(277, 55);
            this.pnlMatchces.TabIndex = 5;
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.White;
            this.pnlSettings.Controls.Add(this.button4);
            this.pnlSettings.Location = new System.Drawing.Point(3, 332);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(277, 55);
            this.pnlSettings.TabIndex = 4;
            // 
            // pnlTables
            // 
            this.pnlTables.BackColor = System.Drawing.Color.White;
            this.pnlTables.Controls.Add(this.button5);
            this.pnlTables.Location = new System.Drawing.Point(3, 271);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(277, 55);
            this.pnlTables.TabIndex = 4;
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.White;
            this.menuContainer.Controls.Add(this.panel7);
            this.menuContainer.Controls.Add(this.panel9);
            this.menuContainer.Controls.Add(this.panel10);
            this.menuContainer.Controls.Add(this.panel8);
            this.menuContainer.Location = new System.Drawing.Point(0, 30);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(277, 55);
            this.menuContainer.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.btnMenu);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(277, 55);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSub3);
            this.panel8.Location = new System.Drawing.Point(0, 165);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(277, 55);
            this.panel8.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnSub1);
            this.panel9.Location = new System.Drawing.Point(0, 55);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(277, 55);
            this.panel9.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnSub2);
            this.panel10.Location = new System.Drawing.Point(0, 110);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(277, 55);
            this.panel10.TabIndex = 8;
            // 
            // menuTransition
            // 
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(-13, -26);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(313, 108);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "                       Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSub1
            // 
            this.btnSub1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub1.ForeColor = System.Drawing.Color.Black;
            this.btnSub1.Image = ((System.Drawing.Image)(resources.GetObject("btnSub1.Image")));
            this.btnSub1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSub1.Location = new System.Drawing.Point(0, -26);
            this.btnSub1.Name = "btnSub1";
            this.btnSub1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSub1.Size = new System.Drawing.Size(293, 108);
            this.btnSub1.TabIndex = 0;
            this.btnSub1.Text = "                   Submenu1";
            this.btnSub1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSub1.UseVisualStyleBackColor = true;
            this.btnSub1.Click += new System.EventHandler(this.btnSub1_Click);
            // 
            // btnSub2
            // 
            this.btnSub2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub2.ForeColor = System.Drawing.Color.Black;
            this.btnSub2.Image = ((System.Drawing.Image)(resources.GetObject("btnSub2.Image")));
            this.btnSub2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSub2.Location = new System.Drawing.Point(0, -26);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSub2.Size = new System.Drawing.Size(293, 108);
            this.btnSub2.TabIndex = 0;
            this.btnSub2.Text = "                   Submenu2";
            this.btnSub2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSub2.UseVisualStyleBackColor = true;
            this.btnSub2.Click += new System.EventHandler(this.btnSub2_Click);
            // 
            // btnSub3
            // 
            this.btnSub3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub3.ForeColor = System.Drawing.Color.Black;
            this.btnSub3.Image = ((System.Drawing.Image)(resources.GetObject("btnSub3.Image")));
            this.btnSub3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSub3.Location = new System.Drawing.Point(0, -26);
            this.btnSub3.Name = "btnSub3";
            this.btnSub3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSub3.Size = new System.Drawing.Size(293, 108);
            this.btnSub3.TabIndex = 0;
            this.btnSub3.Text = "                   Submenu3";
            this.btnSub3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSub3.UseVisualStyleBackColor = true;
            this.btnSub3.Click += new System.EventHandler(this.btnSub3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-13, -26);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(306, 108);
            this.button2.TabIndex = 0;
            this.button2.Text = "                      Players";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-13, -26);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(306, 108);
            this.button1.TabIndex = 0;
            this.button1.Text = "                      Teams";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-13, -26);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(306, 108);
            this.button3.TabIndex = 0;
            this.button3.Text = "                      Matches";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-13, -26);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(306, 108);
            this.button5.TabIndex = 0;
            this.button5.Text = "                      Tables";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-13, -26);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(306, 108);
            this.button4.TabIndex = 0;
            this.button4.Text = "                      Setting";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnHam
            // 
            this.btnHam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnHam.Image = global::UI2.Properties.Resources.icons8_menu_48;
            this.btnHam.Location = new System.Drawing.Point(12, 0);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(53, 50);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHam.TabIndex = 0;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 690);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panel1.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.pnlPlayers.ResumeLayout(false);
            this.pnlTeams.ResumeLayout(false);
            this.pnlMatchces.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlTables.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnlPlayers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlTeams;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMatchces;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlTables;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSub3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSub1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnSub2;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}