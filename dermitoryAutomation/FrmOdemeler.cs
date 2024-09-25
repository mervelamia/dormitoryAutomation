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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        SQLBaglantim bgl=new SQLBaglantim();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet3.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen=dataGridView1.SelectedCells[0].RowIndex;
            id=dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtKalan.Text = kalan;
            txtOgrid.Text = id;
            
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            //Ödenen Tutarı Kalan Tutardan Düşme İşlemi
            int odenen, kalan, yeniborc;
            odenen=Convert.ToInt16(txtOdenen.Text);
            kalan=Convert.ToInt16(txtKalan.Text);
            yeniborc = kalan - odenen;
            txtKalan.Text=yeniborc.ToString();

            //Yeni Tutarı Veri Tabanına Ekleme
            SqlCommand komut=new SqlCommand("update Borclar set OgrKalanBorc=@p1 where Ogrid=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtOgrid.Text);
            komut.Parameters.AddWithValue("@p1", txtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi");
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Borclar);

            //Kasa tablosuna ekleme yapma
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktari) values (@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1",txtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2",txtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

        }
    }
}
