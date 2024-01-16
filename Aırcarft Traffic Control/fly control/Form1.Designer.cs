namespace fly_control
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureboxhalka = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBoxnokta = new System.Windows.Forms.PictureBox();
            this.pictureboxcubuk = new System.Windows.Forms.PictureBox();
            this.pictureBoxturiyeharistası = new System.Windows.Forms.PictureBox();
            this.pictureBoxnoktaharita = new System.Windows.Forms.PictureBox();
            this.pictureBoxharitanoktavaris = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonkalkısonay = new Guna.UI2.WinForms.Guna2Button();
            this.btnUcusBelirle = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComboBoxvaris = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureboxhalka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnokta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcubuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxturiyeharistası)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnoktaharita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxharitanoktavaris)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureboxhalka
            // 
            this.pictureboxhalka.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxhalka.BackgroundImage = global::fly_control.Properties.Resources.pngegg__1_;
            this.pictureboxhalka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureboxhalka.Controls.Add(this.pictureBoxnokta);
            this.pictureboxhalka.Controls.Add(this.pictureboxcubuk);
            this.pictureboxhalka.CustomBorderColor = System.Drawing.Color.Transparent;
            this.pictureboxhalka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureboxhalka.Location = new System.Drawing.Point(0, 0);
            this.pictureboxhalka.Name = "pictureboxhalka";
            this.pictureboxhalka.Size = new System.Drawing.Size(300, 300);
            this.pictureboxhalka.TabIndex = 4;
            this.pictureboxhalka.UseTransparentBackground = true;
            // 
            // pictureBoxnokta
            // 
            this.pictureBoxnokta.Image = global::fly_control.Properties.Resources.nokta;
            this.pictureBoxnokta.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxnokta.Name = "pictureBoxnokta";
            this.pictureBoxnokta.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxnokta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxnokta.TabIndex = 5;
            this.pictureBoxnokta.TabStop = false;
            // 
            // pictureboxcubuk
            // 
            this.pictureboxcubuk.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxcubuk.Image = global::fly_control.Properties.Resources.pngegg__6_;
            this.pictureboxcubuk.Location = new System.Drawing.Point(0, 0);
            this.pictureboxcubuk.Name = "pictureboxcubuk";
            this.pictureboxcubuk.Size = new System.Drawing.Size(300, 300);
            this.pictureboxcubuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxcubuk.TabIndex = 1;
            this.pictureboxcubuk.TabStop = false;
            // 
            // pictureBoxturiyeharistası
            // 
            this.pictureBoxturiyeharistası.Image = global::fly_control.Properties.Resources.turkiye_haritası;
            this.pictureBoxturiyeharistası.Location = new System.Drawing.Point(299, 0);
            this.pictureBoxturiyeharistası.Name = "pictureBoxturiyeharistası";
            this.pictureBoxturiyeharistası.Size = new System.Drawing.Size(643, 300);
            this.pictureBoxturiyeharistası.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxturiyeharistası.TabIndex = 5;
            this.pictureBoxturiyeharistası.TabStop = false;
            // 
            // pictureBoxnoktaharita
            // 
            this.pictureBoxnoktaharita.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxnoktaharita.Image = global::fly_control.Properties.Resources.nokta;
            this.pictureBoxnoktaharita.Location = new System.Drawing.Point(381, 30);
            this.pictureBoxnoktaharita.Name = "pictureBoxnoktaharita";
            this.pictureBoxnoktaharita.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxnoktaharita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxnoktaharita.TabIndex = 6;
            this.pictureBoxnoktaharita.TabStop = false;
            // 
            // pictureBoxharitanoktavaris
            // 
            this.pictureBoxharitanoktavaris.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxharitanoktavaris.Image = global::fly_control.Properties.Resources.nokta;
            this.pictureBoxharitanoktavaris.Location = new System.Drawing.Point(381, 30);
            this.pictureBoxharitanoktavaris.Name = "pictureBoxharitanoktavaris";
            this.pictureBoxharitanoktavaris.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxharitanoktavaris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxharitanoktavaris.TabIndex = 7;
            this.pictureBoxharitanoktavaris.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(299, 300);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(642, 212);
            this.listBox1.TabIndex = 8;
            // 
            // buttonkalkısonay
            // 
            this.buttonkalkısonay.BackColor = System.Drawing.Color.Transparent;
            this.buttonkalkısonay.BorderThickness = 8;
            this.buttonkalkısonay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonkalkısonay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonkalkısonay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonkalkısonay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonkalkısonay.FillColor = System.Drawing.Color.Red;
            this.buttonkalkısonay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonkalkısonay.ForeColor = System.Drawing.Color.White;
            this.buttonkalkısonay.Location = new System.Drawing.Point(0, 366);
            this.buttonkalkısonay.Name = "buttonkalkısonay";
            this.buttonkalkısonay.Size = new System.Drawing.Size(300, 77);
            this.buttonkalkısonay.TabIndex = 9;
            this.buttonkalkısonay.Text = "Sefer yapılabilir  onayı";
            this.buttonkalkısonay.Click += new System.EventHandler(this.buttonkalkısonay_Click_1);
            // 
            // btnUcusBelirle
            // 
            this.btnUcusBelirle.BackColor = System.Drawing.Color.Transparent;
            this.btnUcusBelirle.BorderThickness = 8;
            this.btnUcusBelirle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUcusBelirle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUcusBelirle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUcusBelirle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUcusBelirle.FillColor = System.Drawing.Color.Red;
            this.btnUcusBelirle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUcusBelirle.ForeColor = System.Drawing.Color.White;
            this.btnUcusBelirle.Location = new System.Drawing.Point(0, 449);
            this.btnUcusBelirle.Name = "btnUcusBelirle";
            this.btnUcusBelirle.Size = new System.Drawing.Size(300, 77);
            this.btnUcusBelirle.TabIndex = 10;
            this.btnUcusBelirle.Text = "Uçuş belirleyin";
            this.btnUcusBelirle.Click += new System.EventHandler(this.btnucusbelirle_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 319);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(103, 15);
            this.guna2HtmlLabel1.TabIndex = 11;
            this.guna2HtmlLabel1.Text = "Varış Noktasını Seçin";
            // 
            // ComboBoxvaris
            // 
            this.ComboBoxvaris.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxvaris.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxvaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxvaris.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxvaris.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxvaris.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxvaris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxvaris.ItemHeight = 30;
            this.ComboBoxvaris.Location = new System.Drawing.Point(121, 310);
            this.ComboBoxvaris.Name = "ComboBoxvaris";
            this.ComboBoxvaris.Size = new System.Drawing.Size(178, 36);
            this.ComboBoxvaris.TabIndex = 12;
            this.ComboBoxvaris.SelectedIndexChanged += new System.EventHandler(this.ComboBoxvaris_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(944, 511);
            this.Controls.Add(this.ComboBoxvaris);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnUcusBelirle);
            this.Controls.Add(this.buttonkalkısonay);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBoxharitanoktavaris);
            this.Controls.Add(this.pictureBoxnoktaharita);
            this.Controls.Add(this.pictureBoxturiyeharistası);
            this.Controls.Add(this.pictureboxhalka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pictureboxhalka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnokta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxcubuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxturiyeharistası)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxnoktaharita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxharitanoktavaris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureboxcubuk;
        private Guna.UI2.WinForms.Guna2Panel pictureboxhalka;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxnokta;
        private System.Windows.Forms.PictureBox pictureBoxturiyeharistası;
        private System.Windows.Forms.PictureBox pictureBoxnoktaharita;
        private System.Windows.Forms.PictureBox pictureBoxharitanoktavaris;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Button buttonkalkısonay;
        private Guna.UI2.WinForms.Guna2Button btnUcusBelirle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxvaris;
    }
}

