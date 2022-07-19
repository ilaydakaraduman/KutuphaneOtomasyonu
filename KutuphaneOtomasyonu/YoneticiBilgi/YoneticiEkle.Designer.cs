
namespace KutuphaneOtomasyonu.YoneticiBilgi
{
    partial class YoneticiEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiEkle));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnResimGüncelle = new System.Windows.Forms.Button();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.tbxDogumTarihi = new System.Windows.Forms.TextBox();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.tbxTc = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.cbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.pcbKullanici = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxArama = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwYonetici = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKullanici)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYonetici)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(-10, -3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 396);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.arkaplan;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.back);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.closebtn);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.Controls.Add(this.btnGüncelle);
            this.tabPage1.Controls.Add(this.btnResimGüncelle);
            this.tabPage1.Controls.Add(this.btnResimEkle);
            this.tabPage1.Controls.Add(this.tbxDogumTarihi);
            this.tabPage1.Controls.Add(this.tbxSifre);
            this.tabPage1.Controls.Add(this.tbxTc);
            this.tabPage1.Controls.Add(this.tbxSoyad);
            this.tabPage1.Controls.Add(this.cbxCinsiyet);
            this.tabPage1.Controls.Add(this.tbxAd);
            this.tabPage1.Controls.Add(this.pcbKullanici);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(623, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kayit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Location = new System.Drawing.Point(261, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 51);
            this.button1.TabIndex = 126;
            this.button1.Text = "SIFIRLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back.ForeColor = System.Drawing.Color.DarkGreen;
            this.back.ImageKey = "back-arrow.png";
            this.back.ImageList = this.ımageList1;
            this.back.Location = new System.Drawing.Point(568, 279);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 73);
            this.back.TabIndex = 125;
            this.back.Text = ".";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "back-arrow.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(524, -19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 73);
            this.label2.TabIndex = 124;
            this.label2.Text = ".";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // closebtn
            // 
            this.closebtn.AutoSize = true;
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closebtn.ForeColor = System.Drawing.Color.DarkGray;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.Location = new System.Drawing.Point(570, -19);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(50, 73);
            this.closebtn.TabIndex = 123;
            this.closebtn.Text = ".";
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label10.Location = new System.Drawing.Point(69, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 22);
            this.label10.TabIndex = 122;
            this.label10.Text = "İsim :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label13.Location = new System.Drawing.Point(302, 230);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 22);
            this.label13.TabIndex = 110;
            this.label13.Text = "Cinsiyet :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label14.Location = new System.Drawing.Point(17, 219);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 22);
            this.label14.TabIndex = 109;
            this.label14.Text = "Doğum Tarihi :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label15.Location = new System.Drawing.Point(325, 179);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 22);
            this.label15.TabIndex = 108;
            this.label15.Text = "Şifre :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label16.Location = new System.Drawing.Point(325, 127);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 22);
            this.label16.TabIndex = 107;
            this.label16.Text = "TC :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label17.Location = new System.Drawing.Point(58, 178);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 22);
            this.label17.TabIndex = 106;
            this.label17.Text = "Soyad :";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEkle.Location = new System.Drawing.Point(89, 314);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 51);
            this.btnEkle.TabIndex = 42;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGüncelle.Location = new System.Drawing.Point(413, 310);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(105, 51);
            this.btnGüncelle.TabIndex = 41;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnResimGüncelle
            // 
            this.btnResimGüncelle.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimGüncelle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnResimGüncelle.Location = new System.Drawing.Point(553, 209);
            this.btnResimGüncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnResimGüncelle.Name = "btnResimGüncelle";
            this.btnResimGüncelle.Size = new System.Drawing.Size(56, 37);
            this.btnResimGüncelle.TabIndex = 40;
            this.btnResimGüncelle.Text = "Resim Güncelle";
            this.btnResimGüncelle.UseVisualStyleBackColor = true;
            this.btnResimGüncelle.Click += new System.EventHandler(this.btnResimGüncelle_Click);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimEkle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnResimEkle.Location = new System.Drawing.Point(482, 209);
            this.btnResimEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(56, 37);
            this.btnResimEkle.TabIndex = 39;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // tbxDogumTarihi
            // 
            this.tbxDogumTarihi.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxDogumTarihi.Location = new System.Drawing.Point(143, 216);
            this.tbxDogumTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDogumTarihi.Name = "tbxDogumTarihi";
            this.tbxDogumTarihi.Size = new System.Drawing.Size(84, 25);
            this.tbxDogumTarihi.TabIndex = 36;
            // 
            // tbxSifre
            // 
            this.tbxSifre.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSifre.Location = new System.Drawing.Point(381, 176);
            this.tbxSifre.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(84, 25);
            this.tbxSifre.TabIndex = 35;
            // 
            // tbxTc
            // 
            this.tbxTc.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTc.Location = new System.Drawing.Point(381, 127);
            this.tbxTc.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTc.Name = "tbxTc";
            this.tbxTc.Size = new System.Drawing.Size(84, 25);
            this.tbxTc.TabIndex = 34;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSoyad.Location = new System.Drawing.Point(143, 178);
            this.tbxSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(84, 25);
            this.tbxSoyad.TabIndex = 33;
            // 
            // cbxCinsiyet
            // 
            this.cbxCinsiyet.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCinsiyet.FormattingEnabled = true;
            this.cbxCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cbxCinsiyet.Location = new System.Drawing.Point(381, 226);
            this.cbxCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCinsiyet.Name = "cbxCinsiyet";
            this.cbxCinsiyet.Size = new System.Drawing.Size(84, 26);
            this.cbxCinsiyet.TabIndex = 25;
            // 
            // tbxAd
            // 
            this.tbxAd.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAd.Location = new System.Drawing.Point(143, 130);
            this.tbxAd.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(84, 25);
            this.tbxAd.TabIndex = 24;
            this.tbxAd.TextChanged += new System.EventHandler(this.tbxAd_TextChanged);
            // 
            // pcbKullanici
            // 
            this.pcbKullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbKullanici.Location = new System.Drawing.Point(494, 91);
            this.pcbKullanici.Margin = new System.Windows.Forms.Padding(2);
            this.pcbKullanici.Name = "pcbKullanici";
            this.pcbKullanici.Size = new System.Drawing.Size(115, 110);
            this.pcbKullanici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbKullanici.TabIndex = 23;
            this.pcbKullanici.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.arkaplan;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbxArama);
            this.tabPage2.Controls.Add(this.btnSil);
            this.tabPage2.Controls.Add(this.dgwYonetici);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(623, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kullanicilar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.ImageKey = "back-arrow.png";
            this.label5.ImageList = this.ımageList1;
            this.label5.Location = new System.Drawing.Point(568, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 73);
            this.label5.TabIndex = 127;
            this.label5.Text = ".";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(520, -19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 73);
            this.label3.TabIndex = 126;
            this.label3.Text = ".";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(566, -19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 73);
            this.label4.TabIndex = 125;
            this.label4.Text = ".";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(167, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Arama";
            // 
            // tbxArama
            // 
            this.tbxArama.Location = new System.Drawing.Point(244, 11);
            this.tbxArama.Multiline = true;
            this.tbxArama.Name = "tbxArama";
            this.tbxArama.Size = new System.Drawing.Size(126, 31);
            this.tbxArama.TabIndex = 44;
            this.tbxArama.TextChanged += new System.EventHandler(this.tbxArama_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSil.Location = new System.Drawing.Point(280, 303);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(56, 37);
            this.btnSil.TabIndex = 43;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwYonetici
            // 
            this.dgwYonetici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwYonetici.Location = new System.Drawing.Point(70, 105);
            this.dgwYonetici.Margin = new System.Windows.Forms.Padding(2);
            this.dgwYonetici.Name = "dgwYonetici";
            this.dgwYonetici.RowTemplate.Height = 24;
            this.dgwYonetici.Size = new System.Drawing.Size(478, 183);
            this.dgwYonetici.TabIndex = 0;
            this.dgwYonetici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwYonetici_CellClick);
            // 
            // YoneticiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 389);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YoneticiEkle";
            this.Text = "YoneticiEkle";
            this.Load += new System.EventHandler(this.YoneticiEkle_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKullanici)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYonetici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label closebtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnResimGüncelle;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.TextBox tbxDogumTarihi;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.TextBox tbxTc;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.ComboBox cbxCinsiyet;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.PictureBox pcbKullanici;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxArama;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgwYonetici;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
    }
}