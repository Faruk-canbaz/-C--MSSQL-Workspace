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
    public partial class frmDoctorEntry : Form
    {
        public frmDoctorEntry()
        {
            InitializeComponent();
        }

        private void frmDoctorEntry_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            mskTextBox.Focus();
            
        }

        private void btnToEntrys_Click(object sender, EventArgs e)
        {
            frmAllEntrys frmAllEntrysObject = new frmAllEntrys();
            frmAllEntrysObject.Show();
            this.Close();
        }
    }
}
