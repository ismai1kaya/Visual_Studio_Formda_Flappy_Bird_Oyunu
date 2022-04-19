
namespace Flappy_Bird
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
            this.zemin = new System.Windows.Forms.PictureBox();
            this.kolonAlt = new System.Windows.Forms.PictureBox();
            this.kolonUst = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolonAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolonUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // zemin
            // 
            this.zemin.Image = ((System.Drawing.Image)(resources.GetObject("zemin.Image")));
            this.zemin.Location = new System.Drawing.Point(-3, 526);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(973, 105);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 0;
            this.zemin.TabStop = false;
            // 
            // kolonAlt
            // 
            this.kolonAlt.Image = ((System.Drawing.Image)(resources.GetObject("kolonAlt.Image")));
            this.kolonAlt.Location = new System.Drawing.Point(570, 353);
            this.kolonAlt.Name = "kolonAlt";
            this.kolonAlt.Size = new System.Drawing.Size(94, 179);
            this.kolonAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kolonAlt.TabIndex = 2;
            this.kolonAlt.TabStop = false;
            this.kolonAlt.Click += new System.EventHandler(this.kolonAlt_Click);
            // 
            // kolonUst
            // 
            this.kolonUst.Image = ((System.Drawing.Image)(resources.GetObject("kolonUst.Image")));
            this.kolonUst.Location = new System.Drawing.Point(795, 0);
            this.kolonUst.Name = "kolonUst";
            this.kolonUst.Size = new System.Drawing.Size(94, 179);
            this.kolonUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kolonUst.TabIndex = 3;
            this.kolonUst.TabStop = false;
            this.kolonUst.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(-3, 53);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(100, 81);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 4;
            this.flappyBird.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.Desktop;
            this.scoreText.Location = new System.Drawing.Point(6, 586);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(123, 33);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "Score : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(961, 653);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.kolonUst);
            this.Controls.Add(this.kolonAlt);
            this.Controls.Add(this.zemin);
            this.Name = "Form1";
            this.Text = "Flappy Bird Oyunu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolonAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolonUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.PictureBox kolonAlt;
        private System.Windows.Forms.PictureBox kolonUst;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

