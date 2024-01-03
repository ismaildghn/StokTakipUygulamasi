using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUrunEkle fr = new FrmUrunEkle();
            fr.Show();
            this.Hide();
        }

        private void BtnStokGiriş_Click(object sender, EventArgs e)
        {
            FrmStokGiriş fr = new FrmStokGiriş();
            fr.Show();
            this.Hide();
        }

        private void BtnStokÇıkış_Click(object sender, EventArgs e)
        {
            FrmStokCikis fr = new FrmStokCikis();
            fr.Show();
            this.Hide();
        }

        private void BtnStokTakip_Click(object sender, EventArgs e)
        {
            FrmStokTakip fr = new FrmStokTakip();
            fr.Show();
            this.Hide();
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
