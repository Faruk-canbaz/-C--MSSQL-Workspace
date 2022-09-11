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
    public partial class frmSecretaryDoctorPanel : Form
    {
        public frmSecretaryDoctorPanel()
        {
            InitializeComponent();
        }
        sqlRelations sqlSecretaryDoctor = new sqlRelations();
        private void btnToPatientEntry_Click(object sender, EventArgs e)
        {
            frmSecretaryDetail frmSecretaryDetailObject = new frmSecretaryDetail();
            frmSecretaryDetailObject.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmSecretaryDoctorPanel_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            setTabIndex();

            DataTable dt1 = new DataTable();
            SqlDataAdapter sqlSecDoctorDA1 = new SqlDataAdapter(" select * from tbl_doctor",sqlSecretaryDoctor.newSqlConnection());
            sqlSecDoctorDA1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            sqlSecretaryDoctor.closeSqlConnection();

            SqlCommand sqlSecDoctorPanC4 = new SqlCommand(" select * from tbl_branch",sqlSecretaryDoctor.newSqlConnection());
            SqlDataReader dr1 = sqlSecDoctorPanC4.ExecuteReader();
            while (dr1.Read())
            {
                cmbBranch.Items.Add(dr1[1].ToString());
            }

            sqlSecretaryDoctor.closeSqlConnection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlSecDoctorPanC1 = new SqlCommand(" insert into tbl_doctor " +
                "(doctorName,doctorSurname,doctorBranch,doctorTC,doctorSifre) " +
                "values (@d1,@d2,@d3,@d4,@d5)",sqlSecretaryDoctor.newSqlConnection());
            sqlSecDoctorPanC1.Parameters.AddWithValue("@d1",txtName.Text);
            sqlSecDoctorPanC1.Parameters.AddWithValue("@d2",txtSurname.Text);
            sqlSecDoctorPanC1.Parameters.AddWithValue("@d3",cmbBranch.Text);
            sqlSecDoctorPanC1.Parameters.AddWithValue("@d4",mskTC.Text);
            sqlSecDoctorPanC1.Parameters.AddWithValue("@d5",txtPassword.Text);
            
            sqlSecDoctorPanC1.ExecuteNonQuery();

            sqlSecretaryDoctor.closeSqlConnection();

            MessageBox.Show( txtName.Text + " Yeni doktor kaydınız başarıyla oluşturulmuştur şifreniz: " + txtPassword.Text, 
                " Randevu Paneli Bildiricisi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        
        private void setTabIndex()
        {
            int[] sayilar = new int[30];
            for (int i = 1; i <15; i++)
            {
                sayilar[i] = i;
            }
            cmbBranch.TabIndex = 1;
            txtName.TabIndex = 2;
            txtSurname.TabIndex = 3;
            mskTC.TabIndex = 4;
            txtPassword.TabIndex = 5;
            btnAdd.TabIndex = 6;
            btnDelete.TabIndex = 7;
            btnToPatientEntry.TabIndex = 8;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlCommand sqlSecDoctorPanC2 = new SqlCommand(" delete from tbl_doctor " +
                "where (doctorName=@d1 and doctorSurname=@d2 and doctorBranch=@d3 and doctorTC=@d4 and doctorSifre=@d5)"
                    ,sqlSecretaryDoctor.newSqlConnection());
            sqlSecDoctorPanC2.Parameters.AddWithValue("@d1", txtName.Text);
            sqlSecDoctorPanC2.Parameters.AddWithValue("@d2", txtSurname.Text);
            sqlSecDoctorPanC2.Parameters.AddWithValue("@d3", cmbBranch.Text);
            sqlSecDoctorPanC2.Parameters.AddWithValue("@d4", mskTC.Text);
            sqlSecDoctorPanC2.Parameters.AddWithValue("@d5", txtPassword.Text);

            sqlSecDoctorPanC2.ExecuteNonQuery();

            sqlSecretaryDoctor.closeSqlConnection();

            MessageBox.Show(txtName.Text + txtSurname.Text + " Doktor kaydınız başarıyla silinmiştir. ", " Randevu Paneli Bildiricisi", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // dataGrid'in secilen hucresinin 0.indexinin satırı secilmis olur.
            // dataGrid'de secilen satirin 1.hücresi cekilir, 0.hucre ID ondan onu almıyoruz.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBranch.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            SqlCommand sqlSecDoctorPanC3 = new SqlCommand(" update tbl_doctor " +
          " set doctorName=@d1, doctorSurname=@d2, doctorBranch=@d3, doctorTC=@d4, doctorSifre=@d5"
        , sqlSecretaryDoctor.newSqlConnection());
            sqlSecDoctorPanC3.Parameters.AddWithValue("@d1", txtName.Text);
            sqlSecDoctorPanC3.Parameters.AddWithValue("@d2", txtSurname.Text);
            sqlSecDoctorPanC3.Parameters.AddWithValue("@d3", cmbBranch.Text);
            sqlSecDoctorPanC3.Parameters.AddWithValue("@d4", mskTC.Text);
            sqlSecDoctorPanC3.Parameters.AddWithValue("@d5", txtPassword.Text);

            sqlSecDoctorPanC3.ExecuteNonQuery();

            sqlSecretaryDoctor.closeSqlConnection();

            MessageBox.Show(" Doktor kayıtları başarıyla güncellenmiştir. ", " Randevu Paneli Bildiricisi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnList_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter sqlSecDoctorDA2 = new SqlDataAdapter(" Select doctorId, doctorName, doctorSurname as ' " +
                "Doktor Ad Soyad ' ,doctorBranch as ' Doktor Branş ' , doctorTC , doctorSifre as ' Doktor Şifre ' " +
                    "from tbl_doctor", sqlSecretaryDoctor.newSqlConnection());
            sqlSecDoctorDA2.Fill(dt2);
            dataGridView1.DataSource = dt2;
           
            sqlSecretaryDoctor.closeSqlConnection();

            MessageBox.Show(" Doktor kayıtları başarıyla Listelenmiştir. ", " Randevu Paneli Bildiricisi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
