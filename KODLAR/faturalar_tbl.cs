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
    public partial class faturalar_tbl : Form
    {
        public faturalar_tbl()
        {
            InitializeComponent();
        }
        void liste()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From FATURA_tbl", bgl.baglan());//tabloyu gösterdi
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        baglantı_sql bgl = new baglantı_sql();
        private void faturalar_tbl_Load(object sender, EventArgs e)
        {
            liste();
        }
        void temizle()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("Insert into FATURA_tbl (SERI,SIRA_NO,TARIH,SAAT,VERGI_DAIRE,ALICI,TESLIM_EDEN,TESLIM_ALAN) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", bgl.baglan());
            ekle.Parameters.AddWithValue("@P1", textBox2.Text);
            ekle.Parameters.AddWithValue("@P2", textBox3.Text);
            ekle.Parameters.AddWithValue("@P3", maskedTextBox1.Text);
            ekle.Parameters.AddWithValue("@P4", maskedTextBox2.Text);
            ekle.Parameters.AddWithValue("@P5", textBox6.Text);
            ekle.Parameters.AddWithValue("@P6", textBox4.Text);
            ekle.Parameters.AddWithValue("@P7", textBox5.Text);
            ekle.Parameters.AddWithValue("@P8", textBox7.Text);
            ekle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Sisteme eklendi", "EKLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste();
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand güncelle = new SqlCommand("update FATURA_tbl set SERI=@P1,SIRA_NO=@P2,TARIH=@P3,SAAT=@P4,VERGI_DAIRE=@P5,ALICI=@P6,TESLIM_EDEN=@P7,TESLIM_ALAN=@P8 where ID=@P9", bgl.baglan());
            güncelle.Parameters.AddWithValue("@P1", textBox2.Text);
            güncelle.Parameters.AddWithValue("@P2", textBox3.Text);
            güncelle.Parameters.AddWithValue("@P3", maskedTextBox1.Text);
            güncelle.Parameters.AddWithValue("@P4", maskedTextBox2.Text);
            güncelle.Parameters.AddWithValue("@P5", textBox6.Text);
            güncelle.Parameters.AddWithValue("@P6", textBox4.Text);
            güncelle.Parameters.AddWithValue("@P7", textBox5.Text);
            güncelle.Parameters.AddWithValue("@P8", textBox7.Text);
            güncelle.Parameters.AddWithValue("@P9", textBox1.Text);
            güncelle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Sistem güncellendi", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste();
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("DELETE from FATURA_tbl where ID=@P1", bgl.baglan());
            sil.Parameters.AddWithValue("@P1", textBox1.Text);
            sil.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Seçili olanlar silindi", "sil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste();
            temizle();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
           
        }
    }
}
