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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        baglantı_sql bgl = new baglantı_sql();
        private void button1_Click(object sender, EventArgs e)
        {

            button1.BackColor = Color.Brown;
            SqlCommand giriş = new SqlCommand("Select * From ADMIN_tbl where KULLANICI_AD=@P1 and SİFRE=@P2", bgl.baglan());
            giriş.Parameters.AddWithValue("@P1", textBox1.Text);
            giriş.Parameters.AddWithValue("@P2", textBox2.Text);
            SqlDataReader oku = giriş.ExecuteReader();
            if (oku.Read())
            {
                YAPIMCI yap = new YAPIMCI();
                yap.Show();
                MessageBox.Show("İNCELEME SAYFASI OLMASININ EN BÜYÜK SEBEBİ GÜVENLİK VE DAHA İYİ HİZMET BU SESPTEN ÖTÜRÜ İNCELEME ADI OLARAK EKLENMİŞTİR", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
            }
            else
            {
                label4.Text = "Girdiğiniz Bilgilerin Doğru Olduğuna Emin Olun";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkSalmon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
