namespace UnicodeExcelAddin
{
    partial class frmSortingOption
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
            this.pbAcending = new System.Windows.Forms.PictureBox();
            this.pbDescending = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.rdAscending = new System.Windows.Forms.RadioButton();
            this.rdDescending = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAcending
            // 
            this.pbAcending.Image = global::UnicodeExcelAddin.Properties.Resources.icon_6;
            this.pbAcending.Location = new System.Drawing.Point(92, 83);
            this.pbAcending.Name = "pbAcending";
            this.pbAcending.Size = new System.Drawing.Size(108, 121);
            this.pbAcending.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAcending.TabIndex = 1;
            this.pbAcending.TabStop = false;
            this.pbAcending.Click += new System.EventHandler(this.pbAcending_Click);
            // 
            // pbDescending
            // 
            this.pbDescending.Image = global::UnicodeExcelAddin.Properties.Resources.icon_6_1;
            this.pbDescending.Location = new System.Drawing.Point(255, 83);
            this.pbDescending.Name = "pbDescending";
            this.pbDescending.Size = new System.Drawing.Size(108, 121);
            this.pbDescending.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDescending.TabIndex = 0;
            this.pbDescending.TabStop = false;
            this.pbDescending.Click += new System.EventHandler(this.pbDescending_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(319, 292);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Dismiss";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Location = new System.Drawing.Point(13, 292);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(128, 40);
            this.btnProcess.TabIndex = 9;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // rdAscending
            // 
            this.rdAscending.AutoSize = true;
            this.rdAscending.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAscending.Location = new System.Drawing.Point(92, 223);
            this.rdAscending.Name = "rdAscending";
            this.rdAscending.Size = new System.Drawing.Size(128, 25);
            this.rdAscending.TabIndex = 11;
            this.rdAscending.TabStop = true;
            this.rdAscending.Text = "ASCENDING";
            this.rdAscending.UseVisualStyleBackColor = true;
            // 
            // rdDescending
            // 
            this.rdDescending.AutoSize = true;
            this.rdDescending.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDescending.Location = new System.Drawing.Point(255, 223);
            this.rdDescending.Name = "rdDescending";
            this.rdDescending.Size = new System.Drawing.Size(138, 25);
            this.rdDescending.TabIndex = 12;
            this.rdDescending.TabStop = true;
            this.rdDescending.Text = "DESCENDING";
            this.rdDescending.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UnicodeExcelAddin.Properties.Resources.MMNLP_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(416, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 42);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmSortingOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(460, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdDescending);
            this.Controls.Add(this.rdAscending);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.pbAcending);
            this.Controls.Add(this.pbDescending);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSortingOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSortingOption";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSortingOption_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbAcending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDescending;
        private System.Windows.Forms.PictureBox pbAcending;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.RadioButton rdAscending;
        private System.Windows.Forms.RadioButton rdDescending;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}