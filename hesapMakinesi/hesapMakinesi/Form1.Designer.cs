namespace hesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_yedi = new System.Windows.Forms.Button();
            this.btn_skz = new System.Windows.Forms.Button();
            this.btn_dkz = new System.Windows.Forms.Button();
            this.btn_alti = new System.Windows.Forms.Button();
            this.btn_bes = new System.Windows.Forms.Button();
            this.btn_dort = new System.Windows.Forms.Button();
            this.btn_uc = new System.Windows.Forms.Button();
            this.btn_iki = new System.Windows.Forms.Button();
            this.btn_bir = new System.Windows.Forms.Button();
            this.btn_esit = new System.Windows.Forms.Button();
            this.btn_sfr = new System.Windows.Forms.Button();
            this.btn_vrgl = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_topla = new System.Windows.Forms.Button();
            this.lbl_sayi = new System.Windows.Forms.Label();
            this.txt_islem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txt_islem);
            this.panel1.Controls.Add(this.lbl_sayi);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 79);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.btn_esit);
            this.panel2.Controls.Add(this.btn_sfr);
            this.panel2.Controls.Add(this.btn_vrgl);
            this.panel2.Controls.Add(this.btn_uc);
            this.panel2.Controls.Add(this.btn_iki);
            this.panel2.Controls.Add(this.btn_bir);
            this.panel2.Controls.Add(this.btn_alti);
            this.panel2.Controls.Add(this.btn_bes);
            this.panel2.Controls.Add(this.btn_dort);
            this.panel2.Controls.Add(this.btn_dkz);
            this.panel2.Controls.Add(this.btn_skz);
            this.panel2.Controls.Add(this.btn_yedi);
            this.panel2.Location = new System.Drawing.Point(1, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 238);
            this.panel2.TabIndex = 2;
            // 
            // btn_yedi
            // 
            this.btn_yedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yedi.Location = new System.Drawing.Point(0, 0);
            this.btn_yedi.Name = "btn_yedi";
            this.btn_yedi.Size = new System.Drawing.Size(79, 55);
            this.btn_yedi.TabIndex = 0;
            this.btn_yedi.Text = "7";
            this.btn_yedi.UseVisualStyleBackColor = true;
            this.btn_yedi.Click += new System.EventHandler(this.btn_yedi_Click);
            // 
            // btn_skz
            // 
            this.btn_skz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_skz.Location = new System.Drawing.Point(85, 0);
            this.btn_skz.Name = "btn_skz";
            this.btn_skz.Size = new System.Drawing.Size(74, 55);
            this.btn_skz.TabIndex = 1;
            this.btn_skz.Text = "8";
            this.btn_skz.UseVisualStyleBackColor = true;
            this.btn_skz.Click += new System.EventHandler(this.btn_skz_Click);
            // 
            // btn_dkz
            // 
            this.btn_dkz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dkz.Location = new System.Drawing.Point(165, 0);
            this.btn_dkz.Name = "btn_dkz";
            this.btn_dkz.Size = new System.Drawing.Size(76, 55);
            this.btn_dkz.TabIndex = 2;
            this.btn_dkz.Text = "9";
            this.btn_dkz.UseVisualStyleBackColor = true;
            this.btn_dkz.Click += new System.EventHandler(this.btn_dkz_Click);
            // 
            // btn_alti
            // 
            this.btn_alti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_alti.Location = new System.Drawing.Point(165, 61);
            this.btn_alti.Name = "btn_alti";
            this.btn_alti.Size = new System.Drawing.Size(76, 55);
            this.btn_alti.TabIndex = 5;
            this.btn_alti.Text = "6";
            this.btn_alti.UseVisualStyleBackColor = true;
            this.btn_alti.Click += new System.EventHandler(this.btn_alti_Click);
            // 
            // btn_bes
            // 
            this.btn_bes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bes.Location = new System.Drawing.Point(85, 61);
            this.btn_bes.Name = "btn_bes";
            this.btn_bes.Size = new System.Drawing.Size(74, 55);
            this.btn_bes.TabIndex = 4;
            this.btn_bes.Text = "5";
            this.btn_bes.UseVisualStyleBackColor = true;
            this.btn_bes.Click += new System.EventHandler(this.btn_bes_Click);
            // 
            // btn_dort
            // 
            this.btn_dort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dort.Location = new System.Drawing.Point(0, 61);
            this.btn_dort.Name = "btn_dort";
            this.btn_dort.Size = new System.Drawing.Size(79, 55);
            this.btn_dort.TabIndex = 3;
            this.btn_dort.Text = "4";
            this.btn_dort.UseVisualStyleBackColor = true;
            this.btn_dort.Click += new System.EventHandler(this.btn_dort_Click);
            // 
            // btn_uc
            // 
            this.btn_uc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uc.Location = new System.Drawing.Point(165, 122);
            this.btn_uc.Name = "btn_uc";
            this.btn_uc.Size = new System.Drawing.Size(76, 55);
            this.btn_uc.TabIndex = 8;
            this.btn_uc.Text = "3";
            this.btn_uc.UseVisualStyleBackColor = true;
            this.btn_uc.Click += new System.EventHandler(this.btn_uc_Click);
            // 
            // btn_iki
            // 
            this.btn_iki.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iki.Location = new System.Drawing.Point(85, 122);
            this.btn_iki.Name = "btn_iki";
            this.btn_iki.Size = new System.Drawing.Size(74, 55);
            this.btn_iki.TabIndex = 7;
            this.btn_iki.Text = "2";
            this.btn_iki.UseVisualStyleBackColor = true;
            this.btn_iki.Click += new System.EventHandler(this.btn_iki_Click);
            // 
            // btn_bir
            // 
            this.btn_bir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bir.Location = new System.Drawing.Point(0, 122);
            this.btn_bir.Name = "btn_bir";
            this.btn_bir.Size = new System.Drawing.Size(79, 55);
            this.btn_bir.TabIndex = 6;
            this.btn_bir.Text = "1";
            this.btn_bir.UseVisualStyleBackColor = true;
            this.btn_bir.Click += new System.EventHandler(this.btn_bir_Click);
            // 
            // btn_esit
            // 
            this.btn_esit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_esit.Location = new System.Drawing.Point(165, 183);
            this.btn_esit.Name = "btn_esit";
            this.btn_esit.Size = new System.Drawing.Size(76, 55);
            this.btn_esit.TabIndex = 11;
            this.btn_esit.Text = "=";
            this.btn_esit.UseVisualStyleBackColor = true;
            this.btn_esit.Click += new System.EventHandler(this.btn_esit_Click);
            // 
            // btn_sfr
            // 
            this.btn_sfr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sfr.Location = new System.Drawing.Point(85, 183);
            this.btn_sfr.Name = "btn_sfr";
            this.btn_sfr.Size = new System.Drawing.Size(74, 55);
            this.btn_sfr.TabIndex = 10;
            this.btn_sfr.Text = "0";
            this.btn_sfr.UseVisualStyleBackColor = true;
            this.btn_sfr.Click += new System.EventHandler(this.btn_sfr_Click);
            // 
            // btn_vrgl
            // 
            this.btn_vrgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vrgl.Location = new System.Drawing.Point(0, 183);
            this.btn_vrgl.Name = "btn_vrgl";
            this.btn_vrgl.Size = new System.Drawing.Size(79, 55);
            this.btn_vrgl.TabIndex = 9;
            this.btn_vrgl.Text = ",";
            this.btn_vrgl.UseVisualStyleBackColor = true;
            this.btn_vrgl.Click += new System.EventHandler(this.btn_vrgl_Click);
            // 
            // btn_ce
            // 
            this.btn_ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ce.Location = new System.Drawing.Point(3, 3);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(50, 38);
            this.btn_ce.TabIndex = 3;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseVisualStyleBackColor = true;
            this.btn_ce.Click += new System.EventHandler(this.btn_ce_Click);
            // 
            // btn_bol
            // 
            this.btn_bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bol.Location = new System.Drawing.Point(3, 54);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(50, 33);
            this.btn_bol.TabIndex = 4;
            this.btn_bol.Text = "÷";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.btn_bol_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_carp.Location = new System.Drawing.Point(3, 100);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(50, 34);
            this.btn_carp.TabIndex = 5;
            this.btn_carp.Text = "x";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_cikar
            // 
            this.btn_cikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikar.Location = new System.Drawing.Point(3, 147);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(50, 34);
            this.btn_cikar.TabIndex = 6;
            this.btn_cikar.Text = "-";
            this.btn_cikar.UseVisualStyleBackColor = true;
            this.btn_cikar.Click += new System.EventHandler(this.btn_cikar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.btn_topla);
            this.panel3.Controls.Add(this.btn_ce);
            this.panel3.Controls.Add(this.btn_cikar);
            this.panel3.Controls.Add(this.btn_bol);
            this.panel3.Controls.Add(this.btn_carp);
            this.panel3.Location = new System.Drawing.Point(248, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 237);
            this.panel3.TabIndex = 7;
            // 
            // btn_topla
            // 
            this.btn_topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_topla.Location = new System.Drawing.Point(3, 194);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(50, 34);
            this.btn_topla.TabIndex = 7;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // lbl_sayi
            // 
            this.lbl_sayi.AutoSize = true;
            this.lbl_sayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayi.Location = new System.Drawing.Point(207, 49);
            this.lbl_sayi.Name = "lbl_sayi";
            this.lbl_sayi.Size = new System.Drawing.Size(0, 20);
            this.lbl_sayi.TabIndex = 1;
            // 
            // txt_islem
            // 
            this.txt_islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_islem.Location = new System.Drawing.Point(85, 12);
            this.txt_islem.Name = "txt_islem";
            this.txt_islem.Size = new System.Drawing.Size(214, 26);
            this.txt_islem.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 321);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi v0.1 by günJör";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_islem;
        private System.Windows.Forms.Label lbl_sayi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_esit;
        private System.Windows.Forms.Button btn_sfr;
        private System.Windows.Forms.Button btn_vrgl;
        private System.Windows.Forms.Button btn_uc;
        private System.Windows.Forms.Button btn_iki;
        private System.Windows.Forms.Button btn_bir;
        private System.Windows.Forms.Button btn_alti;
        private System.Windows.Forms.Button btn_bes;
        private System.Windows.Forms.Button btn_dort;
        private System.Windows.Forms.Button btn_dkz;
        private System.Windows.Forms.Button btn_skz;
        private System.Windows.Forms.Button btn_yedi;
        private System.Windows.Forms.Button btn_ce;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_topla;
    }
}

