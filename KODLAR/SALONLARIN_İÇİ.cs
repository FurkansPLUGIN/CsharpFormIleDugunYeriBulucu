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
    public partial class SALONLARIN_İÇİ : Form
    {
        public SALONLARIN_İÇİ()
        {
            InitializeComponent();
        }
        baglantı_sql bgl = new baglantı_sql();
        private void label7_Click(object sender, EventArgs e)
        {

        }
        anasayfa_frm fgh;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand gonder = new SqlCommand("Insert into kullanıcı_için (ILETISIM,YORUM) values (@P1,@P2)", bgl.baglan());
            gonder.Parameters.AddWithValue("@P1", richTextBox2.Text);
            gonder.Parameters.AddWithValue("@P2", richTextBox1.Text);
          
            gonder.ExecuteNonQuery();
            bgl.baglan().Close();
            
           
            
            
        }
        

        private void SALONLARIN_İÇİ_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        SIKAYET_ET SIKAYETT;

        private void button2_Click(object sender, EventArgs e)
        {
            SIKAYETT = new SIKAYET_ET();
            SIKAYETT.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
