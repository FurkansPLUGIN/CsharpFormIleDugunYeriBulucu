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
    public partial class musterıları_gor : Form
    {
        public musterıları_gor()
        {
            InitializeComponent();
        }
        baglantı_sql bgl = new baglantı_sql();
        musterı_profılı profılı;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //profılı = new musterı_profılı();
            //profılı.textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //profılı.textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //profılı.maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //profılı.maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //profılı.textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //profılı.comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //profılı.comboBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //profılı.richTextBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //profılı.textBox5.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
        void liste()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From MUSTERILER_tbl", bgl.baglan());//tabloyu gösterdi
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from MUSTERILER_tbl where TC=@P1", bgl.baglan());
            sil.Parameters.AddWithValue("@P1", maskedTextBox2.Text);
            sil.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Silme tamamlandı", "SİLME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            liste();
        }

        private void musterıları_gor_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //profılı = new musterı_profılı();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
