using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int konx = 25;
        int kony = 25;

        int pbxw = 75;
        int pbxh = 75;

        int bolx = 0;
        int boly = 0;
        int bolw;
        int bolh;

        int[] sayilar = new int[16];
        int sayi;
        Random rnd = new Random();

        Image secilenresim;

        Image pbxres1,pbxres2;
        PictureBox pbxx;

        int tik = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void pbxekle()
        {
            for (int i = 0; i < 16; i++)
            {
                PictureBox pbx = new PictureBox();
                pbx.Name = "pbx" + (i + 1);
                pbx.Location = new Point(konx, kony);
                pbx.Size = new Size(pbxw, pbxh);
                pbx.SizeMode = PictureBoxSizeMode.StretchImage;
                pbx.Click += Pbx_Click;
                this.Controls.Add(pbx);
                konx += 80;
                if (konx > 265)
                {
                    konx = 25;
                    kony += 80;
                }
            }

        }

        private void Pbx_Click(object sender, EventArgs e)
        {
            PictureBox pbx = (PictureBox)sender;

            if(tik == 1)
            {
                pbxres1 = pbx.Image;
                pbxx = pbx;
                tik++;
            }
            else if(tik == 2)
            {
                pbxres2 = pbx.Image;
                pbx.Image = pbxres1;
                pbxx.Image = pbxres2;
                tik = 1;
            }
        }

        private void karistir()
        {
            for(int i = 0; i < 16; i++)
            {
                do
                {
                    sayi = rnd.Next(1, 17);
                } while (Array.IndexOf(sayilar, sayi) != -1);
                sayilar[i] = sayi;
            }

            for(int i = 0; i < 16; i++)
            {
                ((PictureBox)this.Controls["pbx" + sayilar[i]]).Image = resimbol(bolx, boly, bolw, bolh);
                bolx += bolw;
                if (bolx > bolw * 3)
                {
                    boly += bolh;
                    bolx = 0;
                }
            }
        }

        public Bitmap resimbol(int x, int y, int w, int h)
        {
            Bitmap resim = pictureBox1.Image as Bitmap;
            Rectangle kesilecekalan = new Rectangle(x, y, w, h);
            Bitmap kesilenbolum = resim.Clone(kesilecekalan, resim.PixelFormat);
            return kesilenbolum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.OpenFile());
                secilenresim = new Bitmap (openFileDialog1.OpenFile());
                bolw = secilenresim.Width / 4;
                bolh = secilenresim.Height / 4;
                pbxekle();
                karistir();
            }
        }
    }
}
