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
    public partial class bankalar_frm : Form
    {
        public bankalar_frm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        baglantı_sql bgl = new baglantı_sql();
        void liste()
        {
           
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Execute BANKA_BILGILERI", bgl.baglan());//tabloyu gösterdi
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
      

        private void bankalar_frm_Load(object sender, EventArgs e)
        {
            liste();
            sehirler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("INSERT into BANKA_tbl(BANKA_AD,SUBE,IBAN,HESAP_NO,YETKILI,TARIH,HESAP_TUR,IL,ILCE,TELEFON_1,MUSTERI_TC) values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11)", bgl.baglan());
            ekle.Parameters.AddWithValue("@P1", textBox4.Text);
            ekle.Parameters.AddWithValue("@P2", textBox3.Text);
            ekle.Parameters.AddWithValue("@P3", textBox2.Text);
            ekle.Parameters.AddWithValue("@P4", textBox7.Text);
            ekle.Parameters.AddWithValue("@P5", textBox6.Text);
            ekle.Parameters.AddWithValue("@P6", textBox5.Text);
            ekle.Parameters.AddWithValue("@P7", textBox8.Text);
            ekle.Parameters.AddWithValue("@P8", comboBox2.Text);
            ekle.Parameters.AddWithValue("@P9", comboBox1.Text);
            ekle.Parameters.AddWithValue("@P10", textBox10.Text);
            ekle.Parameters.AddWithValue("@P11", textBox9.Text);
            ekle.ExecuteNonQuery();
            
            bgl.baglan().Close();
            liste();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("DELETE from BANKA_tbl where ID=@P1", bgl.baglan());
            sil.Parameters.AddWithValue("@P1", textBox1.Text);
            sil.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Seçili olanlar silindi", "sil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand gümcelle = new SqlCommand("UPDATE BANKA_tbl SET @P1=BANKA_AD,@P2=SUBE,@P3=IBAN,@P4=HESAP_NO,@P5=YETKILI,@P6=TARIH,@P7=HESAP_TUR,@P8=IL,@P9=ILCE,@P10=TELEFON_1,@P11=MUSTERI_TC WHERE ID=@P12", bgl.baglan());
            gümcelle.Parameters.AddWithValue("@P1", textBox4.Text);
            gümcelle.Parameters.AddWithValue("@P2", textBox3.Text);
            gümcelle.Parameters.AddWithValue("@P3", textBox2.Text);
            gümcelle.Parameters.AddWithValue("@P4", textBox7.Text);
            gümcelle.Parameters.AddWithValue("@P5", textBox6.Text);
            gümcelle.Parameters.AddWithValue("@P6", textBox5.Text);
            gümcelle.Parameters.AddWithValue("@P7", textBox8.Text);
            gümcelle.Parameters.AddWithValue("@P8", comboBox2.Text);
            gümcelle.Parameters.AddWithValue("@P9", comboBox1.Text);
            gümcelle.Parameters.AddWithValue("@P10", textBox10.Text);
            gümcelle.Parameters.AddWithValue("@P11", textBox9.Text);
            gümcelle.Parameters.AddWithValue("@P12", textBox1.Text);
            gümcelle.ExecuteNonQuery();
            
            bgl.baglan().Close();
            liste();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
           
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
