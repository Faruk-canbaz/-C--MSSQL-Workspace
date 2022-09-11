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
    public partial class frmPatientDetail : Form
    {
        public frmPatientDetail()
        {
            InitializeComponent();
        }

       
        sqlRelations sqlPatientDetail = new sqlRelations();
        public string TC;
        public string Namee;
        public string Surname;
        public string TC2;
        public int saverTC = 0;
        public string totalName;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmPatientDetail_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            lblTC.Text = TC;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm tt";
            dateTimePicker1.ShowUpDown = true;

            // TODO: take a Name and Surname info from MSSQL
            lblNameSurname.Text = Namee + Surname;
            SqlCommand sqlPatientDetailC1 = new SqlCommand(" select patientName,patientSurname from tbl_patient where patientTC = @p1", sqlPatientDetail.newSqlConnection());
            sqlPatientDetailC1.Parameters.AddWithValue("@p1", lblTC.Text); // lblTC.TeXt diye değil de TC yazdığımız için iki saat gitti.
            SqlDataReader dr = sqlPatientDetailC1.ExecuteReader();

            while (dr.Read())
            {
                lblNameSurname.Text = dr[0] + " " + dr[1].ToString();
            }
            sqlPatientDetail.closeSqlConnection();

            // TODO: take appointment rewiew data from MSSQL with dataGridWiew wizard

            // data table sınıfından yeni bir nesne cagirarak hayali bir tablo olusturuyoruz.
            DataTable dt = new DataTable();
            // TC değerini direkt olarak bu şekilde de bağlayabilirsiniz her seferinde ayrı komut kullanmaya gerek yok !
            // sqlDataAdapter icine komut yazilirken parametrelere dikkat edilmeli, esitlenecek degiskenler mutlaka tek tırnak içinde olmalidir.
            SqlDataAdapter sqlAdapterrr = new SqlDataAdapter(" select * from tbl_appointment where patientTC = '" + lblTC.Text + "'", sqlPatientDetail.newSqlConnection());
            sqlAdapterrr.Fill(dt);
            // burada da hayali taplo dataGrid'e aktariliyor.
            dataGridView1.DataSource = dt;
            //sqlPatientDetail.closeSqlConnection();

            //TODO: Take a branch data 
            SqlCommand sqlPatientDetailC2 = new SqlCommand(" select * from tbl_Branch", sqlPatientDetail.newSqlConnection());
            SqlDataReader dr2 = sqlPatientDetailC2.ExecuteReader();

            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[1].ToString());
            }

            sqlPatientDetail.closeSqlConnection();

            if(saverTC == 1)
            {
                lblTC.Text = TC2;
                lblNameSurname.Text = totalName;
                saverTC = 0;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCommand sqlPatientDetailC3 = new SqlCommand("select doctorName, doctorSurname from tbl_doctor where doctorBranch =@c1", sqlPatientDetail.newSqlConnection());
            sqlPatientDetailC3.Parameters.AddWithValue("@c1", cmbBranch.Text);
            SqlDataReader dr3 = sqlPatientDetailC3.ExecuteReader();

            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            sqlPatientDetail.closeSqlConnection();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
         // cmb'den sonra kullanilan "'" kullanimi sql'den gelmektedir. Kelime aratilmak istenilirse tek tirnak icinde yazilmalidir.
            SqlDataAdapter sqlPatientDetailDa2 = new SqlDataAdapter(" select * from tbl_appointment " +
                "where trystBranch ='" + cmbBranch.Text + "'", sqlPatientDetail.newSqlConnection());
            sqlPatientDetailDa2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatientEditMyInfo frmPatientEditMyInfoObject = new frmPatientEditMyInfo();
            frmPatientEditMyInfoObject.Idnumber = lblTC.Text;
            frmPatientEditMyInfoObject.Show();
            this.Hide();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand sqlPatientDetailC4 = new SqlCommand(" insert into tbl_appointment (trystBranch,trystDoctor,trystDate," +
                "trystHour,patientTC,patientPlaint) values (@p1,@p2,@p3,@p4,@p5,@p6)", sqlPatientDetail.newSqlConnection());
            sqlPatientDetailC4.Parameters.AddWithValue("@p1", cmbBranch.Text);
            sqlPatientDetailC4.Parameters.AddWithValue("@p2", cmbDoctor.Text);
            sqlPatientDetailC4.Parameters.AddWithValue("@p3", tmDatePicker.Text);
            sqlPatientDetailC4.Parameters.AddWithValue("@p4", dateTimePicker1.Text);
            sqlPatientDetailC4.Parameters.AddWithValue("@p5", mskTC.Text);
            sqlPatientDetailC4.Parameters.AddWithValue("@p6", richTextBox1.Text);

            sqlPatientDetailC4.ExecuteNonQuery();

            sqlPatientDetail.closeSqlConnection();

            /*
            SqlCommand sqlPatientDetailC5 = new SqlCommand(" update tbl_appointment set " +
                "trystBranch = @a1,trystDoctor= @a2,trystDate= @a3,trystHour= @a4," +
                    "patientTC= @a5,patientPlaint= @a6", sqlPatientDetail.newSqlConnection());
            */
            SqlCommand sqlPatientDetailC5 = new SqlCommand(" update tbl_appointment set patientTC= @a5", sqlPatientDetail.newSqlConnection());
            /*
            sqlPatientDetailC5.Parameters.AddWithValue("@a1", cmbBranch.Text);
            sqlPatientDetailC5.Parameters.AddWithValue("@a2", cmbDoctor.Text);
            sqlPatientDetailC5.Parameters.AddWithValue("@a3", tmDatePicker.Text);
            sqlPatientDetailC5.Parameters.AddWithValue("@a4", dateTimePicker1.Text);
            */
            sqlPatientDetailC5.Parameters.AddWithValue("@a5", mskTC.Text);
            
            //sqlPatientDetailC5.Parameters.AddWithValue("@a6", richTextBox1.Text);

            sqlPatientDetailC5.ExecuteNonQuery();

            sqlPatientDetail.closeSqlConnection();

            MessageBox.Show(" Randevu Kaydınız Başarıyla tamamlanmıştır ve Güncellenmiştir. ", " Randevu Kayıt Bilgilendiricisi", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {

            DataTable dt3 = new DataTable();

            SqlDataAdapter sqlPatientDetailDa3 = new SqlDataAdapter(" select * from tbl_appointment where patientTC = '" + lblTC.Text + "'", sqlPatientDetail.newSqlConnection());

            sqlPatientDetailDa3.Fill(dt3);
            dataGridView2.DataSource = dt3;

            sqlPatientDetail.closeSqlConnection();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
