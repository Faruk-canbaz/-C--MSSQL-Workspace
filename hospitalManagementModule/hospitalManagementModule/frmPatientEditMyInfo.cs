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
    public partial class frmPatientEditMyInfo : Form
    {
        public frmPatientEditMyInfo()
        {
            InitializeComponent();
        }

        sqlRelations sqlPatientEditInfo = new sqlRelations();
        public string Idnumber;
        
        private void frmPatientEditMyInfo_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            mskTxtTC.Text = Idnumber;
            SqlCommand sqlPatientEditC2 = new SqlCommand(" select * from tbl_patient where patientTC =@v1",
                sqlPatientEditInfo.newSqlConnection());
            sqlPatientEditC2.Parameters.AddWithValue("@v1", mskTxtTC.Text);
            SqlDataReader dr1 = sqlPatientEditC2.ExecuteReader();

            while (dr1.Read())
            {
                txtName.Text = dr1[1].ToString();
                txtSurname.Text = dr1[2].ToString();
                mskTxtTC.Text = dr1[3].ToString(); 
                mskTxtTelephone.Text = dr1[4].ToString();
                txtPassword.Text = dr1[5].ToString();
                cmbGender.Text = dr1[6].ToString();
            }

            sqlPatientEditInfo.closeSqlConnection();
        }

        private void btnToPatientEntry_Click(object sender, EventArgs e)
        {
            frmPatientDetail frmPatientDetailObject = new frmPatientDetail();
            frmPatientDetailObject.TC2 = mskTxtTC.Text;
            frmPatientDetailObject.totalName = txtName.Text + " " + txtSurname.Text;
            frmPatientDetailObject.saverTC = 1;
            frmPatientDetailObject.Show();
            this.Close();
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            SqlCommand sqlPatientEditC1 = new SqlCommand(" update tbl_patient set " +
                "patientName =@y1,patientSurname =@y2,patientTC =@y3," +
                    "patientTelephone =@y4,patientPassword =@y5,patientGender =@y6",sqlPatientEditInfo.newSqlConnection());

            sqlPatientEditC1.Parameters.AddWithValue("@y1", txtName.Text);
            sqlPatientEditC1.Parameters.AddWithValue("@y2", txtSurname.Text);
            sqlPatientEditC1.Parameters.AddWithValue("@y3", mskTxtTC.Text);
            sqlPatientEditC1.Parameters.AddWithValue("@y4", mskTxtTelephone.Text);
            sqlPatientEditC1.Parameters.AddWithValue("@y5", txtPassword.Text);
            sqlPatientEditC1.Parameters.AddWithValue("@y6", cmbGender.Text);
            
            sqlPatientEditC1.ExecuteNonQuery();

            MessageBox.Show(" Bilgileriniz Başarıyla Güncellenmiştir ", " Güncelleme Bildiricisi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);


            sqlPatientEditInfo.closeSqlConnection();
        }
    }
}
