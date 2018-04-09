using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace damlaTopla
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Button damla = new Button();
        int damlaKonY = 0;
        int damlaKonX;
        bool first = true;
        int skor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void damlaOlustur()
        {
            damlaKonX = rnd.Next(0, 400);
            damla.Name = "damla";
            damla.Location = new Point(damlaKonX, damlaKonY);
            damla.Size = new Size(20, 20);
            damla.Image = new Bitmap(ımageList1.Images[0]);
            this.Controls.Add(damla);
        }


        private void btn_kova_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (btn_kova.Left > 0)
                    {
                        btn_kova.Location = new Point(btn_kova.Location.X - 5, btn_kova.Location.Y);
                    }
                    break;
                case Keys.D:
                    if (btn_kova.Right < this.Width - 15)
                    {
                        btn_kova.Location = new Point(btn_kova.Location.X + 5, btn_kova.Location.Y);
                    }
                    
                    break;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (first == true)
            {
                damlaOlustur();
                first = false;
            }
            if (damla.Bottom < btn_kova.Top || damla.Bottom < this.Height)
            {
                damlaKonY += 5;
                damla.Location = new Point(damlaKonX, damlaKonY);
            }
            if (damla.Bottom > btn_kova.Top && damla.Right < btn_kova.Right && damla.Left > btn_kova.Left)
            {
                damlaKonY = 0;
                damlaKonX = rnd.Next(0, 400);
                damla.Location = new Point(damlaKonX, damlaKonY);
                skor += 1;

            }
            if (damla.Bottom > this.Height - 50)
            {
                damlaKonY = 0;
                damlaKonX = rnd.Next(0, 400);
                damla.Location = new Point(damlaKonX, damlaKonY);
            }
            label1.Text = "Skor: " + skor;
            switch (skor)
            {
                case 5:
                    timer1.Interval = 75;
                    break;
                case 20:
                    timer1.Interval = 50;
                    break;
                case 50:
                    timer1.Interval = 25;
                    break;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Text += skor;
        }
    }
}
