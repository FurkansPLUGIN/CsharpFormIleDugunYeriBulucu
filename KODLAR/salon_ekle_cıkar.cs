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
    public partial class salon_ekle_cıkar : Form
    {
        public salon_ekle_cıkar()
        {
            InitializeComponent();
        }
        baglantı_sql bgl = new baglantı_sql();


        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand sil = new SqlCommand("Delete from KAYIT_SALON_SAHIBI where ISIM=@P1", bgl.baglan());
            sil.Parameters.AddWithValue("@P1", textBox1.Text);
            sil.ExecuteNonQuery();
            bgl.baglan().Close();
            //MessageBox.Show("Silme tamamlandı", "SİLME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste1();

            SqlCommand sil1 = new SqlCommand("Delete from ADMIN_tbl where ID=@P1", bgl.baglan());
            sil1.Parameters.AddWithValue("@P1", textBox6.Text);
            sil1.ExecuteNonQuery();
            bgl.baglan().Close();
            //MessageBox.Show("Silme tamamlandı", "SİLME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste3();

            SqlCommand sil2 = new SqlCommand("Delete from SALON_ICI where SALON_ISIM=@P1", bgl.baglan());
            sil2.Parameters.AddWithValue("@P1", textBox10.Text);
            sil2.ExecuteNonQuery();
            bgl.baglan().Close();
            //MessageBox.Show("Silme tamamlandı", "SİLME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste2();
        }
        void sehirler()
        {
            SqlCommand komut = new SqlCommand("Select sehir From iller", bgl.baglan());//tablo altında olan bir başlıktan veri çekti
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0]);
            }
            bgl.baglan().Close();
        }
        void liste2()
        {
           
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From SALON_ICI", bgl.baglan());//tabloyu gösterdi
            adapter.Fill(table);
            dataGridView3.DataSource = table;
        }
        void liste1()
        {
           
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From KAYIT_SALON_SAHIBI", bgl.baglan());//tabloyu gösterdi
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        void liste3()
        {
           
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From ADMIN_tbl", bgl.baglan());//tabloyu gösterdi
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }
        private void salon_ekle_cıkar_Load(object sender, EventArgs e)
        {
            liste2();
            liste1();
            liste3();
            sehirler();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox8.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox10.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBox14.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBox15.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            textBox13.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            textBox12.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            textBox11.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            textBox9.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
