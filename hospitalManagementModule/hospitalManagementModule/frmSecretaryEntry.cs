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
    public partial class frmSecretaryEntry : Form
    {
        public frmSecretaryEntry()
        {
            InitializeComponent();
        }

        sqlRelations sqlSecretaryEntry = new sqlRelations();

        private void btnToEntrys_Click(object sender, EventArgs e)
        {
            frmAllEntrys frmAllEntrysObject = new frmAllEntrys();
            frmAllEntrysObject.Show();
            this.Close();
        }

        private void frmSecretaryEntry_Load(object sender, EventArgs e)
        {
            ///***///
            mskTextBox.Text = "12345678910";
            txtPassword.Text = "1234";
            MaximizeBox = false;
            mskTextBox.Focus();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            SqlCommand sqlSecretaryEntryC1 = new SqlCommand(" select * from tbl_secretary " +
                "where secretaryTC = @g1 and secretaryPassword = @g2",sqlSecretaryEntry.newSqlConnection());
            sqlSecretaryEntryC1.Parameters.AddWithValue("@g1", mskTextBox.Text);
            sqlSecretaryEntryC1.Parameters.AddWithValue("@g2",txtPassword.Text);
            SqlDataReader dr1 = sqlSecretaryEntryC1.ExecuteReader();

            if (dr1.Read())
            {
                frmSecretaryDetail frmPatientDetailObject = new frmSecretaryDetail();
                frmPatientDetailObject.TCNumber = mskTextBox.Text;
                frmPatientDetailObject.Show();
                //MessageBox.Show(" Giris Başarılı"," Randevu Kayıt Sistemi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Eksik veya Hatalı Giriş Yaptınız", " Randevu Kayıt Sistemi",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                mskTextBox.Clear();
                txtPassword.Clear();
                mskTextBox.Focus();
            }
        }
    }
}
