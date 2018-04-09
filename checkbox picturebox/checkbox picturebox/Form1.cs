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

namespace checkbox_picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Eğer gözat sekmesinde bir şeyi seçtiğinde onu ekler.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                chclbox.Items.Add(openFileDialog1.FileName);  
            }
        }
        //sayaç
        int s = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //checklistteki sayı s'den büyükse checklistteki seçilmiş nesnelerin indexleriyle picturebox'a resimleri ekler.
            if (chclbox.CheckedItems.Count>=s)
            {
                pictureBox1.Image = new Bitmap(Convert.ToString(chclbox.CheckedItems[s]));
                s++;
                //sayaç sayısı count sayısına ulaştığında sayacı başa alır ve böylece resimleri sonsuza dek oynatır.
                if(s==chclbox.CheckedItems.Count)
                {
                    s = 0;
                }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //checklistte seçim yapılmazsa uyarı veriyor.
            if(chclbox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Bir veya birden fazla seçim yapın!!!");
            }
            //resimleri belli aralıklarla oynatmak için timerı başlatır.
            timer1.Enabled = true;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //timerı durdurur.
            timer1.Enabled = false;
        }
    }
}
//evde çoklu seçme olayını yap.
