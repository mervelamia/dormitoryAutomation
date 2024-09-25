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

namespace YurtKayitSistemi
{
    public partial class FrmYoneticiDuzenle : Form
    {
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
        }
        SQLBaglantim bgl=new SQLBaglantim();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet6.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Admin);

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtKullaniciAd.Text = ad;
            txtSifre.Text = sifre;
            txtYoneticiid.Text = id;
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into Admin (YoneticiAd, YoneticiSifre) values(@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Eklendi");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Admin);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete From Admin where Yoneticiid=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtYoneticiid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Admin);
        }

       
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update admin set YoneticiAd=@p1, YoneticiSifre=@p2 where Yoneticiid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            komut.Parameters.AddWithValue("@p3", txtYoneticiid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Gerçekleşti");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Admin);
        }
    }
}
