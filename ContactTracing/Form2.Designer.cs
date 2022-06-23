namespace ContactTracing
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dtP2 = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfCT = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblNameOfCT = new System.Windows.Forms.Label();
            this.txtSbName = new System.Windows.Forms.TextBox();
            this.lblShowAllData = new System.Windows.Forms.Label();
            this.pctBgForm2 = new System.Windows.Forms.PictureBox();
            this.btnSbDate = new System.Windows.Forms.Button();
            this.btnSbName = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtSbLName = new System.Windows.Forms.TextBox();
            this.btnSbLName = new System.Windows.Forms.Button();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.lblAnythingAtDate = new System.Windows.Forms.Label();
            this.dtP3 = new System.Windows.Forms.DateTimePicker();
            this.txtSearchAll = new System.Windows.Forms.TextBox();
            this.lblMoreInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBgForm2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtP2
            // 
            this.dtP2.Location = new System.Drawing.Point(44, 172);
            this.dtP2.Name = "dtP2";
            this.dtP2.Size = new System.Drawing.Size(200, 23);
            this.dtP2.TabIndex = 0;
            this.dtP2.ValueChanged += new System.EventHandler(this.dtP2_ValueChanged);
            // 
            // lblDateOfCT
            // 
            this.lblDateOfCT.AutoSize = true;
            this.lblDateOfCT.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfCT.ForeColor = System.Drawing.Color.Brown;
            this.lblDateOfCT.Location = new System.Drawing.Point(62, 119);
            this.lblDateOfCT.Name = "lblDateOfCT";
            this.lblDateOfCT.Size = new System.Drawing.Size(150, 23);
            this.lblDateOfCT.TabIndex = 2;
            this.lblDateOfCT.Text = "Search by Date:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poetsen One", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitle.Location = new System.Drawing.Point(76, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(423, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Lil\'John Admin Information Desk";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Futura Maxi CG Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaption.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCaption.Location = new System.Drawing.Point(86, 45);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(411, 44);
            this.lblCaption.TabIndex = 4;
            this.lblCaption.Text = "Access the contact tracing information of \r\ncutomers by their name, date or tempe" +
    "rature";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNameOfCT
            // 
            this.lblNameOfCT.AutoSize = true;
            this.lblNameOfCT.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameOfCT.ForeColor = System.Drawing.Color.Brown;
            this.lblNameOfCT.Location = new System.Drawing.Point(305, 105);
            this.lblNameOfCT.Name = "lblNameOfCT";
            this.lblNameOfCT.Size = new System.Drawing.Size(203, 23);
            this.lblNameOfCT.TabIndex = 6;
            this.lblNameOfCT.Text = "Search by First Name:";
            // 
            // txtSbName
            // 
            this.txtSbName.Location = new System.Drawing.Point(310, 131);
            this.txtSbName.Name = "txtSbName";
            this.txtSbName.PlaceholderText = "Juan";
            this.txtSbName.Size = new System.Drawing.Size(198, 23);
            this.txtSbName.TabIndex = 7;
            // 
            // lblShowAllData
            // 
            this.lblShowAllData.AutoSize = true;
            this.lblShowAllData.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowAllData.ForeColor = System.Drawing.Color.Brown;
            this.lblShowAllData.Location = new System.Drawing.Point(71, 358);
            this.lblShowAllData.Name = "lblShowAllData";
            this.lblShowAllData.Size = new System.Drawing.Size(141, 92);
            this.lblShowAllData.TabIndex = 8;
            this.lblShowAllData.Text = "Display All \r\nData Gathered\r\nfrom Contact \r\nTracing\r\n";
            this.lblShowAllData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pctBgForm2
            // 
            this.pctBgForm2.Image = ((System.Drawing.Image)(resources.GetObject("pctBgForm2.Image")));
            this.pctBgForm2.Location = new System.Drawing.Point(-59, 64);
            this.pctBgForm2.Name = "pctBgForm2";
            this.pctBgForm2.Size = new System.Drawing.Size(670, 637);
            this.pctBgForm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBgForm2.TabIndex = 9;
            this.pctBgForm2.TabStop = false;
            // 
            // btnSbDate
            // 
            this.btnSbDate.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSbDate.ForeColor = System.Drawing.Color.Peru;
            this.btnSbDate.Location = new System.Drawing.Point(76, 208);
            this.btnSbDate.Name = "btnSbDate";
            this.btnSbDate.Size = new System.Drawing.Size(121, 44);
            this.btnSbDate.TabIndex = 12;
            this.btnSbDate.Text = "Submit";
            this.btnSbDate.UseVisualStyleBackColor = true;
            this.btnSbDate.Click += new System.EventHandler(this.btnSbDate_Click);
            // 
            // btnSbName
            // 
            this.btnSbName.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSbName.ForeColor = System.Drawing.Color.Peru;
            this.btnSbName.Location = new System.Drawing.Point(344, 160);
            this.btnSbName.Name = "btnSbName";
            this.btnSbName.Size = new System.Drawing.Size(121, 44);
            this.btnSbName.TabIndex = 13;
            this.btnSbName.Text = "Submit";
            this.btnSbName.UseVisualStyleBackColor = true;
            this.btnSbName.Click += new System.EventHandler(this.btnSbName_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowAll.ForeColor = System.Drawing.Color.Peru;
            this.btnShowAll.Location = new System.Drawing.Point(79, 456);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(121, 44);
            this.btnShowAll.TabIndex = 14;
            this.btnShowAll.Text = "Show";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.Brown;
            this.lblLastName.Location = new System.Drawing.Point(305, 208);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(195, 23);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Search by Last Name";
            // 
            // txtSbLName
            // 
            this.txtSbLName.Location = new System.Drawing.Point(310, 234);
            this.txtSbLName.Name = "txtSbLName";
            this.txtSbLName.PlaceholderText = "Dela Cruz";
            this.txtSbLName.Size = new System.Drawing.Size(198, 23);
            this.txtSbLName.TabIndex = 16;
            // 
            // btnSbLName
            // 
            this.btnSbLName.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSbLName.ForeColor = System.Drawing.Color.Peru;
            this.btnSbLName.Location = new System.Drawing.Point(344, 260);
            this.btnSbLName.Name = "btnSbLName";
            this.btnSbLName.Size = new System.Drawing.Size(121, 44);
            this.btnSbLName.TabIndex = 17;
            this.btnSbLName.Text = "Submit";
            this.btnSbLName.UseVisualStyleBackColor = true;
            this.btnSbLName.Click += new System.EventHandler(this.btnSbLName_Click);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchAll.ForeColor = System.Drawing.Color.Peru;
            this.btnSearchAll.Location = new System.Drawing.Point(344, 466);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(121, 44);
            this.btnSearchAll.TabIndex = 20;
            this.btnSearchAll.Text = "Submit";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // lblAnythingAtDate
            // 
            this.lblAnythingAtDate.AutoSize = true;
            this.lblAnythingAtDate.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnythingAtDate.ForeColor = System.Drawing.Color.Brown;
            this.lblAnythingAtDate.Location = new System.Drawing.Point(327, 358);
            this.lblAnythingAtDate.Name = "lblAnythingAtDate";
            this.lblAnythingAtDate.Size = new System.Drawing.Size(157, 46);
            this.lblAnythingAtDate.TabIndex = 19;
            this.lblAnythingAtDate.Text = "Search Any Info \r\nat Specific Date:";
            this.lblAnythingAtDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtP3
            // 
            this.dtP3.Location = new System.Drawing.Point(308, 411);
            this.dtP3.Name = "dtP3";
            this.dtP3.Size = new System.Drawing.Size(200, 23);
            this.dtP3.TabIndex = 18;
            // 
            // txtSearchAll
            // 
            this.txtSearchAll.Location = new System.Drawing.Point(309, 437);
            this.txtSearchAll.Name = "txtSearchAll";
            this.txtSearchAll.PlaceholderText = "Juan / Temperature / Vaxxination";
            this.txtSearchAll.Size = new System.Drawing.Size(198, 23);
            this.txtSearchAll.TabIndex = 21;
            // 
            // lblMoreInfo
            // 
            this.lblMoreInfo.AutoSize = true;
            this.lblMoreInfo.Font = new System.Drawing.Font("Futura Maxi CG Bold", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMoreInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMoreInfo.Location = new System.Drawing.Point(55, 589);
            this.lblMoreInfo.Name = "lblMoreInfo";
            this.lblMoreInfo.Size = new System.Drawing.Size(445, 48);
            this.lblMoreInfo.TabIndex = 22;
            this.lblMoreInfo.Text = "Once searched and filtered, the program automatically \r\nsaves a text file contain" +
    "ing the specific search query of the admin.\r\nThis can be found at the root direc" +
    "tory of the program.\r\n";
            this.lblMoreInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(570, 690);
            this.Controls.Add(this.lblMoreInfo);
            this.Controls.Add(this.txtSearchAll);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.lblAnythingAtDate);
            this.Controls.Add(this.dtP3);
            this.Controls.Add(this.btnSbLName);
            this.Controls.Add(this.txtSbLName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSbName);
            this.Controls.Add(this.btnSbDate);
            this.Controls.Add(this.lblShowAllData);
            this.Controls.Add(this.txtSbName);
            this.Controls.Add(this.lblNameOfCT);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDateOfCT);
            this.Controls.Add(this.dtP2);
            this.Controls.Add(this.pctBgForm2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lil\'John Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pctBgForm2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtP2;
        private Label lblDateOfCT;
        private Label lblTitle;
        private Label lblCaption;
        private Label lblNameOfCT;
        private TextBox txtSbName;
        private Label lblShowAllData;
        private PictureBox pctBgForm2;
        private Button btnSbDate;
        private Button btnSbName;
        private Button btnShowAll;
        private Label lblLastName;
        private TextBox txtSbLName;
        private Button btnSbLName;
        private Button btnSearchAll;
        private Label lblAnythingAtDate;
        private DateTimePicker dtP3;
        private TextBox txtSearchAll;
        private Label lblMoreInfo;
    }
}