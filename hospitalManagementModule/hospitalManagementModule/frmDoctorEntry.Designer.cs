namespace hospitalManagementModule
{
    partial class frmDoctorEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorEntry));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToEntrys = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.mskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.Location = new System.Drawing.Point(209, 202);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(135, 57);
            this.btnEntry.TabIndex = 13;
            this.btnEntry.Text = "Giris Yap";
            this.btnEntry.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Eskişehir Şehir Hastanesi Doktor Giriş Paneli";
            // 
            // btnToEntrys
            // 
            this.btnToEntrys.BackColor = System.Drawing.Color.White;
            this.btnToEntrys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToEntrys.BackgroundImage")));
            this.btnToEntrys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToEntrys.Location = new System.Drawing.Point(607, 248);
            this.btnToEntrys.Name = "btnToEntrys";
            this.btnToEntrys.Size = new System.Drawing.Size(87, 56);
            this.btnToEntrys.TabIndex = 15;
            this.btnToEntrys.UseVisualStyleBackColor = false;
            this.btnToEntrys.Click += new System.EventHandler(this.btnToEntrys_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(205, 153);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 30);
            this.txtPassword.TabIndex = 2;
            // 
            // mskTextBox
            // 
            this.mskTextBox.Location = new System.Drawing.Point(205, 97);
            this.mskTextBox.Mask = "00000000000";
            this.mskTextBox.Name = "mskTextBox";
            this.mskTextBox.Size = new System.Drawing.Size(135, 30);
            this.mskTextBox.TabIndex = 1;
            this.mskTextBox.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "T.C. Kimlik Numarası: ";
            // 
            // frmDoctorEntry
            // 
            this.AcceptButton = this.btnEntry;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 322);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.mskTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnToEntrys);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoctorEntry";
            this.Text = "Hospital Management Module v1.9";
            this.Load += new System.EventHandler(this.frmDoctorEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToEntrys;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox mskTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}