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
    public partial class musterıler_frm : Form
    {
        public musterıler_frm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       
        baglantı_sql bgl = new baglantı_sql();
        void liste()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From MUSTERILER_tbl", bgl.baglan());//tabloyu gösterdi
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        //void sehirler()
        //{
        //    SqlCommand komut = new SqlCommand("Select sehir From iller", bgl.baglan());//tablo altında olan bir başlıktan veri çekti
        //    SqlDataReader oku = komut.ExecuteReader();
        //    while (oku.Read())
        //    {
        //        comboBox1.Items.Add(oku[0]);
        //    }
        //    bgl.baglan().Close();
        //}

        private void musterıler_frm_Load(object sender, EventArgs e)
        {
            liste();
            //sehirler();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox2.Items.Clear();//başka sehirdeki ilçelerin üst üste gelmesini engelliyor
            //SqlCommand com = new SqlCommand("Select ilce From ilceler where sehir=@p1", bgl.baglan());
            //com.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex + 1);//to string de kullanılabir sectiğim indeks i bir artırarak oku[0] a eşitlemis oldum
            //SqlDataReader oku = com.ExecuteReader();
            //while (oku.Read())
            //{
            //    comboBox2.Items.Add(oku[0]);
            //}
            //bgl.baglan().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand ekle = new SqlCommand("INSERT into MUSTERILER_tbl (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,VERGI_DAIRE) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgl.baglan());
            //ekle.Parameters.AddWithValue("@P1", textBox2.Text);
            //ekle.Parameters.AddWithValue("@P2", textBox3.Text);
            //ekle.Parameters.AddWithValue("@P3", maskedTextBox1.Text);
            //ekle.Parameters.AddWithValue("@P4", maskedTextBox2.Text);
            //ekle.Parameters.AddWithValue("@P5", textBox6.Text);
            //ekle.Parameters.AddWithValue("@P6", comboBox1.Text);
            //ekle.Parameters.AddWithValue("@P7", comboBox2.Text);
            //ekle.Parameters.AddWithValue("@P8", richTextBox1.Text);
            //ekle.Parameters.AddWithValue("@P9", textBox5.Text);
            //ekle.ExecuteNonQuery();
            //bgl.baglan().Close();
            //MessageBox.Show("Sisteme eklendi", "EKLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //liste();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //burası yapılcak
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlCommand sil = new SqlCommand("DELETE from MUSTERILER_tbl where ID=@P1", bgl.baglan());
            //sil.Parameters.AddWithValue("@P1", textBox1.Text);
            //sil.ExecuteNonQuery();
            //bgl.baglan().Close();
            //MessageBox.Show("Seçili olanlar silindi", "sil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //liste();
        }

        private void button2_Click(object sender, EventArgs e) { 
        //{
        //    SqlCommand güncelle = new SqlCommand("update MUSTERILER_tbl set AD=@P1,SOYAD=@P2,TELEFON=@P3,TC=@P4,MAIL=@P5,IL=@P6,ILCE=@P7,ADRES=@P8,VERGI_DAIRE=@P9 where ID=@P10", bgl.baglan());
        //    güncelle.Parameters.AddWithValue("@P1", textBox2.Text);
        //    güncelle.Parameters.AddWithValue("@P2", textBox3.Text);
        //    güncelle.Parameters.AddWithValue("@P3", maskedTextBox1.Text);
        //    güncelle.Parameters.AddWithValue("@P4", maskedTextBox2.Text);
        //    güncelle.Parameters.AddWithValue("@P5", textBox6.Text);
        //    güncelle.Parameters.AddWithValue("@P6", comboBox1.Text);
        //    güncelle.Parameters.AddWithValue("@P7", comboBox2.Text);
        //    güncelle.Parameters.AddWithValue("@P8", richTextBox1.Text);
        //    güncelle.Parameters.AddWithValue("@P9", textBox5.Text);
        //    güncelle.Parameters.AddWithValue("@P10", textBox1.Text);
        //    güncelle.ExecuteNonQuery();
        //    bgl.baglan().Close();
        //    MessageBox.Show("Sistem güncellendi", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    liste();
            //hepsini siliyor bu yuzden verileri göstermek lazım yapılcak 
        }
        SIKAYET_ET SIKAYET;
        musterı_profılı profılı;
        musterıları_gor gt;
        private void button2_Click_1(object sender, EventArgs e)
        {
            //SIKAYET = new SIKAYET_ET();
            //SIKAYET.Show();
            //profılı.Show();
            //gt = new musterıları_gor();
            //gt.Show();
        }
        
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //profılı = new musterı_profılı();
            //textBox2.Text =dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //comboBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //richTextBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //textBox5.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
