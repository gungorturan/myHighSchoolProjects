using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivmeliTop
{
    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
        }
        // topun y düzlemindeki hareketi
        int valueY = 1;

        int skor = 0;

        int hiz = 2;

        private void topY_Tick(object sender, EventArgs e)
        {
            
            if (ball.Top < 0)
            {
                valueY = 1;
            }


            else if (ball.Top > this.Height - ball.Height - levha.Height - 20)
            {
                if(ball.Left<levha.Left || (ball.Left + ball.Width)>(levha.Left + levha.Width))
                {
                    topY.Enabled = false;
                    topX.Enabled = false;
                    lbl_oDurum.Visible = true;
                    btn_restart.Visible = true;
                    lbl_oDurum.Text = "OYUN BİTTİ!";
                    skor = 0;
                }
                else
                {
                    skor += 1;
                    lbl_skor.Text = skor.ToString();
                    if (skor == 5)
                    {
                        hiz = 4;
                    }
                    if (skor == 10)
                    {
                        hiz = 6;
                    }
                }
                valueY = -1;
            }


            ball.Top += valueY*hiz;
        }
        // topun x düzlemindeki hareketi
        int valueX = 1;

        private void topX_Tick(object sender, EventArgs e)
        {

            if (ball.Left < 0)
            {
                valueX = 1;
            }


            else if (ball.Left > this.Width - ball.Width - 10)
            {
                
                valueX = -1;
            }


            ball.Left += valueX*hiz;
        }

        bool escValue = true;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (escValue == true && e.KeyCode == Keys.Escape)
            {
                // oyunu durdurma
                topY.Enabled = false;
                topX.Enabled = false;
                escValue = false;
                lbl_oDurum.Visible = true;
            }


            else if (escValue == false && e.KeyCode == Keys.Escape)
            {
                // devam ettirme
                topY.Enabled = true;
                topX.Enabled = true;
                escValue = true;
                lbl_oDurum.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            levha.Location = new Point(280, 470);
            ball.Location = new Point(0, 0);

            valueX = valueY = 1;

            lbl_oDurum.Text = "OYUN DURDU";
            lbl_oDurum.Visible = false;
            btn_restart.Visible = false;
            this.Focus();

            topX.Enabled = topY.Enabled = true;
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.Location;
            if(levha.Left > 0 || levha.Left < 790)
            {
                levha.Location = new Point(p.X, levha.Location.Y);
            }
            
        }
    }
}
