namespace FlightTicketBooking
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.browseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1181, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.printToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.accountToolStripMenuItem.Text = "&Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.AccountToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Sa&ve As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logOutToolStripMenuItem.Text = "&Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.ticketsToolStripMenuItem,
            this.boookingsToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.maintenanceToolStripMenuItem.Text = "&Maintenance";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.customersToolStripMenuItem.Tag = "Customers";
            this.customersToolStripMenuItem.Text = "&Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.ticketsToolStripMenuItem.Tag = "Tickets";
            this.ticketsToolStripMenuItem.Text = "&Tickets";
            this.ticketsToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // boookingsToolStripMenuItem
            // 
            this.boookingsToolStripMenuItem.Name = "boookingsToolStripMenuItem";
            this.boookingsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.boookingsToolStripMenuItem.Tag = "Bookings";
            this.boookingsToolStripMenuItem.Text = "&Bookings";
            this.boookingsToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem1,
            this.ticketsToolStripMenuItem1});
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.browseToolStripMenuItem.Text = "&Browse";
            // 
            // customersToolStripMenuItem1
            // 
            this.customersToolStripMenuItem1.Name = "customersToolStripMenuItem1";
            this.customersToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.customersToolStripMenuItem1.Tag = "CustomersBrowse";
            this.customersToolStripMenuItem1.Text = "&Customers";
            this.customersToolStripMenuItem1.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // ticketsToolStripMenuItem1
            // 
            this.ticketsToolStripMenuItem1.Name = "ticketsToolStripMenuItem1";
            this.ticketsToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.ticketsToolStripMenuItem1.Tag = "TicketsBrowse";
            this.ticketsToolStripMenuItem1.Text = "&Tickets";
            this.ticketsToolStripMenuItem1.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.definitionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // definitionToolStripMenuItem
            // 
            this.definitionToolStripMenuItem.Name = "definitionToolStripMenuItem";
            this.definitionToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.definitionToolStripMenuItem.Text = "Definition";
            this.definitionToolStripMenuItem.Click += new System.EventHandler(this.DefinitionToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7});
            this.statusStrip1.Location = new System.Drawing.Point(0, 658);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1181, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton6,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1181, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Tag = "Customers";
            this.toolStripButton1.Text = "Customers Maintenance";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStrip_ShowNewForm);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Tag = "Tickets";
            this.toolStripButton2.Text = "Tickets Maintenance";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStrip_ShowNewForm);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Tag = "Bookings";
            this.toolStripButton3.Text = "Bookings Maintenance";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStrip_ShowNewForm);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Enabled = false;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "|";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Tag = "CustomersBrowse";
            this.toolStripButton4.Text = "Browse Customers";
            this.toolStripButton4.Click += new System.EventHandler(this.ToolStrip_ShowNewForm);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Tag = "TicketsBrowse";
            this.toolStripButton5.Text = "Browse Tickets";
            this.toolStripButton5.Click += new System.EventHandler(this.ToolStrip_ShowNewForm);
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(0, 20);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1181, 684);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Ticket Booking";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem definitionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
    }
}

