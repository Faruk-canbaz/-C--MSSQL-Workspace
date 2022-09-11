namespace hospitalManagementModule
{
    partial class frmAllEntrys
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllEntrys));
            this.btnDoctorEntry = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPatientEntry = new System.Windows.Forms.Button();
            this.btnSecretaryEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoctorEntry
            // 
            this.btnDoctorEntry.BackColor = System.Drawing.Color.White;
            this.btnDoctorEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoctorEntry.BackgroundImage")));
            this.btnDoctorEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoctorEntry.Location = new System.Drawing.Point(341, 317);
            this.btnDoctorEntry.Name = "btnDoctorEntry";
            this.btnDoctorEntry.Size = new System.Drawing.Size(280, 210);
            this.btnDoctorEntry.TabIndex = 0;
            this.btnDoctorEntry.UseVisualStyleBackColor = false;
            this.btnDoctorEntry.Click += new System.EventHandler(this.btnDoctorEntry_Click);
            this.btnDoctorEntry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDoctorEntry_MouseClick);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnPatientEntry
            // 
            this.btnPatientEntry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPatientEntry.BackColor = System.Drawing.Color.White;
            this.btnPatientEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatientEntry.BackgroundImage")));
            this.btnPatientEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPatientEntry.Location = new System.Drawing.Point(36, 317);
            this.btnPatientEntry.Name = "btnPatientEntry";
            this.btnPatientEntry.Size = new System.Drawing.Size(280, 210);
            this.btnPatientEntry.TabIndex = 1;
            this.btnPatientEntry.UseVisualStyleBackColor = false;
            this.btnPatientEntry.Click += new System.EventHandler(this.btnPatientEntry_Click);
            // 
            // btnSecretaryEntry
            // 
            this.btnSecretaryEntry.BackColor = System.Drawing.Color.White;
            this.btnSecretaryEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSecretaryEntry.BackgroundImage")));
            this.btnSecretaryEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSecretaryEntry.Location = new System.Drawing.Point(670, 317);
            this.btnSecretaryEntry.Name = "btnSecretaryEntry";
            this.btnSecretaryEntry.Size = new System.Drawing.Size(280, 210);
            this.btnSecretaryEntry.TabIndex = 2;
            this.btnSecretaryEntry.UseVisualStyleBackColor = false;
            this.btnSecretaryEntry.Click += new System.EventHandler(this.btnSecretaryEntry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(896, 114);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eskişehir Şehir Hastanesi Hastane Yönetim Sistemi\r\n\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(439, 213);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAllEntrys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1015, 541);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSecretaryEntry);
            this.Controls.Add(this.btnPatientEntry);
            this.Controls.Add(this.btnDoctorEntry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAllEntrys";
            this.Text = "Hospital Management Module v1.9";
            this.Load += new System.EventHandler(this.frmAllEntrys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoctorEntry;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnPatientEntry;
        private System.Windows.Forms.Button btnSecretaryEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

