
namespace flappy
{
    partial class flappyBird
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
            this.kus = new System.Windows.Forms.PictureBox();
            this.borualt = new System.Windows.Forms.PictureBox();
            this.boruust = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borualt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // kus
            // 
            this.kus.Image = global::flappy.Properties.Resources.bird;
            this.kus.Location = new System.Drawing.Point(113, 75);
            this.kus.Name = "kus";
            this.kus.Size = new System.Drawing.Size(73, 52);
            this.kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kus.TabIndex = 0;
            this.kus.TabStop = false;
            // 
            // borualt
            // 
            this.borualt.Image = global::flappy.Properties.Resources.pipe;
            this.borualt.Location = new System.Drawing.Point(525, 379);
            this.borualt.Name = "borualt";
            this.borualt.Size = new System.Drawing.Size(115, 141);
            this.borualt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.borualt.TabIndex = 1;
            this.borualt.TabStop = false;
            // 
            // boruust
            // 
            this.boruust.Image = global::flappy.Properties.Resources.pipedown;
            this.boruust.Location = new System.Drawing.Point(557, 12);
            this.boruust.Name = "boruust";
            this.boruust.Size = new System.Drawing.Size(115, 171);
            this.boruust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruust.TabIndex = 2;
            this.boruust.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Image = global::flappy.Properties.Resources.ground;
            this.zemin.Location = new System.Drawing.Point(0, 516);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(1019, 83);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 3;
            this.zemin.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(12, 12);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(149, 38);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // flappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(733, 596);
            this.Controls.Add(this.kus);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.boruust);
            this.Controls.Add(this.borualt);
            this.Name = "flappyBird";
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.kus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borualt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kus;
        private System.Windows.Forms.PictureBox borualt;
        private System.Windows.Forms.PictureBox boruust;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

