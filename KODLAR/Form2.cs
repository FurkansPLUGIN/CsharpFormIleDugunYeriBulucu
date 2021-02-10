using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Otomasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        musterıler_frm goster;
        personeller_frm göster;
        bankalar_frm görün;
        ayar_frm ayar;
        faturalar_tbl fatur;
        anasayfa_frm ana;
        

        private void mÜŞTERİLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //göster = new personeller_frm();
            //göster.Close();

            //görün = new bankalar_frm();
            //görün.Close();

            //ayar = new ayar_frm();
            //ayar.Close();

            //fatur = new faturalar_tbl();
            //fatur.Close();

            //ana = new anasayfa_frm();
            //ana.Close();

            goster = new musterıler_frm();
            panel1.Controls.Clear();
            IsMdiContainer = true;
            goster.MdiParent = this;
            goster.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(goster);
            goster.Show();
 
        }
       
        private void pERSONELLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            //görün = new bankalar_frm();
            //görün.Close();

            //ayar = new ayar_frm();
            //ayar.Close();

            //fatur = new faturalar_tbl();
            //fatur.Close();

            //ana = new anasayfa_frm();
            //ana.Close();

            //goster = new musterıler_frm();
            //goster.Close();
            
            göster = new personeller_frm();
            panel1.Controls.Clear();
            IsMdiContainer = true;
            göster.MdiParent = this;
            göster.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(goster);
            göster.Show();
           

        }
       
        private void bANKAToolStripMenuItem_Click(object sender, EventArgs e)
        {



            
            görün = new bankalar_frm();
            panel1.Controls.Clear();
            IsMdiContainer = true;
            görün.MdiParent = this;
            görün.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(görün);
            görün.Show();
           
        }
        //stok_frm gör;
        private void sTOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (gör == null)
            //{
            //    gör = new stok_frm();
            //    gör.Show();
            //}
        }
       
        private void aYARLARToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            ayar = new ayar_frm();
            panel1.Controls.Clear();
            IsMdiContainer = true;
            ayar.MdiParent = this;
            ayar.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(ayar);
            ayar.Show();
          
        }
      
        private void fATURAToolStripMenuItem_Click(object sender, EventArgs e)
        {


           
            fatur = new faturalar_tbl();
            panel1.Controls.Clear();
            IsMdiContainer = true;
            fatur.MdiParent = this;
            fatur.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(fatur);
           
            fatur.Show();
            
        }
        //haraketler_frm haraket;
        private void hARAKETLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (haraket == null)
            //{
            //    haraket = new haraketler_frm();
            //    haraket.Show();
            //}
        }
        
        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            ana = new anasayfa_frm();
            panel1.Controls.Clear();
            IsMdiContainer = true;
            ana.MdiParent = this;
            ana.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(ana);
            
            ana.Show();
            
            
        }
        //salon_table salon;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //salon = new salon_table();
            //salon.Show();
        }

        private void kASAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
