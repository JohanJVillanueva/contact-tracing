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
            this.components = new System.ComponentModel.Container();
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
            this.lblTime = new System.Windows.Forms.Label();
            this.dtP1 = new System.Windows.Forms.DateTimePicker();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtAMPM = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFemale = new System.Windows.Forms.RadioButton();
            this.txtMale = new System.Windows.Forms.RadioButton();
            this.txtSex = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbVaB = new System.Windows.Forms.RadioButton();
            this.rbOneVax = new System.Windows.Forms.RadioButton();
            this.rbNoVax = new System.Windows.Forms.RadioButton();
            this.lblVaxxed = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.clbox = new System.Windows.Forms.CheckedListBox();
            this.lblSymptoms = new System.Windows.Forms.Label();
            this.lblSymptoms2 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.pctForm1QRCover = new System.Windows.Forms.PictureBox();
            this.btnQRGenerate = new System.Windows.Forms.Button();
            this.lblGenerate = new System.Windows.Forms.Label();
            this.lblScan = new System.Windows.Forms.Label();
            this.pctQR = new System.Windows.Forms.PictureBox();
            this.pctScanQR = new System.Windows.Forms.PictureBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctBg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctForm1QRCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctScanQR)).BeginInit();
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
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.Brown;
            this.lblTime.Location = new System.Drawing.Point(32, 660);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(83, 23);
            this.lblTime.TabIndex = 22;
            this.lblTime.Text = "Time-in:";
            // 
            // dtP1
            // 
            this.dtP1.Location = new System.Drawing.Point(35, 686);
            this.dtP1.Name = "dtP1";
            this.dtP1.Size = new System.Drawing.Size(223, 23);
            this.dtP1.TabIndex = 23;
            // 
            // txtHours
            // 
            this.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHours.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHours.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHours.Location = new System.Drawing.Point(35, 715);
            this.txtHours.Name = "txtHours";
            this.txtHours.PlaceholderText = "09";
            this.txtHours.Size = new System.Drawing.Size(45, 40);
            this.txtHours.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poetsen One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(80, 715);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMin
            // 
            this.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMin.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMin.Location = new System.Drawing.Point(97, 715);
            this.txtMin.Name = "txtMin";
            this.txtMin.PlaceholderText = "41";
            this.txtMin.Size = new System.Drawing.Size(45, 40);
            this.txtMin.TabIndex = 26;
            // 
            // txtAMPM
            // 
            this.txtAMPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAMPM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAMPM.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAMPM.Location = new System.Drawing.Point(148, 715);
            this.txtAMPM.Name = "txtAMPM";
            this.txtAMPM.PlaceholderText = "AM";
            this.txtAMPM.Size = new System.Drawing.Size(45, 40);
            this.txtAMPM.TabIndex = 27;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSubmit.Font = new System.Drawing.Font("Poetsen One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(964, 842);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 70);
            this.btnSubmit.TabIndex = 36;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTemp.ForeColor = System.Drawing.Color.Brown;
            this.lblTemp.Location = new System.Drawing.Point(262, 660);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(131, 23);
            this.lblTemp.TabIndex = 29;
            this.lblTemp.Text = "Temperature:";
            // 
            // txtTemp
            // 
            this.txtTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTemp.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTemp.Location = new System.Drawing.Point(264, 686);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.PlaceholderText = "36.4";
            this.txtTemp.Size = new System.Drawing.Size(90, 40);
            this.txtTemp.TabIndex = 28;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Poetsen One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblC.ForeColor = System.Drawing.Color.Black;
            this.lblC.Location = new System.Drawing.Point(359, 687);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(33, 35);
            this.lblC.TabIndex = 31;
            this.lblC.Text = "C";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFemale);
            this.groupBox1.Controls.Add(this.txtMale);
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Location = new System.Drawing.Point(399, 660);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 90);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // txtFemale
            // 
            this.txtFemale.AutoSize = true;
            this.txtFemale.Location = new System.Drawing.Point(36, 47);
            this.txtFemale.Name = "txtFemale";
            this.txtFemale.Size = new System.Drawing.Size(63, 19);
            this.txtFemale.TabIndex = 30;
            this.txtFemale.Text = "Female";
            this.txtFemale.UseVisualStyleBackColor = true;
            // 
            // txtMale
            // 
            this.txtMale.AutoSize = true;
            this.txtMale.Checked = true;
            this.txtMale.Location = new System.Drawing.Point(36, 27);
            this.txtMale.Name = "txtMale";
            this.txtMale.Size = new System.Drawing.Size(51, 19);
            this.txtMale.TabIndex = 29;
            this.txtMale.TabStop = true;
            this.txtMale.Text = "Male";
            this.txtMale.UseVisualStyleBackColor = true;
            this.txtMale.CheckedChanged += new System.EventHandler(this.txtMale_CheckedChanged);
            // 
            // txtSex
            // 
            this.txtSex.AutoSize = true;
            this.txtSex.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSex.ForeColor = System.Drawing.Color.Brown;
            this.txtSex.Location = new System.Drawing.Point(49, 0);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(46, 23);
            this.txtSex.TabIndex = 30;
            this.txtSex.Text = "Sex:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbVaB);
            this.groupBox2.Controls.Add(this.rbOneVax);
            this.groupBox2.Controls.Add(this.rbNoVax);
            this.groupBox2.Controls.Add(this.lblVaxxed);
            this.groupBox2.Location = new System.Drawing.Point(399, 756);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 90);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // rbVaB
            // 
            this.rbVaB.AutoSize = true;
            this.rbVaB.Location = new System.Drawing.Point(6, 65);
            this.rbVaB.Name = "rbVaB";
            this.rbVaB.Size = new System.Drawing.Size(131, 19);
            this.rbVaB.TabIndex = 34;
            this.rbVaB.Text = "Vaxxed and Boosted";
            this.rbVaB.UseVisualStyleBackColor = true;
            // 
            // rbOneVax
            // 
            this.rbOneVax.AutoSize = true;
            this.rbOneVax.Location = new System.Drawing.Point(6, 46);
            this.rbOneVax.Name = "rbOneVax";
            this.rbOneVax.Size = new System.Drawing.Size(62, 19);
            this.rbOneVax.TabIndex = 33;
            this.rbOneVax.Text = "Vaxxed";
            this.rbOneVax.UseVisualStyleBackColor = true;
            // 
            // rbNoVax
            // 
            this.rbNoVax.AutoSize = true;
            this.rbNoVax.Checked = true;
            this.rbNoVax.Location = new System.Drawing.Point(6, 27);
            this.rbNoVax.Name = "rbNoVax";
            this.rbNoVax.Size = new System.Drawing.Size(84, 19);
            this.rbNoVax.TabIndex = 32;
            this.rbNoVax.TabStop = true;
            this.rbNoVax.Text = "No Vaccine";
            this.rbNoVax.UseVisualStyleBackColor = true;
            // 
            // lblVaxxed
            // 
            this.lblVaxxed.AutoSize = true;
            this.lblVaxxed.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVaxxed.ForeColor = System.Drawing.Color.Brown;
            this.lblVaxxed.Location = new System.Drawing.Point(12, 1);
            this.lblVaxxed.Name = "lblVaxxed";
            this.lblVaxxed.Size = new System.Drawing.Size(121, 23);
            this.lblVaxxed.TabIndex = 30;
            this.lblVaxxed.Text = "Vaccinated?";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.ForeColor = System.Drawing.Color.Brown;
            this.lblAge.Location = new System.Drawing.Point(262, 732);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(49, 23);
            this.lblAge.TabIndex = 35;
            this.lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAge.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAge.Location = new System.Drawing.Point(264, 758);
            this.txtAge.Name = "txtAge";
            this.txtAge.PlaceholderText = "18";
            this.txtAge.Size = new System.Drawing.Size(90, 40);
            this.txtAge.TabIndex = 31;
            // 
            // clbox
            // 
            this.clbox.FormattingEnabled = true;
            this.clbox.Items.AddRange(new object[] {
            "Cough",
            "Fever",
            "Runny Nose",
            "Loss of smell or taste",
            "Other Symptoms"});
            this.clbox.Location = new System.Drawing.Point(53, 842);
            this.clbox.Name = "clbox";
            this.clbox.Size = new System.Drawing.Size(266, 94);
            this.clbox.TabIndex = 35;
            this.clbox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblSymptoms
            // 
            this.lblSymptoms.AutoSize = true;
            this.lblSymptoms.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSymptoms.ForeColor = System.Drawing.Color.Brown;
            this.lblSymptoms.Location = new System.Drawing.Point(53, 799);
            this.lblSymptoms.Name = "lblSymptoms";
            this.lblSymptoms.Size = new System.Drawing.Size(268, 23);
            this.lblSymptoms.TabIndex = 37;
            this.lblSymptoms.Text = "Do you have any symptoms?";
            // 
            // lblSymptoms2
            // 
            this.lblSymptoms2.AutoSize = true;
            this.lblSymptoms2.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSymptoms2.ForeColor = System.Drawing.Color.Brown;
            this.lblSymptoms2.Location = new System.Drawing.Point(68, 819);
            this.lblSymptoms2.Name = "lblSymptoms2";
            this.lblSymptoms2.Size = new System.Drawing.Size(229, 23);
            this.lblSymptoms2.TabIndex = 38;
            this.lblSymptoms2.Text = "Leave unchecked if none";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(440, 130);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(113, 23);
            this.btnAdmin.TabIndex = 39;
            this.btnAdmin.Text = "Admin Submit";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(334, 130);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.PlaceholderText = "Password";
            this.txtPw.Size = new System.Drawing.Size(100, 23);
            this.txtPw.TabIndex = 40;
            // 
            // pctForm1QRCover
            // 
            this.pctForm1QRCover.Image = ((System.Drawing.Image)(resources.GetObject("pctForm1QRCover.Image")));
            this.pctForm1QRCover.Location = new System.Drawing.Point(609, 12);
            this.pctForm1QRCover.Name = "pctForm1QRCover";
            this.pctForm1QRCover.Size = new System.Drawing.Size(614, 929);
            this.pctForm1QRCover.TabIndex = 41;
            this.pctForm1QRCover.TabStop = false;
            // 
            // btnQRGenerate
            // 
            this.btnQRGenerate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnQRGenerate.Font = new System.Drawing.Font("Poetsen One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQRGenerate.ForeColor = System.Drawing.Color.White;
            this.btnQRGenerate.Location = new System.Drawing.Point(964, 783);
            this.btnQRGenerate.Name = "btnQRGenerate";
            this.btnQRGenerate.Size = new System.Drawing.Size(154, 53);
            this.btnQRGenerate.TabIndex = 42;
            this.btnQRGenerate.Text = "Generate";
            this.btnQRGenerate.UseVisualStyleBackColor = false;
            this.btnQRGenerate.Click += new System.EventHandler(this.btnQRGenerate_Click);
            // 
            // lblGenerate
            // 
            this.lblGenerate.AutoSize = true;
            this.lblGenerate.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenerate.ForeColor = System.Drawing.Color.Brown;
            this.lblGenerate.Location = new System.Drawing.Point(622, 615);
            this.lblGenerate.Name = "lblGenerate";
            this.lblGenerate.Size = new System.Drawing.Size(420, 23);
            this.lblGenerate.TabIndex = 43;
            this.lblGenerate.Text = "Generate QR Code and/or Submit Information:\r\n";
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScan.ForeColor = System.Drawing.Color.Brown;
            this.lblScan.Location = new System.Drawing.Point(622, 46);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(136, 23);
            this.lblScan.TabIndex = 44;
            this.lblScan.Text = "Scan QR Code:";
            // 
            // pctQR
            // 
            this.pctQR.Location = new System.Drawing.Point(649, 655);
            this.pctQR.Name = "pctQR";
            this.pctQR.Size = new System.Drawing.Size(272, 257);
            this.pctQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctQR.TabIndex = 45;
            this.pctQR.TabStop = false;
            // 
            // pctScanQR
            // 
            this.pctScanQR.Location = new System.Drawing.Point(722, 111);
            this.pctScanQR.Name = "pctScanQR";
            this.pctScanQR.Size = new System.Drawing.Size(352, 347);
            this.pctScanQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctScanQR.TabIndex = 46;
            this.pctScanQR.TabStop = false;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnScan.Font = new System.Drawing.Font("Poetsen One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(773, 464);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(269, 53);
            this.btnScan.TabIndex = 47;
            this.btnScan.Text = "Scan and Submit";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(722, 82);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(121, 23);
            this.cmbCamera.TabIndex = 48;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1201, 952);
            this.Controls.Add(this.cmbCamera);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.pctScanQR);
            this.Controls.Add(this.pctQR);
            this.Controls.Add(this.lblScan);
            this.Controls.Add(this.lblGenerate);
            this.Controls.Add(this.btnQRGenerate);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblSymptoms2);
            this.Controls.Add(this.lblSymptoms);
            this.Controls.Add(this.clbox);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAMPM);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.dtP1);
            this.Controls.Add(this.lblTime);
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
            this.Controls.Add(this.pctForm1QRCover);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LilJohn Contact Tracing Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctForm1QRCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctScanQR)).EndInit();
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
        private Label lblTime;
        private DateTimePicker dtP1;
        private TextBox txtHours;
        private Label label1;
        private TextBox txtMin;
        private TextBox txtAMPM;
        private Button btnSubmit;
        private Label lblTemp;
        private TextBox txtTemp;
        private Label lblC;
        private GroupBox groupBox1;
        private RadioButton txtFemale;
        private RadioButton txtMale;
        private Label txtSex;
        private GroupBox groupBox2;
        private RadioButton rbVaB;
        private RadioButton rbOneVax;
        private RadioButton rbNoVax;
        private Label lblVaxxed;
        private Label lblAge;
        private TextBox txtAge;
        private CheckedListBox clbox;
        private Label lblSymptoms;
        private Label lblSymptoms2;
        private Button btnAdmin;
        private TextBox txtPw;
        private PictureBox pctForm1QRCover;
        private Button btnQRGenerate;
        private Label lblGenerate;
        private Label lblScan;
        private PictureBox pctQR;
        private PictureBox pctScanQR;
        private Button btnScan;
        private ComboBox cmbCamera;
        private System.Windows.Forms.Timer timer1;
    }
}