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
    public partial class frmPatientEntry : Form
    {
        public frmPatientEntry()
        {
            InitializeComponent();
        }
        sqlRelations sqlPatientEntry = new sqlRelations();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatientNewMembership frmNewMembershipObject = new frmPatientNewMembership();
            frmNewMembershipObject.Show();
            this.Close();
        }

        private void frmPatientEntry_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            mskTextBox.Focus();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnToEntrys_Click(object sender, EventArgs e)
        {
            frmAllEntrys frmAllEntrysObject = new frmAllEntrys();
            frmAllEntrysObject.Show();
            this.Close();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            SqlCommand sqlPatientEntryC1 = new SqlCommand(" select * from tbl_patient where " +
                "(patientTC = @p1 and patientPassword = @p2)",sqlPatientEntry.newSqlConnection());
            sqlPatientEntryC1.Parameters.AddWithValue("@p1",mskTextBox.Text);
            sqlPatientEntryC1.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader sqlDr = sqlPatientEntryC1.ExecuteReader();

            if (sqlDr.Read())
            {
                frmPatientDetail frmPatientDetailObject = new frmPatientDetail();
                frmPatientDetailObject.TC = mskTextBox.Text;
                
                frmPatientDetailObject.Show();
                
                this.Close();
            }
            else
            {
                MessageBox.Show(" Hatalı TC & Sifre Girdiniz ", " Hata Kodu: 404", 
                    MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                mskTextBox.Clear();
                txtPassword.Clear();
                mskTextBox.Focus();
            }
            sqlPatientEntry.closeSqlConnection();
        }
    }
}
