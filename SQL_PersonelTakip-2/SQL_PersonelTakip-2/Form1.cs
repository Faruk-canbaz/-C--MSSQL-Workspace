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
// using system.data.sqlClient kütüphanesi eklenmelidir.


namespace SQL_PersonelTakip_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        SqlConnection sqlBaglanti = new SqlConnection("Data Source=DESKTOP-74AFNHN\\SQLEXPRESS;Initial Catalog=personel2;Integrated Security=True");

        private void btnList_Click(object sender, EventArgs e)
        {
            this.tablo_personelTableAdapter1.Fill(this.personel2DataSet26.tablo_personel);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sqlBaglanti.Open();

            // verileri kaydetmek için yazılmıştır. sql command içinde yazılan komutlar aslında SQL komutlarıdır. DML komutlarıdır. 
            SqlCommand sqlKomut = new SqlCommand("insert into tablo_personel (perAd,perSoyad,perMaas,perMeslek) values (@p1,@p2,@p3,@p4)", sqlBaglanti);
            sqlKomut.Parameters.AddWithValue("@p1", txtAd.Text);
            sqlKomut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            sqlKomut.Parameters.AddWithValue("@p3", Convert.ToInt32(txtMaas.Text));
            sqlKomut.Parameters.AddWithValue("@p4", txtMeslek.Text);
            sqlKomut.ExecuteNonQuery();

            sqlBaglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSutun = dataGridView1.SelectedCells[0].RowIndex;

            // dataGridten araçlara veri çekmek için yazıldı burası.

            txtAd.Text = dataGridView1.Rows[secilenSutun].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilenSutun].Cells[2].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[secilenSutun].Cells[3].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilenSutun].Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // her işlemde sql açılmalı ve kapatılmalıdır. 
            sqlBaglanti.Open();

            // silme işlemi çift tıklayıp yapılmalıdır.!
            SqlCommand sqlSilKomutu = new SqlCommand("Delete from tablo_personel where perAd =@k1", sqlBaglanti);
            sqlSilKomutu.Parameters.AddWithValue("@k1",txtAd.Text);
            sqlSilKomutu.ExecuteNonQuery();

            sqlBaglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnClear_Enter(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
