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
    public partial class frmSecretaryoppointmentList : Form
    {
        sqlRelations sqlSecAppointment = new sqlRelations();

        public frmSecretaryoppointmentList()
        {
            InitializeComponent();
        }

        private void frmSecretaryoppointmentList_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm tt";
            dateTimePicker1.ShowUpDown = true;

            DataTable dt1 = new DataTable();

            SqlDataAdapter sqlDSecAppoDa1 = new SqlDataAdapter(" select * from tbl_appointment ",
                sqlSecAppointment.newSqlConnection());
            sqlDSecAppoDa1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            sqlSecAppointment.closeSqlConnection();

            /*
            DataTable dt2 = new DataTable();

            SqlDataAdapter sqlSecAppoDa2 = new SqlDataAdapter(" select trystID,trystDate,trystHour, as ' TarihSaat ' ," +
                "trystBranch as ' Branş ' , trystDoctor as ' Doktor AdSoyad ', trystState as ' Durum ' , " +
                "patientTC as ' Hasta TC ' from tbl_appointment ", sqlSecAppointment.newSqlConnection());

            sqlSecAppoDa2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            sqlSecAppointment.closeSqlConnection();
            */

            SqlCommand sqlSecretaryDetailsC3 = new SqlCommand("select * from tbl_branch", sqlSecAppointment.newSqlConnection());
            SqlDataReader dr2 = sqlSecretaryDetailsC3.ExecuteReader();

            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[1].ToString());
            }
            sqlSecAppointment.closeSqlConnection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlSecretaryDetailsC1 = new SqlCommand(" insert into tbl_appointment (trystDate,trystHour,trystBranch," +
                "trystDoctor,trystState,patientTC) values (@v1,@v2,@v3,@v4,@v5,@v6)", sqlSecAppointment.newSqlConnection());
            sqlSecretaryDetailsC1.Parameters.AddWithValue("@v1", tmDatePicker.Text);
            sqlSecretaryDetailsC1.Parameters.AddWithValue("@v2", dateTimePicker1.Text);
            sqlSecretaryDetailsC1.Parameters.AddWithValue("@v3", cmbBranch.Text);
            sqlSecretaryDetailsC1.Parameters.AddWithValue("@v4", cmbDoctor.Text);
            sqlSecretaryDetailsC1.Parameters.AddWithValue("@v5", txtState.Text);
            sqlSecretaryDetailsC1.Parameters.AddWithValue("@v6", mskTC.Text);

            sqlSecretaryDetailsC1.ExecuteNonQuery();

            sqlSecAppointment.closeSqlConnection();
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();

            // TODO: doctor data to cmb
            SqlCommand sqlSecretaryDetailsC4 = new SqlCommand(" select doctorName,doctorSurname from tbl_doctor " +
                "where doctorBranch = @h1", sqlSecAppointment.newSqlConnection());
            sqlSecretaryDetailsC4.Parameters.AddWithValue("@h1", cmbBranch.Text);
            SqlDataReader dr3 = sqlSecretaryDetailsC4.ExecuteReader();

            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            sqlSecAppointment.closeSqlConnection();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();

            SqlDataAdapter sqlSecAppoDa2 = new SqlDataAdapter(" select trystID,trystDate,trystHour," +
                "trystBranch, trystDoctor, trystState " +
                    "patientTC from tbl_appointment ", sqlSecAppointment.newSqlConnection());

            sqlSecAppoDa2.Fill(dt3);
            dataGridView1.DataSource = dt3;

            sqlSecAppointment.closeSqlConnection();

        }
    }
}
