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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace StokTakipUygulaması
{
    public partial class FrmStokGiriş : Form
    {
        public FrmStokGiriş()
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

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);

            string regexPattern = "^[0-9]+$";

            if (string.IsNullOrEmpty(TxtAdet.Text))
            {
                MessageBox.Show("Ürün Adedi Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Regex.IsMatch(TxtAdet.Text, regexPattern))
            {
                Console.WriteLine("Metin yalnızca rakamları içeriyor.");
            }
            else
            {
                Console.WriteLine("Metin rakam dışında karakterler içeriyor.");
                MessageBox.Show("Sadece Rakam Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                conn.Open();
                SqlCommand komut = new SqlCommand("Select UrunStok From Tbl_Urun Where Urunid=@p1", conn);
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                object mevcutStok = komut.ExecuteScalar();

                int yeniStok = 0; 
                if (mevcutStok != DBNull.Value)
                {
                    yeniStok = Convert.ToInt32(mevcutStok) + int.Parse(TxtAdet.Text);
                }

                SqlCommand komu2 = new SqlCommand("Update Tbl_Urun Set UrunStok=@p1 Where Urunid=@p2", conn);
                komu2.Parameters.AddWithValue("@p1", yeniStok);
                komu2.Parameters.AddWithValue("@p2", Txtid.Text);
                komu2.ExecuteNonQuery();

                MessageBox.Show("Stok Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);

            if (!string.IsNullOrEmpty(TxtAd.Text))
            {
                conn.Open();

                SqlCommand komut = new SqlCommand("Select * From Tbl_Urun Where UrunAd Like @p1", conn);
                komut.Parameters.AddWithValue("@p1","%" + TxtAd.Text + "%");

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
    }
}

