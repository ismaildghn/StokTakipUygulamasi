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
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
     
        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Urun", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;         
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);  

            bool isValid = Regex1.IsAlphanumeric(TxtAd.Text);

            if (isValid)
            {
                Console.WriteLine("Giriş geçerlidir.");
            }
            else
            {
                Console.WriteLine("Giriş geçerli değil.");
                MessageBox.Show("Ürün Adı harf rakam ve (-) içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtAd.Text))
            {
                MessageBox.Show("Ürün Adı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            conn.Open();
            SqlCommand komut = new SqlCommand("Insert Into Tbl_Urun (UrunAd, UrunStok) Values (@p1, 0)", conn);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);

            bool isValid = Regex1.IsAlphanumeric(TxtAd.Text);

            if (isValid)
            {
                Console.WriteLine("Giriş geçerlidir.");
            }
            else
            {
                Console.WriteLine("Giriş geçerli değil.");
                MessageBox.Show("Ürün Adı sadece harf ve rakam içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TxtAd.Text))
            {
                MessageBox.Show("Ürün Adı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); return;
            }
            conn.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Urun Set UrunAd=@p1 where Urunid=@p2",conn);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", Txtid.Text);
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün Güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);

            conn.Open();
            SqlCommand komut = new SqlCommand("Delete From Tbl_Urun Where Urunid=@p1",conn);
            komut.Parameters.AddWithValue("@p1", Txtid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
