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
    public partial class onerı : Form
    {
        public onerı()
        {
            InitializeComponent();
        }
        baglantı_sql bgl = new baglantı_sql();
        private void button1_Click(object sender, EventArgs e)
        {

        }
        onerileri_gor gor;
        void liste()
        {
           // gor = new onerileri_gor();
           // DataTable table = new DataTable();
           // SqlDataAdapter adapter = new SqlDataAdapter("Select * From BANA_ONERI", bgl.baglan());//tabloyu gösterdi
           // adapter.Fill(table);
           //gor.dataGridView1.DataSource = table;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand gonder = new SqlCommand("INSERT into BANA_ONERI (ONERI) values (@P1)", bgl.baglan());
            gonder.Parameters.AddWithValue("@P1", richTextBox2.Text);
            gonder.ExecuteNonQuery();
            bgl.baglan().Close();
            liste();
            gor = new onerileri_gor();
            gor.Show();
        }

        private void onerı_Load(object sender, EventArgs e)
        {
            liste();
        }
    }
}
