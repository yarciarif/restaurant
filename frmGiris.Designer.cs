namespace restaurant
{
    partial class frmGiris
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
            this.cbKullanici = new System.Windows.Forms.ComboBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKadi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbKullanici
            // 
            this.cbKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullanici.Font = new System.Drawing.Font("Reem Kufi", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbKullanici.FormattingEnabled = true;
            this.cbKullanici.ItemHeight = 36;
            this.cbKullanici.Location = new System.Drawing.Point(429, 172);
            this.cbKullanici.Name = "cbKullanici";
            this.cbKullanici.Size = new System.Drawing.Size(250, 44);
            this.cbKullanici.TabIndex = 0;
            this.cbKullanici.SelectedIndexChanged += new System.EventHandler(this.CbKullanici_SelectedIndexChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.BackgroundImage = global::restaurant.Properties.Resources.yıldız;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGiris.Location = new System.Drawing.Point(429, 271);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(101, 53);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(429, 237);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(250, 28);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSifre.TextChanged += new System.EventHandler(this.TxtSifre_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::restaurant.Properties.Resources.yıldız;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(574, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblKadi
            // 
            this.lblKadi.AutoSize = true;
            this.lblKadi.BackColor = System.Drawing.Color.Transparent;
            this.lblKadi.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKadi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKadi.Location = new System.Drawing.Point(298, 193);
            this.lblKadi.Name = "lblKadi";
            this.lblKadi.Size = new System.Drawing.Size(106, 23);
            this.lblKadi.TabIndex = 5;
            this.lblKadi.Text = "Kullanıcı Adı";
            this.lblKadi.Click += new System.EventHandler(this.LblKadi_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSifre.Location = new System.Drawing.Point(298, 242);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(48, 23);
            this.lblSifre.TabIndex = 6;
            this.lblSifre.Text = "Şifre";
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurant.Properties.Resources.ayyy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKadi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.cbKullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiris";
            this.Text = "Yetkili Girişi";
            this.Load += new System.EventHandler(this.FrmGiris_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKullanici;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKadi;
        private System.Windows.Forms.Label lblSifre;
    }
}

