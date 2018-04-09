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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 iki = new Form2();
            iki.bar1max1 = Convert.ToInt16(bar1max.Text);
            iki.bar1step1 = Convert.ToInt16(bar1step.Text);
            iki.bar2max1 = Convert.ToInt16(bar2max.Text);
            iki.bar2step1 = Convert.ToInt16(bar2step.Text);
            iki.bar3max1 = Convert.ToInt16(bar3max.Text);
            iki.bar3step1 = Convert.ToInt16(bar3step.Text);
            iki.bar4max1 = Convert.ToInt16(bar4max.Text);
            iki.bar4step1 = Convert.ToInt16(bar4step.Text);
            iki.bar5max1 = Convert.ToInt16(bar5max.Text);
            iki.bar5step1 = Convert.ToInt16(bar5step.Text);
            iki.ShowDialog();
            //ArrayList max = new ArrayList();
        }
    }
}
