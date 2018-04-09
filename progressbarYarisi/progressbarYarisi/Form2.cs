using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressbarYarisi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int bar1max1, bar1step1, bar2max1, bar2step1, bar3max1, bar3step1, bar4max1, bar4step1, bar5max1, bar5step1;

        //public ArrayList max = new ArrayList();
        //public ArrayList step = new ArrayList();
        private void timer5_Tick(object sender, EventArgs e)
        {
            Random rnd5 = new Random();
            timer5.Interval = rnd5.Next(1, 3000);
            progressBar5.Maximum = bar5max1;
            progressBar5.Step = bar5step1;
            progressBar5.Value++;
            if (progressBar5.Value == progressBar5.Maximum)
            {
                timer5.Stop();
            }
        }

        private void siralama_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Maximum == progressBar1.Value)
            {
                MessageBox.Show("Birinci buton galip geldi!");
                timer1.Stop();
            }
            else if(progressBar2.Maximum == progressBar2.Value)
            {
                MessageBox.Show("İkinci Buton galip geldi!");
                timer2.Stop();
            }
            else if(progressBar3.Maximum == progressBar3.Value)
            {
                MessageBox.Show("Üçüncü buton galip geldi!");
                timer3.Stop();
            }
            else if (progressBar4.Maximum == progressBar4.Value)
            {
                MessageBox.Show("Dördüncü buton galip geldi!");
                timer4.Stop();
            }
            else if (progressBar5.Maximum == progressBar5.Value)
            {
                MessageBox.Show("Beşinci buton galip geldi!");
                timer5.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random rnd3 = new Random();
            timer3.Interval = rnd3.Next(1, 3000);
            progressBar3.Maximum = bar3max1;
            progressBar3.Step = bar3step1;
            progressBar3.Value++;
            if (progressBar3.Value == progressBar3.Maximum)
            {
                timer3.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd2 = new Random();
            timer2.Interval = rnd2.Next(1, 3000);
            progressBar2.Maximum = bar2max1;
            progressBar2.Step = bar2step1;
            progressBar2.Value++;
            if (progressBar2.Value == progressBar2.Maximum)
            {
                timer2.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            timer1.Interval = rnd1.Next(1, 3000);
            progressBar1.Maximum = bar1max1;
            progressBar1.Step = bar1step1;
            progressBar1.Value++;
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Random rnd4 = new Random();
            timer4.Interval = rnd4.Next(1, 3000);
            progressBar4.Maximum = bar4max1;
            progressBar4.Step = bar4step1;
            progressBar4.Value++;
            if (progressBar4.Value == progressBar4.Maximum)
            {
                timer4.Stop();
            }
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
