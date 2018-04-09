namespace ivmeliTop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ball = new System.Windows.Forms.PictureBox();
            this.levha = new System.Windows.Forms.PictureBox();
            this.topX = new System.Windows.Forms.Timer(this.components);
            this.topY = new System.Windows.Forms.Timer(this.components);
            this.lbl_oDurum = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.lbl_skor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levha)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(0, 0);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(50, 50);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // levha
            // 
            this.levha.BackColor = System.Drawing.Color.Red;
            this.levha.Location = new System.Drawing.Point(280, 470);
            this.levha.Name = "levha";
            this.levha.Size = new System.Drawing.Size(200, 12);
            this.levha.TabIndex = 1;
            this.levha.TabStop = false;
            // 
            // topX
            // 
            this.topX.Enabled = true;
            this.topX.Interval = 1;
            this.topX.Tick += new System.EventHandler(this.topX_Tick);
            // 
            // topY
            // 
            this.topY.Enabled = true;
            this.topY.Interval = 1;
            this.topY.Tick += new System.EventHandler(this.topY_Tick);
            // 
            // lbl_oDurum
            // 
            this.lbl_oDurum.AutoSize = true;
            this.lbl_oDurum.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_oDurum.Font = new System.Drawing.Font("Aclonica", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_oDurum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_oDurum.Location = new System.Drawing.Point(243, 12);
            this.lbl_oDurum.Name = "lbl_oDurum";
            this.lbl_oDurum.Size = new System.Drawing.Size(271, 38);
            this.lbl_oDurum.TabIndex = 2;
            this.lbl_oDurum.Text = "OYUN DURDU";
            this.lbl_oDurum.Visible = false;
            // 
            // btn_restart
            // 
            this.btn_restart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_restart.BackgroundImage")));
            this.btn_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_restart.Location = new System.Drawing.Point(353, 181);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(52, 51);
            this.btn_restart.TabIndex = 3;
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_skor
            // 
            this.lbl_skor.AutoSize = true;
            this.lbl_skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_skor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_skor.Location = new System.Drawing.Point(725, 12);
            this.lbl_skor.Name = "lbl_skor";
            this.lbl_skor.Size = new System.Drawing.Size(23, 25);
            this.lbl_skor.TabIndex = 4;
            this.lbl_skor.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(774, 482);
            this.Controls.Add(this.lbl_skor);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.lbl_oDurum);
            this.Controls.Add(this.levha);
            this.Controls.Add(this.ball);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox levha;
        private System.Windows.Forms.Timer topX;
        private System.Windows.Forms.Timer topY;
        private System.Windows.Forms.Label lbl_oDurum;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label lbl_skor;
    }
}

