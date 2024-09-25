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
    public partial class FrmGelirİstatistik : Form
    {
        public FrmGelirİstatistik()
        {
            InitializeComponent();
        }
        SQLBaglantim bgl = new SQLBaglantim();
        private void FrmGelirİstatistik_Load(object sender, EventArgs e)
        {
            //Kasadaki toplam tutar
            SqlCommand komut = new SqlCommand("Select sum(OdemeMiktari) From Kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblPara.Text = oku[0].ToString() + " TL ";
            }
            bgl.baglanti().Close();

            //Tekrarsız olarak ayları listeleme
            SqlCommand komut2 = new SqlCommand("Select distinct(OdemeAy) from Kasa",bgl.baglanti());
            SqlDataReader oku2=komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbAy.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            /*Aylık Kazanç Manuel Girme
            this.chart1.Series["Aylık"].Points.AddXY("Nisan",15);
            this.chart1.Series["Aylık"].Points.AddXY("Nisan", 22);
            this.chart1.Series["Aylık"].Points.AddXY("Nisan", 13);*/

            //Grafiklere veri tabanından veri çekme
            SqlCommand komut3 = new SqlCommand("select OdemeAy, sum(OdemeMiktari) from kasa group by OdemeAy", bgl.baglanti());
            SqlDataReader oku3=komut3.ExecuteReader();
            while(oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktari) From Kasa where OdemeAy=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",cmbAy.Text);
            SqlDataReader oku= komut.ExecuteReader();
            while(oku.Read())
            {
                lblAyKazanc.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
