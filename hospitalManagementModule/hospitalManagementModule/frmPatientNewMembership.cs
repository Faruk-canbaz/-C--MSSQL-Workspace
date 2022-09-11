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
    public partial class frmPatientNewMembership : Form
    {
        public frmPatientNewMembership()
        {
            InitializeComponent();
        }
        sqlRelations sqlMembership = new sqlRelations();
        private void frmPatientNewMembership_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

        }

        private void btnToPatientEntry_Click(object sender, EventArgs e)
        {
            frmPatientEntry frmPatientEntryObject = new frmPatientEntry();
            frmPatientEntryObject.Show();
            this.Close();
        }

        private void btnToEntrys_Click(object sender, EventArgs e)
        {
            frmAllEntrys frmAllEntrysObject = new frmAllEntrys();
            frmAllEntrysObject.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand sqlMembershipC1 = new SqlCommand(" insert into tbl_patient" +
                "(patientName,patientSurname,patientTC,patientTelephone,patientPassword,patientGender)" +
                "values (@p1,@p2,@p3,@p4,@p5,@p6)", sqlMembership.newSqlConnection());
            sqlMembershipC1.Parameters.AddWithValue("@p1", txtName.Text);
            sqlMembershipC1.Parameters.AddWithValue("@p2", txtSurname.Text);
            sqlMembershipC1.Parameters.AddWithValue("@p3", mskTxtTC.Text);
            sqlMembershipC1.Parameters.AddWithValue("@p4", mskTxtTelephone.Text);
            sqlMembershipC1.Parameters.AddWithValue("@p5", txtPassword.Text);
            sqlMembershipC1.Parameters.AddWithValue("@p6", cmbGender.Text);
            sqlMembershipC1.ExecuteNonQuery();

            sqlMembership.closeSqlConnection();
            MessageBox.Show(txtName.Text + " " + txtSurname.Text + " Adına yapılmış olan kayıt başarılı şifreniz: " + txtPassword.Text , " Veri Tabanı Durum Bildirmesi ", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
