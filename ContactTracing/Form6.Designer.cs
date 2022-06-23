namespace ContactTracing
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(1051, 23);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "This form shows an overview of the information. This is also saved via text file " +
    "on the root directory of this program.\r\n";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Poetsen One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(21, 41);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 14);
            this.lblInfo.TabIndex = 5;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1548, 539);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblInstructions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInstructions;
        private Label lblInfo;
    }
}