using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet2.Ogrenciler' table. You can move, or remove it, as needed.
            this.ogrencilerTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Ogrenciler);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=DateTime.Now.ToLongDateString();
            label2.Text=DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKayit fr=new FrmOgrKayit();
            fr.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrList fr=new FrmOgrList();
            fr.Show();
        }

        private void öğrenciDÜüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrList fr=new FrmOgrList();
            fr.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler frm=new FrmBolumler();
            frm.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler frm = new FrmBolumler();
            frm.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler fr=new FrmOdemeler();
            fr.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGider fr=new FrmGider();
            fr.Show();
        }

        private void gİderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListesi fr=new FrmGiderListesi();
            fr.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirİstatistik fr=new FrmGelirİstatistik();
            fr.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiDuzenle fr=new FrmYoneticiDuzenle();
            fr.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel fr=new FrmPersonel();
            fr.Show();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotEkle fr=new FrmNotEkle();
            fr.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Lamia Kösebey tarafından 23 Eylül 2024'te tamamlanmıştır.","Öğrenci Yurt Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkıiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
