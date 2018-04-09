using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokanmaYanarsın
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }
        private void button10_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler...");
            Cursor.Position = new Point(2, 43);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.BackgroundImageLayout = ImageLayout.Stretch;

            Cursor.Position = new Point(2, 43);


            
            Bitmap bmp = new Bitmap(new Bitmap(Properties.Resources.bugs_bunny___Kopya), 25, 25);


            Cursor yenıCursor = new Cursor(bmp.GetHicon());
            this.Cursor = yenıCursor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(2, 43);
        }
    }
}
