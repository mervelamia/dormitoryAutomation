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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

        public string id, ad, soyad, TC, telefon, dogum, bolum;

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Ogrenci Silme
            SqlCommand komutsil = new SqlCommand("delete from Ogrenciler where Ogrid=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1",txtOgrid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");

            //Odanin Aktif Ogrenci Sayisini Azaltma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        SQLBaglantim bgl = new SQLBaglantim();

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenciler set OgrAd=@p2, OgrSoyad=@p3, OgrTC=@p4, " +
                "OgrTelefon=@p5, OgrDogum=@p6, OgrBolum=@p7, OgrMail=@p8, OgrOdaNo=@p9, OgrVeliAdSoyad=@p10," +
                " OgrVeliTelefon=@p11, OgrVeliAdres=@p12 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgrid.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskTC.Text);
                komut.Parameters.AddWithValue("@p5", mskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", mskDogum.Text);
                komut.Parameters.AddWithValue("@p7", cmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", txtMail.Text);
                komut.Parameters.AddWithValue("@p9", cmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", txtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", mskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", rchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Yeniden Deneyin");
            }
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public string mail, odano, veliad, velitel, adres;

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            txtOgrid.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            mskTC.Text = TC;
            mskOgrTelefon.Text = telefon;
            mskDogum.Text = dogum;
            cmbBolum.Text = bolum;
            txtMail.Text = mail;
            cmbOdaNo.Text = odano;
            txtVeliAdSoyad.Text = veliad;
            mskVeliTelefon.Text = telefon;
            rchAdres.Text = adres;
        }
    }
}
