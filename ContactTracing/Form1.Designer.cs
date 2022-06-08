namespace ContactTracing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pctBg = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblMI = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.ltlStN = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblPhoneN = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtStNo = new System.Windows.Forms.TextBox();
            this.txtSTName = new System.Windows.Forms.TextBox();
            this.txtCityProv = new System.Windows.Forms.TextBox();
            this.txtPhoneN = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBg)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBg
            // 
            this.pctBg.Image = ((System.Drawing.Image)(resources.GetObject("pctBg.Image")));
            this.pctBg.Location = new System.Drawing.Point(12, 12);
            this.pctBg.Name = "pctBg";
            this.pctBg.Size = new System.Drawing.Size(566, 788);
            this.pctBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBg.TabIndex = 0;
            this.pctBg.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Brown;
            this.lblName.Location = new System.Drawing.Point(32, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContact.ForeColor = System.Drawing.Color.Brown;
            this.lblContact.Location = new System.Drawing.Point(32, 520);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(120, 23);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact No.:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.Color.Brown;
            this.lblAddress.Location = new System.Drawing.Point(32, 284);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(88, 23);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblFName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFName.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFName.Location = new System.Drawing.Point(40, 170);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(112, 25);
            this.lblFName.TabIndex = 4;
            this.lblFName.Text = "First Name:";
            this.lblFName.Click += new System.EventHandler(this.lblFName_Click);
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = true;
            this.lblMI.BackColor = System.Drawing.Color.DarkCyan;
            this.lblMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMI.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMI.Location = new System.Drawing.Point(257, 170);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(40, 25);
            this.lblMI.TabIndex = 5;
            this.lblMI.Text = "M.I";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.DarkCyan;
            this.lblLName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLName.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLName.Location = new System.Drawing.Point(325, 170);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(109, 25);
            this.lblLName.TabIndex = 6;
            this.lblLName.Text = "Last Name:";
            // 
            // ltlStN
            // 
            this.ltlStN.AutoSize = true;
            this.ltlStN.BackColor = System.Drawing.Color.DarkCyan;
            this.ltlStN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ltlStN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ltlStN.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltlStN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ltlStN.Location = new System.Drawing.Point(40, 324);
            this.ltlStN.Name = "ltlStN";
            this.ltlStN.Size = new System.Drawing.Size(68, 25);
            this.ltlStN.TabIndex = 7;
            this.ltlStN.Text = "St. No.";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.Color.DarkCyan;
            this.lblStreet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStreet.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStreet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStreet.Location = new System.Drawing.Point(158, 324);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(176, 25);
            this.lblStreet.TabIndex = 8;
            this.lblStreet.Text = "Street/Town Name";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.BackColor = System.Drawing.Color.DarkCyan;
            this.lblProvince.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProvince.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProvince.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProvince.Location = new System.Drawing.Point(40, 400);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(134, 25);
            this.lblProvince.TabIndex = 9;
            this.lblProvince.Text = "City/Province";
            // 
            // lblPhoneN
            // 
            this.lblPhoneN.AutoSize = true;
            this.lblPhoneN.BackColor = System.Drawing.Color.DarkCyan;
            this.lblPhoneN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhoneN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPhoneN.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhoneN.Location = new System.Drawing.Point(40, 555);
            this.lblPhoneN.Name = "lblPhoneN";
            this.lblPhoneN.Size = new System.Drawing.Size(143, 25);
            this.lblPhoneN.TabIndex = 10;
            this.lblPhoneN.Text = "Phone Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.DarkCyan;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(262, 555);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 25);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-mail";
            // 
            // txtFName
            // 
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFName.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFName.Location = new System.Drawing.Point(40, 198);
            this.txtFName.Name = "txtFName";
            this.txtFName.PlaceholderText = "Juan";
            this.txtFName.Size = new System.Drawing.Size(211, 40);
            this.txtFName.TabIndex = 12;
            this.txtFName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMI
            // 
            this.txtMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMI.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMI.Location = new System.Drawing.Point(257, 198);
            this.txtMI.Name = "txtMI";
            this.txtMI.PlaceholderText = "S.";
            this.txtMI.Size = new System.Drawing.Size(62, 40);
            this.txtMI.TabIndex = 13;
            // 
            // txtLName
            // 
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLName.Location = new System.Drawing.Point(325, 198);
            this.txtLName.Name = "txtLName";
            this.txtLName.PlaceholderText = "Dela Cruz";
            this.txtLName.Size = new System.Drawing.Size(228, 40);
            this.txtLName.TabIndex = 14;
            // 
            // txtStNo
            // 
            this.txtStNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStNo.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStNo.Location = new System.Drawing.Point(40, 352);
            this.txtStNo.Name = "txtStNo";
            this.txtStNo.PlaceholderText = "123";
            this.txtStNo.Size = new System.Drawing.Size(112, 40);
            this.txtStNo.TabIndex = 15;
            // 
            // txtSTName
            // 
            this.txtSTName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSTName.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSTName.Location = new System.Drawing.Point(158, 352);
            this.txtSTName.Name = "txtSTName";
            this.txtSTName.PlaceholderText = "Sampaguita St., Dalahican";
            this.txtSTName.Size = new System.Drawing.Size(395, 40);
            this.txtSTName.TabIndex = 16;
            // 
            // txtCityProv
            // 
            this.txtCityProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCityProv.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCityProv.Location = new System.Drawing.Point(40, 428);
            this.txtCityProv.Name = "txtCityProv";
            this.txtCityProv.PlaceholderText = "Cavite City, Cavite";
            this.txtCityProv.Size = new System.Drawing.Size(426, 40);
            this.txtCityProv.TabIndex = 17;
            // 
            // txtPhoneN
            // 
            this.txtPhoneN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneN.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneN.Location = new System.Drawing.Point(40, 583);
            this.txtPhoneN.Name = "txtPhoneN";
            this.txtPhoneN.PlaceholderText = "092123456789";
            this.txtPhoneN.Size = new System.Drawing.Size(218, 40);
            this.txtPhoneN.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(262, 583);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "example@email.com";
            this.txtEmail.Size = new System.Drawing.Size(291, 40);
            this.txtEmail.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(592, 780);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneN);
            this.Controls.Add(this.txtCityProv);
            this.Controls.Add(this.txtSTName);
            this.Controls.Add(this.txtStNo);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneN);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.ltlStN);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblMI);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pctBg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LilJohn Contact Tracing Form";
            ((System.ComponentModel.ISupportInitialize)(this.pctBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctBg;
        private Label lblName;
        private Label lblContact;
        private Label lblAddress;
        private Label lblFName;
        private Label lblMI;
        private Label lblLName;
        private Label ltlStN;
        private Label lblStreet;
        private Label lblProvince;
        private Label lblPhoneN;
        private Label lblEmail;
        private TextBox txtFName;
        private TextBox txtMI;
        private TextBox txtLName;
        private TextBox txtStNo;
        private TextBox txtSTName;
        private TextBox txtCityProv;
        private TextBox txtPhoneN;
        private TextBox txtEmail;
    }
}