using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressbar_uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        public int max1, step1;
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = rnd.Next(1, 3000);
            progressBar1.Value = max1;
            progressBar1.Value += step1;
            //progressBar1.Step = step1;
            if (progressBar1.Value==max1)
            {
                progressBar1.Value = 0;
            }

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = rnd.Next(1, 3000);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = rnd.Next(1, 3000);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Interval = rnd.Next(1, 3000);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Interval = rnd.Next(1, 3000);
        }
    }
}
