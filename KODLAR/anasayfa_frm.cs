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
    public partial class anasayfa_frm : Form
    {
        public anasayfa_frm()
        {
            InitializeComponent();
        }
        baglantı_sql bgl = new baglantı_sql();
        private void anasayfa_frm_Load(object sender, EventArgs e)
        {
            liste();
            liste1();
        }
        void liste1()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From kullanıcı_için", bgl.baglan());//tabloyu gösterdi
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }
        void liste()
        {
            
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From SALON_ICI", bgl.baglan());//tabloyu gösterdi
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        void temizle()
        {
            textBox8.Text = " ";
            textBox5.Text = " ";
            textBox1.Text = " ";
            textBox4.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox2.Text = " ";
        }
      
        

        SALONLARIN_İÇİ saloniç;
        kullanici_icin kula;
      
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("Insert into SALON_ICI (SALON_ISIM,ADRES,FIYAT,SIRA_TARIH,EKSTRALAR,BILGILER,KAPASITE) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7)", bgl.baglan());
            kaydet.Parameters.AddWithValue("@P1", textBox8.Text);
            kaydet.Parameters.AddWithValue("@P2", textBox5.Text);
            kaydet.Parameters.AddWithValue("@P3", textBox1.Text);
            kaydet.Parameters.AddWithValue("@P4", textBox4.Text);
            kaydet.Parameters.AddWithValue("@P5", textBox6.Text);
            kaydet.Parameters.AddWithValue("@P6", textBox7.Text);
            kaydet.Parameters.AddWithValue("@P7", textBox2.Text);
            kaydet.ExecuteNonQuery();
           
            //bgl.baglan().Close();
            //salon = new salon_table();
            //salon.Show();

            kula = new kullanici_icin();

            saloniç = new SALONLARIN_İÇİ();
            //saloniç.label12.Text = textBox8.Text;
            //saloniç.label14.Text = textBox1.Text;
            //saloniç.label16.Text = textBox5.Text;
            //saloniç.label17.Text = textBox4.Text;
            //saloniç.label19.Text = textBox6.Text;
            //saloniç.label20.Text = textBox7.Text;
            //saloniç.label18.Text = textBox2.Text;
            //saloniç.Show(this);

            SqlCommand sql = new SqlCommand("Select * From SALON_ICI", bgl.baglan());
           
            SqlDataReader read = sql.ExecuteReader();
            if (read.Read())
            {
                kula.label5.Text = read["FIYAT"].ToString();
                kula.label3.Text = read["ADRES"].ToString();
                kula.button4.Text = read["SALON_ISIM"].ToString();
                saloniç.label12.Text = read["SALON_ISIM"].ToString();
                saloniç.label14.Text = read["FIYAT"].ToString();
                saloniç.label15.Text = read["FIYAT"].ToString();
                saloniç.label16.Text = read["ADRES"].ToString();
                saloniç.label17.Text = read["SIRA_TARIH"].ToString();
                saloniç.label18.Text = read["KAPASITE"].ToString();
                saloniç.label19.Text = read["EKSTRALAR"].ToString();
                saloniç.label20.Text = read["BILGILER"].ToString();
                label9.Text = read["SALON_ISIM"].ToString();
            }

            bgl.baglan().Close();
            kula.Show();
            saloniç.pictureBox3.Image = pictureBox3.Image;
            saloniç.pictureBox4.Image = pictureBox4.Image;
            saloniç.pictureBox5.Image = pictureBox5.Image;
            saloniç.pictureBox6.Image = pictureBox6.Image;
            saloniç.pictureBox7.Image = pictureBox7.Image;
            saloniç.pictureBox8.Image = pictureBox8.Image;
            saloniç.pictureBox1.Image = pictureBox1.Image;
            saloniç.pictureBox2.Image = pictureBox2.Image;
            saloniç.Show(this);

            liste();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
            //bgl.baglan().Open();
            //güncelle.Connection = bgl.baglan();
            //güncelle.CommandText = "update SALON_ICI set SALON_ISIM='" + textBox8.Text + "' ,ADRES='" + textBox5.Text + "',FIYAT='" + int.Parse(textBox1.Text) + "',SIRA_TARIH='" + textBox4.Text + "',EKSTRALAR='" + textBox6.Text + "',BILGILER='" + textBox7.Text + "',KAPASITE='" + textBox2.Text + "' Where SALON_ISIM=@P1";
            //güncelle.Parameters.AddWithValue("@P1", aaa.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            SqlCommand güncelle = new SqlCommand("update  SALON_ICI set SALON_ISIM=@P1,ADRES=@P2,FIYAT=@P3,SIRA_TARIH=@P4,EKSTRALAR=@P5,BILGILER=@P6,KAPASITE=@P7 where SALON_ISIM=@P1", bgl.baglan());
            güncelle.Parameters.AddWithValue("@P1", textBox8.Text);
            güncelle.Parameters.AddWithValue("@P2", textBox5.Text);
            güncelle.Parameters.AddWithValue("@P3", textBox1.Text);
            güncelle.Parameters.AddWithValue("@P4", textBox4.Text);
            güncelle.Parameters.AddWithValue("@P5", textBox6.Text);
            güncelle.Parameters.AddWithValue("@P6", textBox7.Text);
            güncelle.Parameters.AddWithValue("@P7", textBox2.Text);
            güncelle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Sistem güncellendi", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste();
            temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from SALON_ICI where SALON_ISIM=@P1", bgl.baglan());
            sil.Parameters.AddWithValue("@P1", textBox8.Text);
            sil.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Silme tamamlandı", "SİLME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste();
            temizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox3.ImageLocation = openFileDialog1.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            openFileDialog2.ShowDialog();
            pictureBox6.ImageLocation = openFileDialog2.FileName;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
            pictureBox8.ImageLocation = openFileDialog3.FileName;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            openFileDialog4.ShowDialog();
            pictureBox4.ImageLocation = openFileDialog4.FileName;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            openFileDialog5.ShowDialog();
            pictureBox5.ImageLocation = openFileDialog5.FileName;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            openFileDialog6.ShowDialog();
            pictureBox7.ImageLocation = openFileDialog6.FileName;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openFileDialog7.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog7.FileName;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openFileDialog8.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog8.FileName;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
            textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
