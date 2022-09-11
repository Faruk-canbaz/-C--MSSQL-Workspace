using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalManagementModule
{
    public partial class frmAllEntrys : Form
    {
        
        public frmAllEntrys()
        {
            InitializeComponent();
        }
        int counter = 0;

        private void frmAllEntrys_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            btnPatientEntry.Focus();
            
        }
        private void btnPatientEntry_Click(object sender, EventArgs e)
        {
            frmPatientEntry frmPatientEntryObject = new frmPatientEntry();
            frmPatientEntryObject.Show();
            this.Hide();
        }

        private void btnDoctorEntry_Click(object sender, EventArgs e)
        {
            frmDoctorEntry frmDoctorEntryObject = new frmDoctorEntry();
            frmDoctorEntryObject.Show();
            this.Hide();  
        }

        private void btnSecretaryEntry_Click(object sender, EventArgs e)
        {
            frmSecretaryEntry frmSecretaryEntryobject = new frmSecretaryEntry();
            frmSecretaryEntryobject.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            counter++;
        }

        private void btnDoctorEntry_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
