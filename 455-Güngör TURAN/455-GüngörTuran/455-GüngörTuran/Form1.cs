using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _455_GüngörTuran
{
    public partial class Form1 : Form
    {
        int konx = 5;
        int kony = 5;
        int sayi;
        Random rnd = new Random();
        int tik = 0;
        PictureBox secilenpbx, secilenpbx2;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void pbxOlustur()
        {
            for(int i = 1; i < 17; i++)
            {
                PictureBox pbx = new PictureBox();
                pbx.Name = "pictureBox" + i;
                pbx.Width = 75;
                pbx.Height = 75;
                pbx.Location = new Point(konx, kony);
                pbx.Click += Pbx_Click;
                this.Controls.Add(pbx);
                if (konx < 230)
                {
                    konx += 80;
                }
                else
                {
                    konx = 5;
                    kony += 80;
                }
            }
        }
        private void Pbx_Click(object sender, EventArgs e)
        {
            PictureBox pbx = (PictureBox)sender;
            if(tik == 0)
            {
                tik++;
            }
            if(tik == 1)
            {
                secilenpbx = pbx;
                tik++;
            }
            else if(tik == 2)
            {
                secilenpbx2 = pbx;
                secilenpbx2.Image = secilenpbx.Image;
                pbx.Image = secilenpbx2.Image;
                tik = 0;
            }
        }

        private void siraliResimYukle()
        {
            int[] sayilar = new int[16];
            for (int i = 0; i < 16; i++)
            {
                ((PictureBox)this.Controls["pictureBox" + (i + 1)]).Image = ımageList1.Images[i];
            }
        }
        private void karisikResimYukle()
        {
            int[] sayilar = new int[16];
            for(int i = 0; i < 16; i++)
            {
                do
                {
                    sayi = rnd.Next(0, 17);
                } while (Array.IndexOf(sayilar, sayi) != -1);
                sayilar[i] = sayi;
            }
            for (int i = 0; i < 16; i++)
            {
                ((PictureBox)this.Controls[sayilar[i]]).Image = ımageList1.Images[i];
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pbxOlustur();
            siraliResimYukle();
            comboBox1.Items.Add("Sarı");
            comboBox1.Items.Add("Lacivert");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            siraliResimYukle();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pbxOlustur();
            karisikResimYukle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                this.BackColor = Color.Yellow;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                this.BackColor = Color.DarkBlue;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            siraliResimYukle();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }
    }
}
