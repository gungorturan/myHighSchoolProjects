using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double s1, s2,sonuc;
        string smbl;
        private void btn_vrgl_Click(object sender, EventArgs e)
        {
            lbl_sayi.Text += ",";
        }

        private void btn_sfr_Click(object sender, EventArgs e)
        {
            lbl_sayi.Text += "0";
        }

        private void btn_esit_Click(object sender, EventArgs e)
        {
            if (smbl == "+")
            {
                s2 = Convert.ToDouble(lbl_sayi.Text);
                sonuc = s1 + s2;
                txt_islem.Text = sonuc.ToString();
                lbl_sayi.Text = "";
            }
            if (smbl == "-")
            {
                s2 = Convert.ToDouble(lbl_sayi.Text);
                sonuc = s1 - s2;
                txt_islem.Text = sonuc.ToString();
                lbl_sayi.Text = "";
            }
            if (smbl == "*")
            {
                s2 = Convert.ToDouble(lbl_sayi.Text);
                sonuc = s1 * s2;
                txt_islem.Text = sonuc.ToString();
                lbl_sayi.Text = "";
            }
            if (smbl == "/")
            {
                s2 = Convert.ToDouble(lbl_sayi.Text);
                sonuc = s1 / s2;
                txt_islem.Text = sonuc.ToString();
                lbl_sayi.Text = "";
            }
        }

        private void btn_bir_Click(object sender, EventArgs e)
        {
            lbl_sayi.Text += "1";
        }

        private void btn_iki_Click(object sender, EventArgs e)
        {
            lbl_sayi.Text += "2";
        }

        private void btn_uc_Click(object sender, EventArgs e)
        {
            lbl_sayi.Text += "3";
        }

        private void btn_dort_Click(object sender, EventArgs e)
        {
            lbl_sayi.Text += "4";
        }

        private void btn_bes_Click(object sender, EventArgs e)
        {
            lbl_sayi.Text += "5";
        }

        private void btn_alti_Click(object sender, EventArgs e)
        {
            lbl_sayi.Text += "6";
        }

        private void btn_yedi_Click(object sender, EventArgs e)
        {
            lbl_sayi.Text += "7";
        }

        private void btn_skz_Click(object sender, EventArgs e)
        {
            lbl_sayi.Text += "8";
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(lbl_sayi.Text);
            txt_islem.Text += lbl_sayi.Text;
            smbl = "+";
            txt_islem.Text += smbl;
            lbl_sayi.Text = "";
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(lbl_sayi.Text);
            txt_islem.Text = lbl_sayi.Text;
            smbl = "-";
            txt_islem.Text += smbl;
            lbl_sayi.Text = "";
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(lbl_sayi.Text);
            txt_islem.Text = lbl_sayi.Text;
            smbl = "*";
            txt_islem.Text += smbl;
            lbl_sayi.Text = "";
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(lbl_sayi.Text);
            txt_islem.Text = lbl_sayi.Text;
            smbl = "/";
            txt_islem.Text += smbl;
            lbl_sayi.Text = "";
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            txt_islem.Clear();
            lbl_sayi.Text = "";
            s1 = 0;
            s2 = 0;
        }

        private void btn_dkz_Click(object sender, EventArgs e)
        {
            lbl_sayi.Text += "9";
        }
    }
}
