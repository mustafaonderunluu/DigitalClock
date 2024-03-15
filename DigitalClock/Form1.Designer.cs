namespace DigitalClock
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
            this.labelzaman = new System.Windows.Forms.Label();
            this.Zaman = new System.Windows.Forms.Timer(this.components);
            this.LabelYıl = new System.Windows.Forms.Label();
            this.LabelAy = new System.Windows.Forms.Label();
            this.LabelGun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelzaman
            // 
            this.labelzaman.AutoSize = true;
            this.labelzaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelzaman.Location = new System.Drawing.Point(8, 21);
            this.labelzaman.Name = "labelzaman";
            this.labelzaman.Size = new System.Drawing.Size(255, 91);
            this.labelzaman.TabIndex = 0;
            this.labelzaman.Text = "label1";
            // 
            // Zaman
            // 
            this.Zaman.Enabled = true;
            this.Zaman.Interval = 1000;
            this.Zaman.Tick += new System.EventHandler(this.Zaman_Tick);
            // 
            // LabelYıl
            // 
            this.LabelYıl.AutoSize = true;
            this.LabelYıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelYıl.Location = new System.Drawing.Point(12, 141);
            this.LabelYıl.Name = "LabelYıl";
            this.LabelYıl.Size = new System.Drawing.Size(99, 69);
            this.LabelYıl.TabIndex = 1;
            this.LabelYıl.Text = "Yıl";
            // 
            // LabelAy
            // 
            this.LabelAy.AutoSize = true;
            this.LabelAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelAy.Location = new System.Drawing.Point(198, 141);
            this.LabelAy.Name = "LabelAy";
            this.LabelAy.Size = new System.Drawing.Size(102, 69);
            this.LabelAy.TabIndex = 2;
            this.LabelAy.Text = "Ay";
            // 
            // LabelGun
            // 
            this.LabelGun.AutoSize = true;
            this.LabelGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelGun.Location = new System.Drawing.Point(361, 141);
            this.LabelGun.Name = "LabelGun";
            this.LabelGun.Size = new System.Drawing.Size(146, 69);
            this.LabelGun.TabIndex = 3;
            this.LabelGun.Text = "Gün";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.LabelGun);
            this.Controls.Add(this.LabelAy);
            this.Controls.Add(this.LabelYıl);
            this.Controls.Add(this.labelzaman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelzaman;
        private System.Windows.Forms.Timer Zaman;
        private System.Windows.Forms.Label LabelYıl;
        private System.Windows.Forms.Label LabelAy;
        private System.Windows.Forms.Label LabelGun;
    }
}

