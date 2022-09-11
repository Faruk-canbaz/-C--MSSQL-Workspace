using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospitalManagementModule
{
    public partial class frmSecretaryDetail : Form
    {
        public frmSecretaryDetail()
        {
            InitializeComponent();
        }

        public string TCNumber;
        public string TCNumber2;
        sqlRelations sqlSecretaryDetail = new sqlRelations(); 
        private void frmSecretaryDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCNumber;
            //sqlSecretaryDetail.SecretaryTc = lblTC.Text;
            //lblTC.Text = TCNumber2;
            cmbBranch.Items.Clear();
            MaximizeBox = false;

            tmPicker1.Format = DateTimePickerFormat.Custom;
            tmPicker1.CustomFormat = "HH:mm tt";
            tmPicker1.ShowUpDown = true;

            tmDatePicker.Format = DateTimePickerFormat.Custom;
            tmDatePicker.CustomFormat = "dd MM yyyy";

            SqlCommand sqlSecretaryC1 = new SqlCommand(" select secretaryName,secretarySurname " +
                "from tbl_secretary where secretaryTC = @b1", sqlSecretaryDetail.newSqlConnection());
            sqlSecretaryC1.Parameters.AddWithValue("@b1",lblTC.Text);
            SqlDataReader dr1 = sqlSecretaryC1.ExecuteReader();

            while (dr1.Read())
            {
                lblNameSurname.Text = dr1[0]+" "+dr1[1];
            }
            sqlSecretaryDetail.closeSqlConnection();

            //TODO: take a branch data to Write DataGridWiew
            DataTable dt1 = new DataTable();
            SqlDataAdapter sqlSecretaryDA = new SqlDataAdapter("select branchName as ' Branş Adı ' " +
                "from tbl_branch",sqlSecretaryDetail.newSqlConnection());
            sqlSecretaryDA.Fill(dt1);
            dataGridView1.DataSource = dt1;
            sqlSecretaryDetail.closeSqlConnection();

            //TODO: take a doctor data to Write DataGridWiew
            DataTable dt2 = new DataTable();
            SqlDataAdapter sqlSecretaryDA2 = new SqlDataAdapter("select (doctorName + ' ' + doctorSurname) " +
                "as ' Doktorlar ',doctorBranch as ' Branşı ' " +
                "from tbl_doctor ",sqlSecretaryDetail.newSqlConnection());
            sqlSecretaryDA2.Fill(dt2);
            btnRfrsh.DataSource = dt2;
            sqlSecretaryDetail.closeSqlConnection();

            //TODO: branch to combobox
            SqlCommand sqlSecretaryDetailsC3 = new SqlCommand("select * from tbl_branch",sqlSecretaryDetail.newSqlConnection());
            SqlDataReader dr2 = sqlSecretaryDetailsC3.ExecuteReader();

            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[1].ToString());
            }
            sqlSecretaryDetail.closeSqlConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand sqlSecretaryDetailsC2 = new SqlCommand(" insert into tbl_appointment (trystDate,trystHour,trystBranch," +
                "trystDoctor,trystState,patientTC) values (@v1,@v2,@v3,@v4,@v5,@v6)", sqlSecretaryDetail.newSqlConnection());
            sqlSecretaryDetailsC2.Parameters.AddWithValue("@v1",tmDatePicker.Text);
            sqlSecretaryDetailsC2.Parameters.AddWithValue("@v2",tmPicker1.Text);
            sqlSecretaryDetailsC2.Parameters.AddWithValue("@v3",cmbBranch.Text);
            sqlSecretaryDetailsC2.Parameters.AddWithValue("@v4",cmbDoctor.Text);
            sqlSecretaryDetailsC2.Parameters.AddWithValue("@v5",txtState.Text);
            sqlSecretaryDetailsC2.Parameters.AddWithValue("@v6",mskTC.Text);

            sqlSecretaryDetailsC2.ExecuteNonQuery();

            sqlSecretaryDetail.closeSqlConnection();
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();

            // TODO: doctor data to cmb
            SqlCommand sqlSecretaryDetailsC4 = new SqlCommand(" select doctorName,doctorSurname from tbl_doctor " +
                "where doctorBranch = @h1", sqlSecretaryDetail.newSqlConnection());
            sqlSecretaryDetailsC4.Parameters.AddWithValue("@h1", cmbBranch.Text);
            SqlDataReader dr3 = sqlSecretaryDetailsC4.ExecuteReader();

            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            sqlSecretaryDetail.closeSqlConnection();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {

            //richTextBox1.Clear();
            //TODO: add a notices richTextBox

            SqlCommand sqlSecretaryDetailsC5 = new SqlCommand("insert into tbl_notice (noticeProp) values (@j1) ", 
                sqlSecretaryDetail.newSqlConnection());

            sqlSecretaryDetailsC5.Parameters.AddWithValue("@j1", richTextBox1.Text);
            sqlSecretaryDetailsC5.ExecuteNonQuery();

            sqlSecretaryDetail.closeSqlConnection();

            //TODO: update a notices richTextBox

            SqlCommand sqlSecretaryDetailsC6 = new SqlCommand("update tbl_notice set noticeProp = @h1",
                sqlSecretaryDetail.newSqlConnection());
            sqlSecretaryDetailsC6.Parameters.AddWithValue("@h1",richTextBox1.Text);
            sqlSecretaryDetailsC6.ExecuteNonQuery();

            sqlSecretaryDetail.closeSqlConnection();

            //TODO: list a notices richTextBox

            SqlCommand sqlSecretaryDetailsC4 = new SqlCommand("select * from tbl_notice", sqlSecretaryDetail.newSqlConnection());
            SqlDataReader dr3 = sqlSecretaryDetailsC4.ExecuteReader();

            while (dr3.Read())
            {
                richTextBox1.Text = dr3[0] + ".duyuru : \n" + dr3[1].ToString();
            }

            sqlSecretaryDetail.closeSqlConnection();

            MessageBox.Show(" Duyuru başarıyla oluşturulmuş ve panel güncellenmiştir", " Duyuru Paneli Bildiricisi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            richTextBox1.Clear();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand sqlSecretaryDetailsC7 = new SqlCommand("update tbl_appointment set trystDate = @g1,trystHour = @g2," +
                "trystBranch = @g3,trystDoctor = @g4,trystState = @g5,patientTC = @g6", sqlSecretaryDetail.newSqlConnection());
            sqlSecretaryDetailsC7.Parameters.AddWithValue("@g1",tmDatePicker.Text);
            sqlSecretaryDetailsC7.Parameters.AddWithValue("@g2",tmPicker1.Text);
            sqlSecretaryDetailsC7.Parameters.AddWithValue("@g3",cmbBranch.Text);
            sqlSecretaryDetailsC7.Parameters.AddWithValue("@g4",cmbDoctor.Text);
            sqlSecretaryDetailsC7.Parameters.AddWithValue("@g5",txtState.Text);
            sqlSecretaryDetailsC7.Parameters.AddWithValue("@g6",mskTC.Text);

            sqlSecretaryDetailsC7.ExecuteNonQuery();

            sqlSecretaryDetail.closeSqlConnection();

            MessageBox.Show(" Panel başarıyla güncellenmiştir", " Randevu Paneli Bildiricisi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoctorPanel_Click(object sender, EventArgs e)
        {
            frmSecretaryDoctorPanel frmSecretaryDoctorPanelObject = new frmSecretaryDoctorPanel();
            frmSecretaryDoctorPanelObject.Show();
            this.Hide();
        }

        private void btnBranchPanel_Click(object sender, EventArgs e)
        {
            frmSecretaryBranch frmSecretaryBranchObject = new frmSecretaryBranch();
            frmSecretaryBranchObject.Show();
            this.Hide();
        }

        private void btnAppointmentList_Click(object sender, EventArgs e)
        {
            frmSecretaryoppointmentList frmSecretaryoppointmentListObject = new frmSecretaryoppointmentList();
            frmSecretaryoppointmentListObject.Show();
            this.Hide();
        }
    }
}
