namespace KutuphaneOtomasyonu.KitapBilgi
{
    partial class KitapKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapKayit));
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.tbxAdet = new System.Windows.Forms.TextBox();
            this.tbxBarkod = new System.Windows.Forms.TextBox();
            this.tbxSayfa = new System.Windows.Forms.TextBox();
            this.tbxYazar = new System.Windows.Forms.TextBox();
            this.dgwKitaplar = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKitap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxAd
            // 
            this.tbxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAd.Location = new System.Drawing.Point(158, 182);
            this.tbxAd.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAd.Multiline = true;
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(148, 25);
            this.tbxAd.TabIndex = 0;
            // 
            // cbxKategori
            // 
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Items.AddRange(new object[] {
            "TARİH",
            "ROMAN",
            "FANTASTİK",
            "KİŞİSEL GELİŞİM",
            "GİZEM",
            "POLİSİYE"});
            this.cbxKategori.Location = new System.Drawing.Point(158, 138);
            this.cbxKategori.Margin = new System.Windows.Forms.Padding(2);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(148, 21);
            this.cbxKategori.TabIndex = 2;
            // 
            // tbxAdet
            // 
            this.tbxAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdet.Location = new System.Drawing.Point(158, 221);
            this.tbxAdet.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAdet.Multiline = true;
            this.tbxAdet.Name = "tbxAdet";
            this.tbxAdet.Size = new System.Drawing.Size(148, 27);
            this.tbxAdet.TabIndex = 8;
            // 
            // tbxBarkod
            // 
            this.tbxBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBarkod.Location = new System.Drawing.Point(158, 98);
            this.tbxBarkod.Margin = new System.Windows.Forms.Padding(2);
            this.tbxBarkod.Multiline = true;
            this.tbxBarkod.Name = "tbxBarkod";
            this.tbxBarkod.Size = new System.Drawing.Size(148, 27);
            this.tbxBarkod.TabIndex = 9;
            this.tbxBarkod.TextChanged += new System.EventHandler(this.tbxBarkod_TextChanged);
            // 
            // tbxSayfa
            // 
            this.tbxSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSayfa.Location = new System.Drawing.Point(158, 263);
            this.tbxSayfa.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSayfa.Multiline = true;
            this.tbxSayfa.Name = "tbxSayfa";
            this.tbxSayfa.Size = new System.Drawing.Size(148, 27);
            this.tbxSayfa.TabIndex = 10;
            // 
            // tbxYazar
            // 
            this.tbxYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYazar.Location = new System.Drawing.Point(158, 301);
            this.tbxYazar.Margin = new System.Windows.Forms.Padding(2);
            this.tbxYazar.Multiline = true;
            this.tbxYazar.Name = "tbxYazar";
            this.tbxYazar.Size = new System.Drawing.Size(148, 29);
            this.tbxYazar.TabIndex = 11;
            // 
            // dgwKitaplar
            // 
            this.dgwKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitaplar.Location = new System.Drawing.Point(379, 56);
            this.dgwKitaplar.Margin = new System.Windows.Forms.Padding(2);
            this.dgwKitaplar.Name = "dgwKitaplar";
            this.dgwKitaplar.RowTemplate.Height = 24;
            this.dgwKitaplar.Size = new System.Drawing.Size(370, 248);
            this.dgwKitaplar.TabIndex = 12;
            this.dgwKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKitaplar_CellClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEkle.Location = new System.Drawing.Point(515, 369);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 34);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuncelle.Location = new System.Drawing.Point(515, 308);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(94, 34);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıfırla.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSıfırla.Location = new System.Drawing.Point(121, 369);
            this.btnSıfırla.Margin = new System.Windows.Forms.Padding(2);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(94, 34);
            this.btnSıfırla.TabIndex = 15;
            this.btnSıfırla.Text = "Sıfırla";
            this.btnSıfırla.UseVisualStyleBackColor = true;
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(45, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Yazar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(45, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sayfa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(45, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(45, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Barkod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(45, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(54, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Image = global::KutuphaneOtomasyonu.Properties.Resources.remove__1_;
            this.label7.Location = new System.Drawing.Point(649, -19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 73);
            this.label7.TabIndex = 126;
            this.label7.Text = ".";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // closebtn
            // 
            this.closebtn.AutoSize = true;
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closebtn.ForeColor = System.Drawing.Color.DarkGray;
            this.closebtn.Image = global::KutuphaneOtomasyonu.Properties.Resources.cancel__2_;
            this.closebtn.Location = new System.Drawing.Point(695, -19);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(50, 73);
            this.closebtn.TabIndex = 125;
            this.closebtn.Text = ".";
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back.ForeColor = System.Drawing.Color.DimGray;
            this.back.ImageKey = "back-arrow.png";
            this.back.ImageList = this.ımageList1;
            this.back.Location = new System.Drawing.Point(695, 334);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 73);
            this.back.TabIndex = 127;
            this.back.Text = ".";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "back-arrow.png");
            // 
            // btnKitap
            // 
            this.btnKitap.Location = new System.Drawing.Point(515, 12);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(75, 35);
            this.btnKitap.TabIndex = 128;
            this.btnKitap.Text = "Kitap Oranları";
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // KitapKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 414);
            this.Controls.Add(this.btnKitap);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSıfırla);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgwKitaplar);
            this.Controls.Add(this.tbxYazar);
            this.Controls.Add(this.tbxSayfa);
            this.Controls.Add(this.tbxBarkod);
            this.Controls.Add(this.tbxAdet);
            this.Controls.Add(this.cbxKategori);
            this.Controls.Add(this.tbxAd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KitapKayit";
            this.Text = "KitapKayit";
            this.Load += new System.EventHandler(this.KitapKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.TextBox tbxAdet;
        private System.Windows.Forms.TextBox tbxBarkod;
        private System.Windows.Forms.TextBox tbxSayfa;
        private System.Windows.Forms.TextBox tbxYazar;
        private System.Windows.Forms.DataGridView dgwKitaplar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSıfırla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label closebtn;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnKitap;
    }
}