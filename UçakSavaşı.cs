using System;
using System.Drawing;
using System.Windows.Forms;

namespace Uçak_Savaşı_Oyunu
{
    public partial class UçakSavaşı : Form
    {
        int Can = 3, DüşmanHareketi = 5, MermiHızı = 10, OyuncuHareketi = 0, MükemmelZorluk = 40, MükemmelPuan = 50, İyiPuan = 20, EkCan = 1, Puan = 0, PatlamaTick = 100;
        PictureBox mermi, düşman;
        public UçakSavaşı()
        {
            InitializeComponent();
            P_Patlama.Top = -100;
            Load += UçakSavaşı_Load;
            KeyDown += UçakSavaşı_KeyDown;
            KeyUp += UçakSavaşı_KeyUp;
        }
        private void UçakSavaşı_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Can; i++)
            {
                flowLayoutPanel1.Controls.Add(P_Can());
            }
            radKolay.Checked = true;
        }
        private void UçakSavaşı_KeyDown(object sender, KeyEventArgs e)
        {
            Point SolHareket = new Point(0, 700);
            Point SağHareket = new Point(500, 700);
            if (e.KeyCode == Keys.Enter)
            {
                Başla();
            }
            if(e.KeyCode == Keys.S)
            {
                Bitir();
            }
            if (e.KeyCode == Keys.Left)
            {
                if(Uçak.Location.X < SolHareket.X)
                {
                    Uçak.Location = SağHareket;
                }
                else
                {
                    OyuncuHareketi = -10;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Uçak.Location.X > SağHareket.X)
                {
                    Uçak.Location = SolHareket;
                }
                else
                {
                    OyuncuHareketi = 10;
                }
            }
            if (e.KeyCode == Keys.Space)
            {
                P_Mermi();
                foreach (Control item in OyunAlanı.Controls)
                {
                    if (item.Name.Contains("Mermi") == true)
                    {
                        MermiHızı = 10;
                        Mermi.Left = Uçak.Left + 40;
                        Mermi.Top = Uçak.Top;
                    }
                }
            }
        }
        private void UçakSavaşı_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                OyuncuHareketi = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                OyuncuHareketi = 0;
            }
        }
        PictureBox can;
        PictureBox P_Can()
        {
            can = new PictureBox();
            can.Name = "Can";
            can.Image = global::Uçak_Savaşı_Oyunu.Properties.Resources.can;
            can.SizeMode = PictureBoxSizeMode.StretchImage;
            can.Size = new Size(20, 20);
            return can;
        }
        PictureBox Mermi;
        PictureBox P_Mermi()
        {
            Mermi = new PictureBox();
            Mermi.Name = "Mermi";
            Mermi.Image = global::Uçak_Savaşı_Oyunu.Properties.Resources.Ateş;
            Mermi.SizeMode = PictureBoxSizeMode.StretchImage;
            Mermi.Size = new Size(20, 30);
            OyunAlanı.Controls.Add(Mermi);
            Mermi.Location = new Point(0, 0);
            return Mermi;
        }
        PictureBox Düşman;
        PictureBox P_Düşman()
        {
            Düşman = new PictureBox();
            Düşman.Name = "Düşman";
            Düşman.Image = global::Uçak_Savaşı_Oyunu.Properties.Resources.Düşman_Uçağı_1;
            Düşman.SizeMode = PictureBoxSizeMode.StretchImage;
            Düşman.Size = new Size(40, 40);
            Random Xeksen = new Random();
            Düşman.Left = Xeksen.Next(15, 700);
            Random Yeksen = new Random();
            Düşman.Top = Yeksen.Next(100, 1500) * -1;
            return Düşman;
        }
        private void Başla()
        {
            foreach (Control İtem in OyunAlanı.Controls)
            {
                if (İtem.Name.Contains("Düşman"))
                {
                    OyunAlanı.Controls.Remove(İtem);
                }
                if (İtem.Name.Contains("Mermi"))
                {
                    OyunAlanı.Controls.Remove(İtem);
                }
            }
            Can = 3;
            P_Düşman();
            P_Mermi();
            Uçak.Location = new Point(250, 550);
            radKolay.Enabled = false;
            radOrta.Enabled = false;
            radZor.Enabled = false;
            btnBaşlat.Enabled = false;
            btnBitir.Enabled = true;
            if (radKolay.Checked == true)
            {
                DüşmanHareketi = 3;
            }
            if (radOrta.Checked == true)
            {
                DüşmanHareketi = 5;
            }
            if (radZor.Checked == true)
            {
                DüşmanHareketi = 8;
            }
            panel1.Enabled = false;
            timer1.Start();
        }
        private void btnBaşlat_Click(object sender, EventArgs e)
        {
            Başla();
        }
        private void Bitir()
        {
            timer1.Stop();
            timer1.Enabled = false;
            MessageBox.Show("Oyun Bitti. Puanınız: '" + Puan + "'dır.","Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Puan = 0;
            lblPuan.Text = "0";
            panel1.Enabled = true;
            radKolay.Enabled = true;
            radOrta.Enabled = true;
            radZor.Enabled = true;
            btnBaşlat.Enabled = true;
            btnBitir.Enabled = false;
        }
        private void btnBitir_Click(object sender, EventArgs e)
        {
            Bitir();
        }
        private void Canlar()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int a = 0; a < Can; a++)
            {
                flowLayoutPanel1.Controls.Add(P_Can());
            }
        }
        private void CanEkle()
        {
            if (Puan > 100 && EkCan == 1)
            {
                Can++; EkCan = 2; Canlar();
            }
            if (Puan > 200 && EkCan == 2)
            {
                Can++; EkCan = 3; Canlar();
            }
            if (Puan > 300 && EkCan == 3)
            {
                Can++;
                EkCan = 4;
                Canlar();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Uçak.Left += OyuncuHareketi;
            lblPuan.Text = Convert.ToString(Puan);
            if (Can > 0)
            {
                foreach (Control item in OyunAlanı.Controls)
                {
                    if (item.Name.Contains("Düşman"))
                    {
                        item.Top += DüşmanHareketi;
                        if (item.Bottom >= Uçak.Top + Uçak.Height / 2)
                        {
                            if ((item.Right > Uçak.Left && item.Right < Uçak.Right) || (item.Left > Uçak.Left && item.Left < Uçak.Right))
                            {
                                Random randomY = new Random();
                                item.Top = randomY.Next(150, 2000) * -1;
                                Can--;
                                Canlar();
                            }
                            if (item.Bottom >= 700)
                            {
                                Random randomY = new Random();
                                item.Top = randomY.Next(150, 2000) * -1;
                                Can--;
                                Canlar();
                            }
                        }
                        Vurulma();
                    }
                }
            }
            else
            {
                Bitir();
            }
            foreach (Control item in OyunAlanı.Controls)
            {
                if (item.Name.Contains("Mermi"))
                {
                    MermiHızı = 10;
                    item.Top -= MermiHızı;
                }
            }
            //lblPuan.Top -= 10;
            lblDurum.Top -= 10;
            PatlamaTick--;
        }
        private void Vurulma()
        {
            if (Mermi.Bounds.IntersectsWith(Düşman.Bounds))
            {
                if(PatlamaTick == 0)
                {
                    PatlamaTick = 100;
                    P_Patlama.Location = new Point(-100, -100);
                }
                foreach (Control İtem in OyunAlanı.Controls)
                {
                    if (İtem.Name.Contains("Düşman"))
                    {
                        düşman = (PictureBox)İtem;
                        foreach (Control Mermi_İtem in OyunAlanı.Controls)
                        {
                            if (Mermi_İtem.Name.Contains("Mermi"))
                            {
                                mermi = (PictureBox)Mermi_İtem;
                                if (mermi.Bounds.IntersectsWith(düşman.Bounds))
                                {
                                    int Üçte_Biri = düşman.Width / 3;
                                    int Left = düşman.Left;
                                    int Right = düşman.Right;
                                    lblDurum.Location = new Point(mermi.Bounds.Location.X, mermi.Bounds.Location.Y + 25);
                                    P_Patlama.Location = new Point(mermi.Bounds.Location.X - 30, mermi.Bounds.Location.Y - 50);
                                    if (mermi.Right < Left + Üçte_Biri + MükemmelZorluk || mermi.Left > Üçte_Biri - MükemmelZorluk)
                                    {
                                        Puan += İyiPuan;
                                        lblPuan.Text = Convert.ToString(İyiPuan);
                                        lblDurum.Text = "GÜZEL!";
                                    }
                                    else
                                    {
                                        Puan += MükemmelPuan;
                                        lblPuan.Text = Convert.ToString(MükemmelPuan);
                                        lblDurum.Text = "MÜKEMMEL!";
                                    }
                                    CanEkle();
                                    OyunAlanı.Controls.Remove(düşman);
                                    P_Düşman();
                                    MermiHızı = 0;
                                    mermi.Top = -100;
                                    mermi.Left = -100;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
