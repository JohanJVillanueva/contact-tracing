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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblShowAllData = new System.Windows.Forms.Label();
            this.pctBgForm2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBgForm2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtP2
            // 
            this.dtP2.Location = new System.Drawing.Point(41, 158);
            this.dtP2.Name = "dtP2";
            this.dtP2.Size = new System.Drawing.Size(200, 23);
            this.dtP2.TabIndex = 0;
            // 
            // lblDateOfCT
            // 
            this.lblDateOfCT.AutoSize = true;
            this.lblDateOfCT.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfCT.ForeColor = System.Drawing.Color.Brown;
            this.lblDateOfCT.Location = new System.Drawing.Point(63, 132);
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
            this.lblNameOfCT.Location = new System.Drawing.Point(328, 132);
            this.lblNameOfCT.Name = "lblNameOfCT";
            this.lblNameOfCT.Size = new System.Drawing.Size(159, 23);
            this.lblNameOfCT.TabIndex = 6;
            this.lblNameOfCT.Text = "Search by Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 23);
            this.textBox1.TabIndex = 7;
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
            this.pctBgForm2.Location = new System.Drawing.Point(-59, 70);
            this.pctBgForm2.Name = "pctBgForm2";
            this.pctBgForm2.Size = new System.Drawing.Size(670, 637);
            this.pctBgForm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBgForm2.TabIndex = 9;
            this.pctBgForm2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(570, 690);
            this.Controls.Add(this.lblShowAllData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNameOfCT);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDateOfCT);
            this.Controls.Add(this.dtP2);
            this.Controls.Add(this.pctBgForm2);
            this.Name = "Form2";
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
        private TextBox textBox1;
        private Label lblShowAllData;
        private PictureBox pctBgForm2;
    }
}