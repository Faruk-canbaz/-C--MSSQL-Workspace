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
using System.Xml.Linq;

namespace hospitalManagementModule
{
    public partial class frmSecretaryBranch : Form
    {
        public frmSecretaryBranch()
        {
            InitializeComponent();
        }
        sqlRelations sqlSecBranch = new sqlRelations();
        int a;
        private void frmSecretaryBranch_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            setTabIndex();

            DataTable dt1 = new DataTable();
            SqlDataAdapter sqlSecBranchDA1 = new SqlDataAdapter(" select branchID as ' Branş Numarası ', " +
                "branchName as ' Branş İsmi ' from tbl_branch", sqlSecBranch.newSqlConnection());
            sqlSecBranchDA1.Fill(dt1);
            dataGridView1.DataSource=dt1;

            sqlSecBranch.closeSqlConnection();

            SqlCommand sqlSecBranchC3 = new SqlCommand(" select * from tbl_branch order by branchID asc",
                sqlSecBranch.newSqlConnection());
            SqlDataReader dr1 = sqlSecBranchC3.ExecuteReader();

            while (dr1.Read())
            {
                
                a = Convert.ToInt16(dr1[0].ToString());
                a = a + 1;
                txtID.Text = a.ToString();
            }
         }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlSecBranchC1 = new SqlCommand(" insert into tbl_branch (branchName,branchID) " +
                "values (@d2,@d3)",sqlSecBranch.newSqlConnection());
            sqlSecBranchC1.Parameters.AddWithValue("@d2", txtBranchName.Text);
            sqlSecBranchC1.Parameters.AddWithValue("@d3", txtID.Text);
            sqlSecBranchC1.ExecuteNonQuery();

            sqlSecBranch.closeSqlConnection();

            MessageBox.Show(txtBranchName.Text + " Adlı branş sisteme eklenmiştir. ", " Branş Ekleme Paneli Bildiricisi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand sqlSecBranchC2 = new SqlCommand(" update tbl_branch Set branchName= @b2 where branchID= @b3", 
                sqlSecBranch.newSqlConnection());
            sqlSecBranchC2.Parameters.AddWithValue("@b2", txtBranchName.Text);
            sqlSecBranchC2.Parameters.AddWithValue("@b3", txtID.Text);
            sqlSecBranchC2.ExecuteNonQuery();

            sqlSecBranch.closeSqlConnection();

            MessageBox.Show(txtBranchName.Text + " Branş kaydınız başarıyla Güncellenmiştir. ", " Branş Paneli Bildiricisi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlCommand sqlSecBranchC4 = new SqlCommand(" delete from tbl_branch " +
                "where (branchName=@d1 and branchID = @d3)", sqlSecBranch.newSqlConnection());
            sqlSecBranchC4.Parameters.AddWithValue("@d1", txtBranchName.Text);
            sqlSecBranchC4.Parameters.AddWithValue("@d3", txtID.Text);
            sqlSecBranchC4.ExecuteNonQuery();

            sqlSecBranch.closeSqlConnection();

            MessageBox.Show(txtBranchName.Text + " Branş kaydınız başarıyla silinmiştir. ", " Branş Paneli Bildiricisi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBranchName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void setTabIndex()
        {
            txtID.TabIndex = 1;
            txtBranchName.TabIndex = 2;
            btnAdd.TabIndex = 3;
            btnList.TabIndex = 4;
            btnRefresh.TabIndex = 5;
            btnDelete.TabIndex = 6;
        }

        private void btnList_Click(object sender, EventArgs e)
        {

            DataTable dt2 = new DataTable();
            SqlDataAdapter sqlSecBranchDA2 = new SqlDataAdapter(" select branchID as ' Branş Numarası ', " +
                "branchName as ' Branş İsmi ' from tbl_branch", sqlSecBranch.newSqlConnection());
            sqlSecBranchDA2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            a = a + 1;
            txtID.Text = a.ToString();

            sqlSecBranch.closeSqlConnection();
        }
    }
}
