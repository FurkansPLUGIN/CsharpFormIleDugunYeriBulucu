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
namespace Otomasyon
{
    public partial class ayar_frm : Form
    {
        public ayar_frm()
        {
            InitializeComponent();
        }
        baglantı_sql bgl = new baglantı_sql();
        void liste()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From ADMIN_tbl", bgl.baglan());//tabloyu gösterdi
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        salon_ekle_cıkar ekcık;
        //void liste1()
        //{
        //    ekcık = new salon_ekle_cıkar();
        //    DataTable table = new DataTable();
        //    SqlDataAdapter adapter = new SqlDataAdapter("Select * From ADMIN_tbl", bgl.baglan());//tabloyu gösterdi
        //    adapter.Fill(table);
        //    ekcık.dataGridView2.DataSource = table;
        //}

        private void ayarlar_frm_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("INSERT into ADMIN_tbl(KULLANICI_AD,SİFRE) values (@P1,@P2)", bgl.baglan());
            ekle.Parameters.AddWithValue("@P1", textBox1.Text);
            ekle.Parameters.AddWithValue("@P2", textBox2.Text);
            ekle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Sisteme eklendi", "EKLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand güncelle = new SqlCommand("update ADMIN_tbl set KULLANICI_AD=@P1 , SİFRE=@P2 where ID=@P3", bgl.baglan());
            güncelle.Parameters.AddWithValue("@P1", textBox1.Text);
            güncelle.Parameters.AddWithValue("@P2", textBox2.Text);
            güncelle.Parameters.AddWithValue("@P3", textBox3.Text);
            güncelle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Sistem güncellendi", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
