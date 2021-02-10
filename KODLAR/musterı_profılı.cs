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
    public partial class musterı_profılı : Form
    {
        public musterı_profılı()
        {
            InitializeComponent();
        }

        private void musterı_profılı_Load(object sender, EventArgs e)
        {
            sehirler();
        }
        baglantı_sql bgl = new baglantı_sql();
        musterıler_frm musu;
        musterıları_gor gor;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("INSERT into MUSTERILER_tbl (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,VERGI_DAIRE) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgl.baglan());
            ekle.Parameters.AddWithValue("@P1", textBox2.Text);
            ekle.Parameters.AddWithValue("@P2", textBox3.Text);
            ekle.Parameters.AddWithValue("@P3", maskedTextBox1.Text);
            ekle.Parameters.AddWithValue("@P4", maskedTextBox2.Text);
            ekle.Parameters.AddWithValue("@P5", textBox6.Text);
            ekle.Parameters.AddWithValue("@P6", comboBox1.Text);
            ekle.Parameters.AddWithValue("@P7", comboBox2.Text);
            ekle.Parameters.AddWithValue("@P8", richTextBox1.Text);
            ekle.Parameters.AddWithValue("@P9", textBox5.Text);
            ekle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Sisteme eklendi", "EKLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            musu = new musterıler_frm();
            musu.Show();
            gor = new musterıları_gor();
            gor.Show();
            
        }
        void liste()
        {
            musu = new musterıler_frm();
            gor = new musterıları_gor();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From MUSTERILER_tbl", bgl.baglan());//tabloyu gösterdi
            adapter.Fill(table);
            musu.dataGridView1.DataSource = table;
            gor.dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand güncelle = new SqlCommand("update MUSTERILER_tbl set AD=@P1,SOYAD=@P2,TELEFON=@P3,TC=@P4,MAIL=@P5,IL=@P6,ILCE=@P7,ADRES=@P8,VERGI_DAIRE=@P9 where AD=@P1", bgl.baglan());
            güncelle.Parameters.AddWithValue("@P1", textBox2.Text);
            güncelle.Parameters.AddWithValue("@P2", textBox3.Text);
            güncelle.Parameters.AddWithValue("@P3", maskedTextBox1.Text);
            güncelle.Parameters.AddWithValue("@P4", maskedTextBox2.Text);
            güncelle.Parameters.AddWithValue("@P5", textBox6.Text);
            güncelle.Parameters.AddWithValue("@P6", comboBox1.Text);
            güncelle.Parameters.AddWithValue("@P7", comboBox2.Text);
            güncelle.Parameters.AddWithValue("@P8", richTextBox1.Text);
            güncelle.Parameters.AddWithValue("@P9", textBox5.Text);
           
            güncelle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Sistem güncellendi", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            musu = new musterıler_frm();
            musu.Show();
            gor = new musterıları_gor();
            gor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("DELETE from MUSTERILER_tbl where AD=@P1", bgl.baglan());
            sil.Parameters.AddWithValue("@P1", textBox2.Text);
            sil.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Seçili olanlar silindi", "sil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            musu = new musterıler_frm();
            musu.Show();
            gor = new musterıları_gor();
            gor.Show();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();//başka sehirdeki ilçelerin üst üste gelmesini engelliyor
            SqlCommand com = new SqlCommand("Select ilce From ilceler where sehir=@p1", bgl.baglan());
            com.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex + 1);//to string de kullanılabir sectiğim indeks i bir artırarak oku[0] a eşitlemis oldum
            SqlDataReader oku = com.ExecuteReader();
            while (oku.Read())
            {
                comboBox2.Items.Add(oku[0]);
            }
            bgl.baglan().Close();
        }
    }
}
