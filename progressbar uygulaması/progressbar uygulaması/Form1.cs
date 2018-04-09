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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 xd = new Form2();
            xd.Show();
            this.Hide();

            xd.max1 = Convert.ToInt16(textBox1.Text);
            xd.step1 = Convert.ToInt16(textBox9.Text);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
