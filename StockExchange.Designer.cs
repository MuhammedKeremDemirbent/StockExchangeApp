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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtbxVeri_isteme = new System.Windows.Forms.TextBox();
            this.hisse_gosterme_gridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yüzde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonhisse_goster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hisse_gosterme_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxVeri_isteme
            // 
            this.txtbxVeri_isteme.Location = new System.Drawing.Point(32, 34);
            this.txtbxVeri_isteme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxVeri_isteme.Name = "txtbxVeri_isteme";
            this.txtbxVeri_isteme.Size = new System.Drawing.Size(520, 22);
            this.txtbxVeri_isteme.TabIndex = 2;
            // 
            // hisse_gosterme_gridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.hisse_gosterme_gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hisse_gosterme_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.hisse_gosterme_gridview.ColumnHeadersHeight = 18;
            this.hisse_gosterme_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.hisse_gosterme_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.Yüzde,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hisse_gosterme_gridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.hisse_gosterme_gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.hisse_gosterme_gridview.Location = new System.Drawing.Point(45, 129);
            this.hisse_gosterme_gridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hisse_gosterme_gridview.Name = "hisse_gosterme_gridview";
            this.hisse_gosterme_gridview.RowHeadersVisible = false;
            this.hisse_gosterme_gridview.RowHeadersWidth = 51;
            this.hisse_gosterme_gridview.RowTemplate.Height = 24;
            this.hisse_gosterme_gridview.Size = new System.Drawing.Size(628, 460);
            this.hisse_gosterme_gridview.TabIndex = 3;
            this.hisse_gosterme_gridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.hisse_gosterme_gridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.hisse_gosterme_gridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.hisse_gosterme_gridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.hisse_gosterme_gridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.hisse_gosterme_gridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.hisse_gosterme_gridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.hisse_gosterme_gridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.hisse_gosterme_gridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.hisse_gosterme_gridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hisse_gosterme_gridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.hisse_gosterme_gridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.hisse_gosterme_gridview.ThemeStyle.HeaderStyle.Height = 18;
            this.hisse_gosterme_gridview.ThemeStyle.ReadOnly = false;
            this.hisse_gosterme_gridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.hisse_gosterme_gridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.hisse_gosterme_gridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hisse_gosterme_gridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.hisse_gosterme_gridview.ThemeStyle.RowsStyle.Height = 24;
            this.hisse_gosterme_gridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.hisse_gosterme_gridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // a
            // 
            this.a.HeaderText = "Hisse Adı";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            // 
            // Yüzde
            // 
            this.Yüzde.HeaderText = "Yüzde";
            this.Yüzde.MinimumWidth = 6;
            this.Yüzde.Name = "Yüzde";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hacim";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // buttonhisse_goster
            // 
            this.buttonhisse_goster.Location = new System.Drawing.Point(637, 18);
            this.buttonhisse_goster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonhisse_goster.Name = "buttonhisse_goster";
            this.buttonhisse_goster.Size = new System.Drawing.Size(95, 25);
            this.buttonhisse_goster.TabIndex = 4;
            this.buttonhisse_goster.Text = "Hisse Göster";
            this.buttonhisse_goster.UseVisualStyleBackColor = true;
            this.buttonhisse_goster.Click += new System.EventHandler(this.buttonhisse_goster_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tarama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(403, 615);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // StockExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 674);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonhisse_goster);
            this.Controls.Add(this.hisse_gosterme_gridview);
            this.Controls.Add(this.txtbxVeri_isteme);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StockExchange";
            this.Text = "Stock Exchange";
            this.Load += new System.EventHandler(this.StockExchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hisse_gosterme_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbxVeri_isteme;
        private Guna.UI2.WinForms.Guna2DataGridView hisse_gosterme_gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yüzde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button buttonhisse_goster;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

