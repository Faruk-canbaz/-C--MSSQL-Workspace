namespace hospitalManagementModule
{
    partial class frmPatientEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientEntry));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.mskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnToEntrys = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eskişehir Şehir Hastanesi Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C. Kimlik Numarası: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifre:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 301);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 23);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Yeni üyelik açın";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // mskTextBox
            // 
            this.mskTextBox.Location = new System.Drawing.Point(195, 79);
            this.mskTextBox.Mask = "00000000000";
            this.mskTextBox.Name = "mskTextBox";
            this.mskTextBox.Size = new System.Drawing.Size(135, 30);
            this.mskTextBox.TabIndex = 1;
            this.mskTextBox.ValidatingType = typeof(int);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(195, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 30);
            this.txtPassword.TabIndex = 2;
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.Location = new System.Drawing.Point(195, 171);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(135, 57);
            this.btnEntry.TabIndex = 3;
            this.btnEntry.Text = "Giris Yap";
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sisteme üye değil misiniz ? ";
            // 
            // btnToEntrys
            // 
            this.btnToEntrys.BackColor = System.Drawing.Color.White;
            this.btnToEntrys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToEntrys.BackgroundImage")));
            this.btnToEntrys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToEntrys.Location = new System.Drawing.Point(569, 242);
            this.btnToEntrys.Name = "btnToEntrys";
            this.btnToEntrys.Size = new System.Drawing.Size(91, 59);
            this.btnToEntrys.TabIndex = 9;
            this.btnToEntrys.UseVisualStyleBackColor = false;
            this.btnToEntrys.Click += new System.EventHandler(this.btnToEntrys_Click);
            // 
            // frmPatientEntry
            // 
            this.AcceptButton = this.btnEntry;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 345);
            this.Controls.Add(this.btnToEntrys);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.mskTextBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPatientEntry";
            this.Text = "Hospital Management Module v1.9";
            this.Load += new System.EventHandler(this.frmPatientEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MaskedTextBox mskTextBox;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnToEntrys;
    }
}