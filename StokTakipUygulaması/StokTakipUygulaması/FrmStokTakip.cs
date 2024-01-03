using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipUygulaması
{
    public partial class FrmStokTakip : Form
    {
        public FrmStokTakip()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();

        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Urun", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            if (!string.IsNullOrEmpty(TxtAd.Text))
            {
                conn.Open();

                SqlCommand komut = new SqlCommand("Select * From Tbl_Urun Where UrunAd Like @p1", conn);
                komut.Parameters.AddWithValue("@p1", "%" + TxtAd.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Arama metni boş olamaz.");
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void FrmStokTakip_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Urun", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
