namespace HTMFoodVoucher
{
    partial class frmMain
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.btn_PrintAndIncrement = new System.Windows.Forms.Button();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 65);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print Current";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(12, 39);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(120, 20);
            this.nudID.TabIndex = 1;
            // 
            // btn_PrintAndIncrement
            // 
            this.btn_PrintAndIncrement.Location = new System.Drawing.Point(12, 94);
            this.btn_PrintAndIncrement.Name = "btn_PrintAndIncrement";
            this.btn_PrintAndIncrement.Size = new System.Drawing.Size(120, 23);
            this.btn_PrintAndIncrement.TabIndex = 2;
            this.btn_PrintAndIncrement.Text = "Print and Increment";
            this.btn_PrintAndIncrement.UseVisualStyleBackColor = true;
            this.btn_PrintAndIncrement.Click += new System.EventHandler(this.btn_PrintAndIncrement_Click);
            // 
            // cmbVendor
            // 
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Items.AddRange(new object[] {
            "JABBERWOCKY",
            "THE AMERICAN PIT BBQ"});
            this.cmbVendor.Location = new System.Drawing.Point(12, 12);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(121, 21);
            this.cmbVendor.TabIndex = 3;
            this.cmbVendor.Text = "SELECT VENDOR";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbVendor);
            this.Controls.Add(this.btn_PrintAndIncrement);
            this.Controls.Add(this.nudID);
            this.Controls.Add(this.btnPrint);
            this.Name = "frmMain";
            this.Text = "HTM Food Voucher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Button btn_PrintAndIncrement;
        private System.Windows.Forms.ComboBox cmbVendor;
    }
}

