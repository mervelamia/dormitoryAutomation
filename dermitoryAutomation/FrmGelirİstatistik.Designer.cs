﻿namespace YurtKayitSistemi
{
    partial class FrmGelirİstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirİstatistik));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.lblAy = new System.Windows.Forms.Label();
            this.lblAyKazanc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(414, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasadaki Para :";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPara.Location = new System.Drawing.Point(577, 30);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(23, 21);
            this.lblPara.TabIndex = 1;
            this.lblPara.Text = "0";
            // 
            // cmbAy
            // 
            this.cmbAy.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Location = new System.Drawing.Point(132, 27);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(243, 29);
            this.cmbAy.TabIndex = 2;
            this.cmbAy.SelectedIndexChanged += new System.EventHandler(this.cmbAy_SelectedIndexChanged);
            // 
            // lblAy
            // 
            this.lblAy.AutoSize = true;
            this.lblAy.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAy.Location = new System.Drawing.Point(27, 30);
            this.lblAy.Name = "lblAy";
            this.lblAy.Size = new System.Drawing.Size(90, 21);
            this.lblAy.TabIndex = 3;
            this.lblAy.Text = "Ay Girin  :";
            // 
            // lblAyKazanc
            // 
            this.lblAyKazanc.AutoSize = true;
            this.lblAyKazanc.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAyKazanc.Location = new System.Drawing.Point(577, 63);
            this.lblAyKazanc.Name = "lblAyKazanc";
            this.lblAyKazanc.Size = new System.Drawing.Size(23, 21);
            this.lblAyKazanc.TabIndex = 5;
            this.lblAyKazanc.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(448, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seçilen Ay  :";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 121);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylık";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(660, 317);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // FrmGelirİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblAyKazanc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAy);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGelirİstatistik";
            this.Text = "Gelir İstatistik";
            this.Load += new System.EventHandler(this.FrmGelirİstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.Label lblAy;
        private System.Windows.Forms.Label lblAyKazanc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}