namespace hospitalManagementModule
{
    partial class frmSecretaryDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecretaryDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnnouncement = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tmPicker1 = new System.Windows.Forms.DateTimePicker();
            this.tmDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRfrsh = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAppointmentList = new System.Windows.Forms.Button();
            this.btnBranchPanel = new System.Windows.Forms.Button();
            this.btnDoctorPanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRfrsh)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNameSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Kişisel Bilgi";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNameSurname.Location = new System.Drawing.Point(121, 86);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(78, 23);
            this.lblNameSurname.TabIndex = 3;
            this.lblNameSurname.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTC.Location = new System.Drawing.Point(121, 43);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(131, 23);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAnnouncement);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(36, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 332);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru olustur";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.BackColor = System.Drawing.Color.White;
            this.btnAnnouncement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnouncement.BackgroundImage")));
            this.btnAnnouncement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnnouncement.Location = new System.Drawing.Point(10, 262);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(308, 64);
            this.btnAnnouncement.TabIndex = 1;
            this.btnAnnouncement.UseVisualStyleBackColor = false;
            this.btnAnnouncement.Click += new System.EventHandler(this.btnAnnouncement_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(10, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 189);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.tmPicker1);
            this.groupBox3.Controls.Add(this.tmDatePicker);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.cmbDoctor);
            this.groupBox3.Controls.Add(this.mskTC);
            this.groupBox3.Controls.Add(this.cmbBranch);
            this.groupBox3.Controls.Add(this.txtState);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(409, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 468);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(171, 397);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(132, 65);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tmPicker1
            // 
            this.tmPicker1.Location = new System.Drawing.Point(95, 177);
            this.tmPicker1.Name = "tmPicker1";
            this.tmPicker1.Size = new System.Drawing.Size(152, 30);
            this.tmPicker1.TabIndex = 23;
            // 
            // tmDatePicker
            // 
            this.tmDatePicker.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tmDatePicker.Location = new System.Drawing.Point(95, 89);
            this.tmDatePicker.Name = "tmDatePicker";
            this.tmDatePicker.Size = new System.Drawing.Size(152, 27);
            this.tmDatePicker.TabIndex = 31;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(13, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 65);
            this.btnSave.TabIndex = 19;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 345);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 27);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Randevu Durumu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(95, 213);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(152, 31);
            this.cmbDoctor.TabIndex = 16;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(95, 260);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(152, 30);
            this.mskTC.TabIndex = 14;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(95, 135);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(152, 31);
            this.cmbBranch.TabIndex = 14;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(95, 306);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(152, 30);
            this.txtState.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(95, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(152, 30);
            this.txtID.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Durum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "TC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Saat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Doktor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(772, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 227);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(330, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRfrsh);
            this.groupBox5.Location = new System.Drawing.Point(775, 348);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(330, 218);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // btnRfrsh
            // 
            this.btnRfrsh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.btnRfrsh.BackgroundColor = System.Drawing.Color.White;
            this.btnRfrsh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.btnRfrsh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRfrsh.Location = new System.Drawing.Point(3, 26);
            this.btnRfrsh.Name = "btnRfrsh";
            this.btnRfrsh.RowHeadersWidth = 51;
            this.btnRfrsh.RowTemplate.Height = 24;
            this.btnRfrsh.Size = new System.Drawing.Size(324, 189);
            this.btnRfrsh.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(172, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(735, 38);
            this.label10.TabIndex = 21;
            this.label10.Text = "Eskişehir Şehir Hastanesi Sekreter Yönetim Paneli\r\n";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAppointmentList);
            this.groupBox6.Controls.Add(this.btnBranchPanel);
            this.groupBox6.Controls.Add(this.btnDoctorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 569);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(700, 79);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kısayollar";
            // 
            // btnAppointmentList
            // 
            this.btnAppointmentList.Location = new System.Drawing.Point(397, 30);
            this.btnAppointmentList.Name = "btnAppointmentList";
            this.btnAppointmentList.Size = new System.Drawing.Size(167, 49);
            this.btnAppointmentList.TabIndex = 2;
            this.btnAppointmentList.Text = "Randevu Listesi";
            this.btnAppointmentList.UseVisualStyleBackColor = true;
            this.btnAppointmentList.Click += new System.EventHandler(this.btnAppointmentList_Click);
            // 
            // btnBranchPanel
            // 
            this.btnBranchPanel.Location = new System.Drawing.Point(204, 29);
            this.btnBranchPanel.Name = "btnBranchPanel";
            this.btnBranchPanel.Size = new System.Drawing.Size(177, 49);
            this.btnBranchPanel.TabIndex = 1;
            this.btnBranchPanel.Text = "Branş Paneli";
            this.btnBranchPanel.UseVisualStyleBackColor = true;
            this.btnBranchPanel.Click += new System.EventHandler(this.btnBranchPanel_Click);
            // 
            // btnDoctorPanel
            // 
            this.btnDoctorPanel.Location = new System.Drawing.Point(24, 29);
            this.btnDoctorPanel.Name = "btnDoctorPanel";
            this.btnDoctorPanel.Size = new System.Drawing.Size(161, 49);
            this.btnDoctorPanel.TabIndex = 0;
            this.btnDoctorPanel.Text = "Doktor Paneli";
            this.btnDoctorPanel.UseVisualStyleBackColor = true;
            this.btnDoctorPanel.Click += new System.EventHandler(this.btnDoctorPanel_Click);
            // 
            // frmSecretaryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1197, 660);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSecretaryDetail";
            this.Text = "frmSecretaryDetail";
            this.Load += new System.EventHandler(this.frmSecretaryDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRfrsh)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAnnouncement;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView btnRfrsh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAppointmentList;
        private System.Windows.Forms.Button btnBranchPanel;
        private System.Windows.Forms.Button btnDoctorPanel;
        private System.Windows.Forms.DateTimePicker tmDatePicker;
        private System.Windows.Forms.DateTimePicker tmPicker1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label lblTC;
    }
}