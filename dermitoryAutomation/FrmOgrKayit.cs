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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        SQLBaglantim bgl = new SQLBaglantim();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bölümleri Lİsteleme Komutları
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //Boş Odaları Listeleme Komutlatı

            SqlCommand komut2 = new SqlCommand("Select Odano From Odalar where OdaKapasite !=OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

      

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenciler (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) output INSERTED.Ogrid values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", txtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", mskTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", mskOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", mskDogum.Text);
                komutkaydet.Parameters.AddWithValue("@p6", cmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txtMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", txtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", mskVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", rchAdres.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi");


                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenciler", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();

                //Ögrenci Borc Alanı Olusturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values (@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", txtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();

            }
            catch (Exception)
            {
                MessageBox.Show("HATA! Lütfen yeniden deneyin");
            }


            //Ogrenci Oda Kontenjani Arttirma

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}