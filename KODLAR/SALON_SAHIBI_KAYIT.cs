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
    public partial class SALON_SAHIBI_KAYIT : Form
    {
        public SALON_SAHIBI_KAYIT()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        baglantı_sql bgl = new baglantı_sql();
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
        Form1 fr;
        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlCommand ekle = new SqlCommand("INSERT into KAYIT_SALON_SAHIBI (ISIM,SOYISIM,IL,ILCE,MAIL,TELEFON,SALON_ISIM) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7)", bgl.baglan());
            ekle.Parameters.AddWithValue("@P1", textBox1.Text);
            ekle.Parameters.AddWithValue("@P2", textBox2.Text);
            ekle.Parameters.AddWithValue("@P3", comboBox1.Text);
            ekle.Parameters.AddWithValue("@P4", comboBox2.Text);
            ekle.Parameters.AddWithValue("@P5", textBox3.Text);
            ekle.Parameters.AddWithValue("@P6", textBox4.Text);
            ekle.Parameters.AddWithValue("@P7", textBox5.Text);
           
            ekle.ExecuteNonQuery();
            bgl.baglan().Close();

            //SqlCommand giriş = new SqlCommand("Select * From KAYIT_SALON_SAHIBI where ISIM=@P1 and SOYISIM=@P2 and IL=@P3 and ILCE=@P4 and MAIL=@P5 and TELEFON=@P6 and SALON_ISIM=@P7 and SIFRE=@P8 and KULLANICI_ADI=@P9 ", bgl.baglan());
            //giriş.Parameters.AddWithValue("@P1", textBox1.Text);
            //giriş.Parameters.AddWithValue("@P2", textBox2.Text);
            //giriş.Parameters.AddWithValue("@P3", comboBox1.Text);
            //giriş.Parameters.AddWithValue("@P4", comboBox2.Text);
            //giriş.Parameters.AddWithValue("@P5", textBox3.Text);
            //giriş.Parameters.AddWithValue("@P6", textBox4.Text);
            //giriş.Parameters.AddWithValue("@P7", textBox5.Text);
            //giriş.Parameters.AddWithValue("@P8", textBox6.Text);
            //giriş.Parameters.AddWithValue("@P9", textBox7.Text);
            //SqlDataReader oku = giriş.ExecuteReader();
            //if (oku.Read())
            //{
            //    Form2 form2 = new Form2();
            //    form2.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    label4.Text = "Girdiğiniz Bilgilerin Doğru Olduğuna Emin Olun";
            //}
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == ""&&comboBox1.Text==""&&comboBox2.Text=="") 
            {
                label10.Text = "BOŞ YER BİRAKMAYIN";
            }
            else
            {
                Form2 form = new Form2();
                form.Show();
                MessageBox.Show("AYARLAR KISMINDAN ADMINLERİ BELİRLEYİN", "1)DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("ANA SAYFA MODÜLÜNE TIKLAYARAK SALONUNUZU OLUŞTURMAYA BAŞLAYABİLİRSİNİZ", "2)DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SALON_SAHIBI_KAYIT_Load(object sender, EventArgs e)
        {
            sehirler();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        salon_ekle_cıkar ekcık;
        //void liste1()
        //{
        //    ekcık = new salon_ekle_cıkar();
        //    DataTable table = new DataTable();
        //    SqlDataAdapter adapter = new SqlDataAdapter("Select * From KAYIT_SALON_SAHIBI", bgl.baglan());//tabloyu gösterdi
        //    adapter.Fill(table);
        //    ekcık.dataGridView1.DataSource = table;
        //}
    }
}
