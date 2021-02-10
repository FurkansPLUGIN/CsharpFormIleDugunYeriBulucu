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
    public partial class SIKAYET_ET : Form
    {
        public SIKAYET_ET()
        {
            InitializeComponent();
        }
        baglantı_sql bgl = new baglantı_sql();
        private void SIKAYET_ET_Load(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
        YAPIMCI yap;
        SIKAYET sıkayet;
        private void button10_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("Insert into SIKAYETLER (EDILEN_SIKAYET) values (@P1)", bgl.baglan());
            ekle.Parameters.AddWithValue("@P1", richTextBox1.Text);
            ekle.ExecuteNonQuery();
            bgl.baglan().Close();
            sıkayet = new SIKAYET();
            sıkayet.Show();
        }
    }
}
