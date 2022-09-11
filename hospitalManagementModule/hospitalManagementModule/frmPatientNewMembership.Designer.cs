namespace hospitalManagementModule
{
    partial class frmPatientNewMembership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientNewMembership));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.mskTxtTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTxtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnToEntrys = new System.Windows.Forms.Button();
            this.btnToPatientEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(260, 321);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(157, 34);
            this.txtPassword.TabIndex = 5;
            // 
            // mskTxtTC
            // 
            this.mskTxtTC.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTxtTC.Location = new System.Drawing.Point(260, 220);
            this.mskTxtTC.Mask = "00000000000";
            this.mskTxtTC.Name = "mskTxtTC";
            this.mskTxtTC.Size = new System.Drawing.Size(157, 34);
            this.mskTxtTC.TabIndex = 3;
            this.mskTxtTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(101, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta Sifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "T.C. Kimlik Numarası: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(260, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 34);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hasta Adı:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(260, 173);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(157, 34);
            this.txtSurname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(79, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hasta Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(68, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hasta Cinsiyet:";
            // 
            // mskTxtTelephone
            // 
            this.mskTxtTelephone.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTxtTelephone.Location = new System.Drawing.Point(260, 269);
            this.mskTxtTelephone.Mask = "(999) 000-0000";
            this.mskTxtTelephone.Name = "mskTxtTelephone";
            this.mskTxtTelephone.Size = new System.Drawing.Size(157, 34);
            this.mskTxtTelephone.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Telefon Numarası:";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbGender.Location = new System.Drawing.Point(260, 378);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(157, 34);
            this.cmbGender.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(64, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(724, 38);
            this.label7.TabIndex = 19;
            this.label7.Text = "Eskişehir Şehir Hastanesi Yeni Hasta Kayıt Paneli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(483, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(483, 269);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(379, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(260, 437);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(157, 54);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnToEntrys
            // 
            this.btnToEntrys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnToEntrys.BackColor = System.Drawing.Color.White;
            this.btnToEntrys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToEntrys.BackgroundImage")));
            this.btnToEntrys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToEntrys.Location = new System.Drawing.Point(771, 458);
            this.btnToEntrys.Name = "btnToEntrys";
            this.btnToEntrys.Size = new System.Drawing.Size(91, 59);
            this.btnToEntrys.TabIndex = 23;
            this.btnToEntrys.UseVisualStyleBackColor = false;
            this.btnToEntrys.Click += new System.EventHandler(this.btnToEntrys_Click);
            // 
            // btnToPatientEntry
            // 
            this.btnToPatientEntry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnToPatientEntry.BackColor = System.Drawing.Color.White;
            this.btnToPatientEntry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToPatientEntry.BackgroundImage")));
            this.btnToPatientEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToPatientEntry.Location = new System.Drawing.Point(674, 458);
            this.btnToPatientEntry.Name = "btnToPatientEntry";
            this.btnToPatientEntry.Size = new System.Drawing.Size(91, 59);
            this.btnToPatientEntry.TabIndex = 24;
            this.btnToPatientEntry.UseVisualStyleBackColor = false;
            this.btnToPatientEntry.Click += new System.EventHandler(this.btnToPatientEntry_Click);
            // 
            // frmPatientNewMembership
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 526);
            this.Controls.Add(this.btnToPatientEntry);
            this.Controls.Add(this.btnToEntrys);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTxtTelephone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.mskTxtTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmPatientNewMembership";
            this.Text = "Hospital Management Module v1.9";
            this.Load += new System.EventHandler(this.frmPatientNewMembership_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox mskTxtTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTxtTelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnToEntrys;
        private System.Windows.Forms.Button btnToPatientEntry;
    }
}