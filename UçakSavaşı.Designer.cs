
namespace Uçak_Savaşı_Oyunu
{
    partial class UçakSavaşı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBitir = new System.Windows.Forms.Button();
            this.btnBaşlat = new System.Windows.Forms.Button();
            this.radZor = new System.Windows.Forms.RadioButton();
            this.radOrta = new System.Windows.Forms.RadioButton();
            this.radKolay = new System.Windows.Forms.RadioButton();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Uçak = new System.Windows.Forms.PictureBox();
            this.OyunAlanı = new System.Windows.Forms.Panel();
            this.lblDurum = new System.Windows.Forms.Label();
            this.P_Patlama = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Uçak)).BeginInit();
            this.OyunAlanı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_Patlama)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.btnBitir);
            this.panel1.Controls.Add(this.btnBaşlat);
            this.panel1.Controls.Add(this.radZor);
            this.panel1.Controls.Add(this.radOrta);
            this.panel1.Controls.Add(this.radKolay);
            this.panel1.Controls.Add(this.lblPuan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 49);
            this.panel1.TabIndex = 0;
            // 
            // btnBitir
            // 
            this.btnBitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitir.Location = new System.Drawing.Point(533, 16);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(84, 25);
            this.btnBitir.TabIndex = 6;
            this.btnBitir.Text = "Bitir(S)";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnBaşlat
            // 
            this.btnBaşlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaşlat.Location = new System.Drawing.Point(443, 16);
            this.btnBaşlat.Name = "btnBaşlat";
            this.btnBaşlat.Size = new System.Drawing.Size(84, 25);
            this.btnBaşlat.TabIndex = 5;
            this.btnBaşlat.Text = "Başlat(Enter)";
            this.btnBaşlat.UseVisualStyleBackColor = true;
            this.btnBaşlat.Click += new System.EventHandler(this.btnBaşlat_Click);
            // 
            // radZor
            // 
            this.radZor.AutoSize = true;
            this.radZor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radZor.Location = new System.Drawing.Point(397, 20);
            this.radZor.Name = "radZor";
            this.radZor.Size = new System.Drawing.Size(40, 17);
            this.radZor.TabIndex = 4;
            this.radZor.TabStop = true;
            this.radZor.Text = "Zor";
            this.radZor.UseVisualStyleBackColor = true;
            // 
            // radOrta
            // 
            this.radOrta.AutoSize = true;
            this.radOrta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radOrta.Location = new System.Drawing.Point(347, 20);
            this.radOrta.Name = "radOrta";
            this.radOrta.Size = new System.Drawing.Size(44, 17);
            this.radOrta.TabIndex = 3;
            this.radOrta.TabStop = true;
            this.radOrta.Text = "Orta";
            this.radOrta.UseVisualStyleBackColor = true;
            // 
            // radKolay
            // 
            this.radKolay.AutoSize = true;
            this.radKolay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radKolay.Location = new System.Drawing.Point(291, 20);
            this.radKolay.Name = "radKolay";
            this.radKolay.Size = new System.Drawing.Size(50, 17);
            this.radKolay.TabIndex = 2;
            this.radKolay.TabStop = true;
            this.radKolay.Text = "Kolay";
            this.radKolay.UseVisualStyleBackColor = true;
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(109, 9);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(28, 29);
            this.lblPuan.TabIndex = 1;
            this.lblPuan.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PUAN:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Cyan;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(41, 688);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Uçak
            // 
            this.Uçak.Image = global::Uçak_Savaşı_Oyunu.Properties.Resources.Uçak;
            this.Uçak.Location = new System.Drawing.Point(250, 586);
            this.Uçak.Name = "Uçak";
            this.Uçak.Size = new System.Drawing.Size(104, 90);
            this.Uçak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Uçak.TabIndex = 0;
            this.Uçak.TabStop = false;
            // 
            // OyunAlanı
            // 
            this.OyunAlanı.Controls.Add(this.P_Patlama);
            this.OyunAlanı.Controls.Add(this.lblDurum);
            this.OyunAlanı.Controls.Add(this.Uçak);
            this.OyunAlanı.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OyunAlanı.Location = new System.Drawing.Point(41, 49);
            this.OyunAlanı.Name = "OyunAlanı";
            this.OyunAlanı.Size = new System.Drawing.Size(588, 688);
            this.OyunAlanı.TabIndex = 4;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(277, 526);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 13);
            this.lblDurum.TabIndex = 1;
            // 
            // P_Patlama
            // 
            this.P_Patlama.Image = global::Uçak_Savaşı_Oyunu.Properties.Resources.patlama;
            this.P_Patlama.Location = new System.Drawing.Point(475, 586);
            this.P_Patlama.Name = "P_Patlama";
            this.P_Patlama.Size = new System.Drawing.Size(101, 90);
            this.P_Patlama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_Patlama.TabIndex = 2;
            this.P_Patlama.TabStop = false;
            // 
            // UçakSavaşı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(629, 737);
            this.Controls.Add(this.OyunAlanı);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UçakSavaşı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uçak Savaşı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Uçak)).EndInit();
            this.OyunAlanı.ResumeLayout(false);
            this.OyunAlanı.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_Patlama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button btnBaşlat;
        private System.Windows.Forms.RadioButton radZor;
        private System.Windows.Forms.RadioButton radOrta;
        private System.Windows.Forms.RadioButton radKolay;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox Uçak;
        private System.Windows.Forms.Panel OyunAlanı;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.PictureBox P_Patlama;
    }
}

