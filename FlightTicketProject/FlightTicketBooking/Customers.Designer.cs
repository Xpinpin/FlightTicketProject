namespace FlightTicketBooking
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.label1 = new System.Windows.Forms.Label();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStreetNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHomeNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCellNum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpName.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.grpContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMERS";
            // 
            // grpName
            // 
            this.grpName.BackColor = System.Drawing.Color.Transparent;
            this.grpName.Controls.Add(this.txtLastName);
            this.grpName.Controls.Add(this.label4);
            this.grpName.Controls.Add(this.txtMiddleName);
            this.grpName.Controls.Add(this.label3);
            this.grpName.Controls.Add(this.txtFirstName);
            this.grpName.Controls.Add(this.label2);
            this.grpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpName.Location = new System.Drawing.Point(46, 107);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(349, 134);
            this.grpName.TabIndex = 1;
            this.grpName.TabStop = false;
            this.grpName.Text = "Full Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(116, 88);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(207, 22);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.Tag = "Last Name";
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(116, 60);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(207, 22);
            this.txtMiddleName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(117, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(207, 22);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Tag = "First Name";
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name: ";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(344, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(144, 22);
            this.txtID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID: ";
            // 
            // grpAddress
            // 
            this.grpAddress.BackColor = System.Drawing.Color.Transparent;
            this.grpAddress.Controls.Add(this.txtPostalCode);
            this.grpAddress.Controls.Add(this.label9);
            this.grpAddress.Controls.Add(this.txtCountry);
            this.grpAddress.Controls.Add(this.label10);
            this.grpAddress.Controls.Add(this.txtProvince);
            this.grpAddress.Controls.Add(this.label11);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this.label6);
            this.grpAddress.Controls.Add(this.txtStreetName);
            this.grpAddress.Controls.Add(this.label7);
            this.grpAddress.Controls.Add(this.txtStreetNum);
            this.grpAddress.Controls.Add(this.label8);
            this.grpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddress.Location = new System.Drawing.Point(427, 107);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(367, 231);
            this.grpAddress.TabIndex = 6;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(146, 172);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(192, 22);
            this.txtPostalCode.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Postal Code:";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(146, 144);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(192, 22);
            this.txtCountry.TabIndex = 9;
            this.txtCountry.Tag = "Country";
            this.txtCountry.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(81, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Country:";
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.Location = new System.Drawing.Point(147, 116);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(192, 22);
            this.txtProvince.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Province: ";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(147, 88);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(192, 22);
            this.txtCity.TabIndex = 5;
            this.txtCity.Tag = "City";
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "City:";
            // 
            // txtStreetName
            // 
            this.txtStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetName.Location = new System.Drawing.Point(147, 60);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(192, 22);
            this.txtStreetName.TabIndex = 3;
            this.txtStreetName.Tag = "Street Name";
            this.txtStreetName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Street Name:";
            // 
            // txtStreetNum
            // 
            this.txtStreetNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetNum.Location = new System.Drawing.Point(148, 32);
            this.txtStreetNum.Name = "txtStreetNum";
            this.txtStreetNum.Size = new System.Drawing.Size(192, 22);
            this.txtStreetNum.TabIndex = 1;
            this.txtStreetNum.Tag = "Street Number";
            this.txtStreetNum.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Street Number:";
            // 
            // grpContact
            // 
            this.grpContact.BackColor = System.Drawing.Color.Transparent;
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.label12);
            this.grpContact.Controls.Add(this.txtHomeNum);
            this.grpContact.Controls.Add(this.label13);
            this.grpContact.Controls.Add(this.txtCellNum);
            this.grpContact.Controls.Add(this.label14);
            this.grpContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContact.Location = new System.Drawing.Point(46, 270);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(349, 134);
            this.grpContact.TabIndex = 6;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(116, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 22);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Tag = "Email";
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(70, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Email:";
            // 
            // txtHomeNum
            // 
            this.txtHomeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeNum.Location = new System.Drawing.Point(116, 60);
            this.txtHomeNum.Name = "txtHomeNum";
            this.txtHomeNum.Size = new System.Drawing.Size(207, 22);
            this.txtHomeNum.TabIndex = 3;
            this.txtHomeNum.Tag = "Home Number";
            this.txtHomeNum.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Home Number:";
            // 
            // txtCellNum
            // 
            this.txtCellNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellNum.Location = new System.Drawing.Point(117, 32);
            this.txtCellNum.Name = "txtCellNum";
            this.txtCellNum.Size = new System.Drawing.Size(207, 22);
            this.txtCellNum.TabIndex = 1;
            this.txtCellNum.Tag = "Cell Number";
            this.txtCellNum.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Cell Number:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(418, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(515, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(608, 374);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(701, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(311, 426);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(39, 23);
            this.btnFirst.TabIndex = 12;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.NavigationHandler);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(356, 426);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(39, 23);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.NavigationHandler);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(401, 426);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(39, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NavigationHandler);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(444, 426);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(39, 23);
            this.btnLast.TabIndex = 15;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.NavigationHandler);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.label1);
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customers_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customers_FormClosed);
            this.Load += new System.EventHandler(this.Customers_Load);
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStreetNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHomeNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCellNum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}