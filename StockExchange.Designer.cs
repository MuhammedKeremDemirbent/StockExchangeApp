namespace StockExchangeApp
{
    partial class StockExchange
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
            this.lblAKSEN = new System.Windows.Forms.Label();
            this.lblGARAN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAKSEN
            // 
            this.lblAKSEN.AutoSize = true;
            this.lblAKSEN.Location = new System.Drawing.Point(261, 53);
            this.lblAKSEN.Name = "lblAKSEN";
            this.lblAKSEN.Size = new System.Drawing.Size(52, 16);
            this.lblAKSEN.TabIndex = 0;
            this.lblAKSEN.Text = "AKSEN";
            // 
            // lblGARAN
            // 
            this.lblGARAN.AutoSize = true;
            this.lblGARAN.Location = new System.Drawing.Point(261, 102);
            this.lblGARAN.Name = "lblGARAN";
            this.lblGARAN.Size = new System.Drawing.Size(55, 16);
            this.lblGARAN.TabIndex = 1;
            this.lblGARAN.Text = "GARAN";
            // 
            // StockExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGARAN);
            this.Controls.Add(this.lblAKSEN);
            this.Name = "StockExchange";
            this.Text = "Stock Exchange";
            this.Load += new System.EventHandler(this.StockExchange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAKSEN;
        private System.Windows.Forms.Label lblGARAN;
    }
}

