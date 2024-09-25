namespace YurtKayitSistemi
{
    partial class FrmOgrKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.mskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskDogum = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad :";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrAd.Location = new System.Drawing.Point(173, 33);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(325, 30);
            this.txtOgrAd.TabIndex = 1;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrSoyad.Location = new System.Drawing.Point(173, 69);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(325, 30);
            this.txtOgrSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(124, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC :";
            // 
            // mskTC
            // 
            this.mskTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTC.Location = new System.Drawing.Point(173, 105);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(325, 30);
            this.mskTC.TabIndex = 5;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // mskOgrTelefon
            // 
            this.mskOgrTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskOgrTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskOgrTelefon.Location = new System.Drawing.Point(173, 141);
            this.mskOgrTelefon.Mask = "(999) 000-0000";
            this.mskOgrTelefon.Name = "mskOgrTelefon";
            this.mskOgrTelefon.Size = new System.Drawing.Size(325, 30);
            this.mskOgrTelefon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(86, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon :";
            // 
            // mskDogum
            // 
            this.mskDogum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskDogum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDogum.Location = new System.Drawing.Point(173, 177);
            this.mskDogum.Mask = "00/00/0000";
            this.mskDogum.Name = "mskDogum";
            this.mskDogum.Size = new System.Drawing.Size(325, 30);
            this.mskDogum.TabIndex = 9;
            this.mskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doğum Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci Bölümü :";
            // 
            // cmbBolum
            // 
            this.cmbBolum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(173, 213);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(325, 32);
            this.cmbBolum.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(173, 251);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(325, 30);
            this.txtMail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(111, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mail :";
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbOdaNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Location = new System.Drawing.Point(173, 287);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(325, 32);
            this.cmbOdaNo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(87, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Oda No :";
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(173, 326);
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(325, 30);
            this.txtVeliAdSoyad.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(35, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Veli Ad-Soyad :";
            // 
            // mskVeliTelefon
            // 
            this.mskVeliTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskVeliTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskVeliTelefon.Location = new System.Drawing.Point(173, 362);
            this.mskVeliTelefon.Mask = "(999) 000-0000";
            this.mskVeliTelefon.Name = "mskVeliTelefon";
            this.mskVeliTelefon.Size = new System.Drawing.Size(325, 30);
            this.mskVeliTelefon.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(51, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Veli Telefon :";
            // 
            // rchAdres
            // 
            this.rchAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rchAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchAdres.Location = new System.Drawing.Point(173, 398);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(325, 151);
            this.rchAdres.TabIndex = 20;
            this.rchAdres.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(101, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Adres :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(251, 555);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(178, 36);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 471);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(543, 651);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rchAdres);
            this.Controls.Add(this.mskVeliTelefon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVeliAdSoyad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbOdaNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskDogum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskOgrTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrKayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.MaskedTextBox mskOgrTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskDogum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOdaNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVeliAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskVeliTelefon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label12;
    }
}

