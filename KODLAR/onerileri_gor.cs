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
    public partial class onerileri_gor : Form
    {
        public onerileri_gor()
        {
            InitializeComponent();
        }
        baglantı_sql bgl = new baglantı_sql();
        //gor = new onerileri_gor();
       void liste()
        {
            DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter("Select * From BANA_ONERI", bgl.baglan());//tabloyu gösterdi
        adapter.Fill(table);
        dataGridView1.DataSource = table;
        }
        private void onerileri_gor_Load(object sender, EventArgs e)
        {
            liste();
        }

    }
}
