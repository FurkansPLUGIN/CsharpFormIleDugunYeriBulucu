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
    public partial class SIKAYET : Form
    {
        public SIKAYET()
        {
            InitializeComponent();
        }
        baglantı_sql bgl = new baglantı_sql();
        void liste()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From SIKAYETLER", bgl.baglan());//tabloyu gösterdi
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void SIKAYET_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
