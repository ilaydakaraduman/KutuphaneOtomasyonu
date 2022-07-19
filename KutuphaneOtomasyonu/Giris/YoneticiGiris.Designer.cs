
namespace KutuphaneOtomasyonu.Giris
{
    partial class YoneticiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGiris));
            this.back = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Label();
            this.btnGirisi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.tbxTc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back.ForeColor = System.Drawing.Color.DarkGreen;
            this.back.ImageKey = "back-arrow.png";
            this.back.ImageList = this.ımageList1;
            this.back.Location = new System.Drawing.Point(538, 305);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 73);
            this.back.TabIndex = 20;
            this.back.Text = ".";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "back-arrow.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Image = global::KutuphaneOtomasyonu.Properties.Resources.remove__1_;
            this.label1.Location = new System.Drawing.Point(508, -12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 73);
            this.label1.TabIndex = 19;
            this.label1.Text = ".";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // closebtn
            // 
            this.closebtn.AutoSize = true;
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closebtn.ForeColor = System.Drawing.Color.DarkGray;
            this.closebtn.Image = global::KutuphaneOtomasyonu.Properties.Resources.cancel__2_;
            this.closebtn.Location = new System.Drawing.Point(553, -12);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(50, 73);
            this.closebtn.TabIndex = 18;
            this.closebtn.Text = ".";
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // btnGirisi
            // 
            this.btnGirisi.BackColor = System.Drawing.Color.White;
            this.btnGirisi.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGirisi.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGirisi.Location = new System.Drawing.Point(340, 293);
            this.btnGirisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnGirisi.Name = "btnGirisi";
            this.btnGirisi.Size = new System.Drawing.Size(84, 44);
            this.btnGirisi.TabIndex = 17;
            this.btnGirisi.Text = "GİRİŞ YAP";
            this.btnGirisi.UseVisualStyleBackColor = false;
            this.btnGirisi.Click += new System.EventHandler(this.btnGirisi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(257, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(63, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "TC:";
            // 
            // tbxSifre
            // 
            this.tbxSifre.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSifre.Location = new System.Drawing.Point(308, 188);
            this.tbxSifre.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSifre.Multiline = true;
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(116, 32);
            this.tbxSifre.TabIndex = 14;
            // 
            // tbxTc
            // 
            this.tbxTc.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTc.Location = new System.Drawing.Point(106, 148);
            this.tbxTc.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTc.Multiline = true;
            this.tbxTc.Name = "tbxTc";
            this.tbxTc.Size = new System.Drawing.Size(116, 29);
            this.tbxTc.TabIndex = 13;
            // 
            // YoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.kullanici;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 387);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.btnGirisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSifre);
            this.Controls.Add(this.tbxTc);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YoneticiGiris";
            this.Text = "YoneticiGİris";
            this.Load += new System.EventHandler(this.YoneticiGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label back;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closebtn;
        private System.Windows.Forms.Button btnGirisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.TextBox tbxTc;
    }
}