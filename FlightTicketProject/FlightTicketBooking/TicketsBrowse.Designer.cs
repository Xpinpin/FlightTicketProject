namespace FlightTicketBooking
{
    partial class TicketsBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsBrowse));
            this.grpTickets = new System.Windows.Forms.GroupBox();
            this.cmbTickets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.lblPlaces = new System.Windows.Forms.Label();
            this.lblAirlines = new System.Windows.Forms.Label();
            this.lblAirports = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.chkMeal = new System.Windows.Forms.CheckBox();
            this.grpTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTickets
            // 
            this.grpTickets.BackColor = System.Drawing.Color.Transparent;
            this.grpTickets.Controls.Add(this.cmbTickets);
            this.grpTickets.Controls.Add(this.label2);
            this.grpTickets.Location = new System.Drawing.Point(248, 61);
            this.grpTickets.Name = "grpTickets";
            this.grpTickets.Size = new System.Drawing.Size(358, 66);
            this.grpTickets.TabIndex = 4;
            this.grpTickets.TabStop = false;
            this.grpTickets.Text = "Tickets";
            // 
            // cmbTickets
            // 
            this.cmbTickets.FormattingEnabled = true;
            this.cmbTickets.Location = new System.Drawing.Point(83, 24);
            this.cmbTickets.Name = "cmbTickets";
            this.cmbTickets.Size = new System.Drawing.Size(254, 24);
            this.cmbTickets.TabIndex = 1;
            this.cmbTickets.SelectionChangeCommitted += new System.EventHandler(this.CmbTickets_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Flight:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "TICKETS BROWSE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(61, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Places:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(548, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Airlines Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(54, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Airports:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(72, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(570, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seat Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(32, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(554, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantity Left:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Location = new System.Drawing.Point(647, 172);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 17);
            this.lblQuantity.TabIndex = 23;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(133, 233);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 17);
            this.lblDescription.TabIndex = 22;
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.BackColor = System.Drawing.Color.Transparent;
            this.lblSeat.Location = new System.Drawing.Point(647, 207);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(0, 17);
            this.lblSeat.TabIndex = 21;
            // 
            // lblPlaces
            // 
            this.lblPlaces.AutoSize = true;
            this.lblPlaces.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaces.Location = new System.Drawing.Point(133, 199);
            this.lblPlaces.Name = "lblPlaces";
            this.lblPlaces.Size = new System.Drawing.Size(0, 17);
            this.lblPlaces.TabIndex = 20;
            // 
            // lblAirlines
            // 
            this.lblAirlines.AutoSize = true;
            this.lblAirlines.BackColor = System.Drawing.Color.Transparent;
            this.lblAirlines.Location = new System.Drawing.Point(647, 143);
            this.lblAirlines.Name = "lblAirlines";
            this.lblAirlines.Size = new System.Drawing.Size(0, 17);
            this.lblAirlines.TabIndex = 19;
            // 
            // lblAirports
            // 
            this.lblAirports.AutoSize = true;
            this.lblAirports.BackColor = System.Drawing.Color.Transparent;
            this.lblAirports.Location = new System.Drawing.Point(133, 169);
            this.lblAirports.Name = "lblAirports";
            this.lblAirports.Size = new System.Drawing.Size(0, 17);
            this.lblAirports.TabIndex = 18;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(133, 142);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 17);
            this.lblTime.TabIndex = 17;
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(35, 301);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowHeadersWidth = 51;
            this.dgvInfo.RowTemplate.Height = 24;
            this.dgvInfo.Size = new System.Drawing.Size(727, 150);
            this.dgvInfo.TabIndex = 24;
            this.dgvInfo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvInfo_RowHeaderMouseClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(16, 265);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 17);
            this.label17.TabIndex = 25;
            this.label17.Text = "Meal Included:";
            // 
            // chkMeal
            // 
            this.chkMeal.AutoSize = true;
            this.chkMeal.BackColor = System.Drawing.Color.Transparent;
            this.chkMeal.Enabled = false;
            this.chkMeal.Location = new System.Drawing.Point(136, 266);
            this.chkMeal.Name = "chkMeal";
            this.chkMeal.Size = new System.Drawing.Size(18, 17);
            this.chkMeal.TabIndex = 26;
            this.chkMeal.UseVisualStyleBackColor = false;
            // 
            // TicketsBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 483);
            this.Controls.Add(this.chkMeal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.lblPlaces);
            this.Controls.Add(this.lblAirlines);
            this.Controls.Add(this.lblAirports);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpTickets);
            this.Controls.Add(this.label1);
            this.Name = "TicketsBrowse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketsBrowse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TicketsBrowse_FormClosed);
            this.Load += new System.EventHandler(this.TicketsBrowse_Load);
            this.grpTickets.ResumeLayout(false);
            this.grpTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTickets;
        private System.Windows.Forms.ComboBox cmbTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label lblPlaces;
        private System.Windows.Forms.Label lblAirlines;
        private System.Windows.Forms.Label lblAirports;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkMeal;
    }
}