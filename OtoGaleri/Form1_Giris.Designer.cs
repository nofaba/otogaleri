namespace OtoGaleri
{
    partial class Form1_Giris
    {

        private System.ComponentModel.IContainer components = null;

>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.panelKullaniciGiris = new System.Windows.Forms.Panel();
            this.lblSifre_Unuttum = new System.Windows.Forms.Label();
            this.txtGiris_Sifre = new System.Windows.Forms.TextBox();
            this.txtGiris_Ad = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.panelKayit_Ol = new System.Windows.Forms.Panel();
            this.maskedTextBoxKayit_Tel = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxKayit = new System.Windows.Forms.PictureBox();
            this.btnFoto_Sec = new System.Windows.Forms.Button();
            this.btnKayit_Ol_Yeni_Kullanici = new System.Windows.Forms.Button();
            this.txtKayit_Foto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKayit_Mail = new System.Windows.Forms.TextBox();
            this.txtKayit_Sifre_Tekrar = new System.Windows.Forms.TextBox();
            this.txtKayit_Sifre = new System.Windows.Forms.TextBox();
            this.txtKayit_Ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSifremi_Unuttum = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSifre_Degistir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKontrolSifre2 = new System.Windows.Forms.TextBox();
            this.txtKontrolSifre1 = new System.Windows.Forms.TextBox();
            this.txtKontrolAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelKullaniciGiris.SuspendLayout();
            this.panelKayit_Ol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKayit)).BeginInit();
            this.panelSifremi_Unuttum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 360);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre: ";
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.Location = new System.Drawing.Point(48, 434);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(357, 62);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // panelKullaniciGiris
            // 
            this.panelKullaniciGiris.Controls.Add(this.pictureBox2);
            this.panelKullaniciGiris.Controls.Add(this.lblSifre_Unuttum);
            this.panelKullaniciGiris.Controls.Add(this.txtGiris_Sifre);
            this.panelKullaniciGiris.Controls.Add(this.txtGiris_Ad);
            this.panelKullaniciGiris.Controls.Add(this.label1);
            this.panelKullaniciGiris.Controls.Add(this.btnKayitOl);
            this.panelKullaniciGiris.Controls.Add(this.btnGiris);
            this.panelKullaniciGiris.Controls.Add(this.label2);
            this.panelKullaniciGiris.Location = new System.Drawing.Point(48, 283);
            this.panelKullaniciGiris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelKullaniciGiris.Name = "panelKullaniciGiris";
            this.panelKullaniciGiris.Size = new System.Drawing.Size(452, 642);
            this.panelKullaniciGiris.TabIndex = 3;
            // 
            // lblSifre_Unuttum
            // 
            this.lblSifre_Unuttum.AutoSize = true;
            this.lblSifre_Unuttum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre_Unuttum.Location = new System.Drawing.Point(129, 591);
            this.lblSifre_Unuttum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre_Unuttum.Name = "lblSifre_Unuttum";
            this.lblSifre_Unuttum.Size = new System.Drawing.Size(212, 29);
            this.lblSifre_Unuttum.TabIndex = 5;
            this.lblSifre_Unuttum.Text = "Şifremi Unuttum...";
            this.lblSifre_Unuttum.Click += new System.EventHandler(this.lblSifre_Unuttum_Click);
            // 
            // txtGiris_Sifre
            // 
            this.txtGiris_Sifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiris_Sifre.Location = new System.Drawing.Point(176, 355);
            this.txtGiris_Sifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiris_Sifre.Name = "txtGiris_Sifre";
            this.txtGiris_Sifre.Size = new System.Drawing.Size(228, 35);
            this.txtGiris_Sifre.TabIndex = 3;
            // 
            // txtGiris_Ad
            // 
            this.txtGiris_Ad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiris_Ad.Location = new System.Drawing.Point(176, 308);
            this.txtGiris_Ad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiris_Ad.Name = "txtGiris_Ad";
            this.txtGiris_Ad.Size = new System.Drawing.Size(228, 35);
            this.txtGiris_Ad.TabIndex = 3;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitOl.Location = new System.Drawing.Point(48, 505);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(357, 62);
            this.btnKayitOl.TabIndex = 2;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // panelKayit_Ol
            // 
            this.panelKayit_Ol.Controls.Add(this.maskedTextBoxKayit_Tel);
            this.panelKayit_Ol.Controls.Add(this.pictureBoxKayit);
            this.panelKayit_Ol.Controls.Add(this.btnFoto_Sec);
            this.panelKayit_Ol.Controls.Add(this.btnKayit_Ol_Yeni_Kullanici);
            this.panelKayit_Ol.Controls.Add(this.txtKayit_Foto);
            this.panelKayit_Ol.Controls.Add(this.label9);
            this.panelKayit_Ol.Controls.Add(this.label8);
            this.panelKayit_Ol.Controls.Add(this.label7);
            this.panelKayit_Ol.Controls.Add(this.label5);
            this.panelKayit_Ol.Controls.Add(this.txtKayit_Mail);
            this.panelKayit_Ol.Controls.Add(this.txtKayit_Sifre_Tekrar);
            this.panelKayit_Ol.Controls.Add(this.txtKayit_Sifre);
            this.panelKayit_Ol.Controls.Add(this.txtKayit_Ad);
            this.panelKayit_Ol.Controls.Add(this.label6);
            this.panelKayit_Ol.Controls.Add(this.label4);
            this.panelKayit_Ol.Location = new System.Drawing.Point(1234, 138);
            this.panelKayit_Ol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelKayit_Ol.Name = "panelKayit_Ol";
            this.panelKayit_Ol.Size = new System.Drawing.Size(597, 786);
            this.panelKayit_Ol.TabIndex = 4;
            // 
            // maskedTextBoxKayit_Tel
            // 
            this.maskedTextBoxKayit_Tel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxKayit_Tel.Location = new System.Drawing.Point(206, 400);
            this.maskedTextBoxKayit_Tel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBoxKayit_Tel.Mask = "(999) 000-0000";
            this.maskedTextBoxKayit_Tel.Name = "maskedTextBoxKayit_Tel";
            this.maskedTextBoxKayit_Tel.Size = new System.Drawing.Size(228, 35);
            this.maskedTextBoxKayit_Tel.TabIndex = 10;
            // 
            // pictureBoxKayit
            // 
            this.pictureBoxKayit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKayit.Image")));
            this.pictureBoxKayit.Location = new System.Drawing.Point(206, 22);
            this.pictureBoxKayit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxKayit.Name = "pictureBoxKayit";
            this.pictureBoxKayit.Size = new System.Drawing.Size(195, 234);
            this.pictureBoxKayit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKayit.TabIndex = 8;
            this.pictureBoxKayit.TabStop = false;
            // 
            // btnFoto_Sec
            // 
            this.btnFoto_Sec.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto_Sec.Location = new System.Drawing.Point(444, 469);
            this.btnFoto_Sec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFoto_Sec.Name = "btnFoto_Sec";
            this.btnFoto_Sec.Size = new System.Drawing.Size(74, 35);
            this.btnFoto_Sec.TabIndex = 7;
            this.btnFoto_Sec.Text = "...";
            this.btnFoto_Sec.UseVisualStyleBackColor = true;
            this.btnFoto_Sec.Click += new System.EventHandler(this.btnFoto_Sec_Click);
            // 
            // btnKayit_Ol_Yeni_Kullanici
            // 
            this.btnKayit_Ol_Yeni_Kullanici.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayit_Ol_Yeni_Kullanici.Location = new System.Drawing.Point(78, 669);
            this.btnKayit_Ol_Yeni_Kullanici.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKayit_Ol_Yeni_Kullanici.Name = "btnKayit_Ol_Yeni_Kullanici";
            this.btnKayit_Ol_Yeni_Kullanici.Size = new System.Drawing.Size(357, 62);
            this.btnKayit_Ol_Yeni_Kullanici.TabIndex = 6;
            this.btnKayit_Ol_Yeni_Kullanici.Text = "KAYIT OL";
            this.btnKayit_Ol_Yeni_Kullanici.UseVisualStyleBackColor = true;
            this.btnKayit_Ol_Yeni_Kullanici.Click += new System.EventHandler(this.btnKayit_Ol_Yeni_Kullanici_Click);
            // 
            // txtKayit_Foto
            // 
            this.txtKayit_Foto.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKayit_Foto.Location = new System.Drawing.Point(206, 466);
            this.txtKayit_Foto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKayit_Foto.Name = "txtKayit_Foto";
            this.txtKayit_Foto.Size = new System.Drawing.Size(228, 35);
            this.txtKayit_Foto.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 472);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "Foto: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 594);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Şifre Tekrar: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 526);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Şifre: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mail: ";
            // 
            // txtKayit_Mail
            // 
            this.txtKayit_Mail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKayit_Mail.Location = new System.Drawing.Point(206, 334);
            this.txtKayit_Mail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKayit_Mail.Name = "txtKayit_Mail";
            this.txtKayit_Mail.Size = new System.Drawing.Size(228, 35);
            this.txtKayit_Mail.TabIndex = 3;
            // 
            // txtKayit_Sifre_Tekrar
            // 
            this.txtKayit_Sifre_Tekrar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKayit_Sifre_Tekrar.Location = new System.Drawing.Point(206, 588);
            this.txtKayit_Sifre_Tekrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKayit_Sifre_Tekrar.Name = "txtKayit_Sifre_Tekrar";
            this.txtKayit_Sifre_Tekrar.Size = new System.Drawing.Size(228, 35);
            this.txtKayit_Sifre_Tekrar.TabIndex = 3;
            // 
            // txtKayit_Sifre
            // 
            this.txtKayit_Sifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKayit_Sifre.Location = new System.Drawing.Point(206, 528);
            this.txtKayit_Sifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKayit_Sifre.Name = "txtKayit_Sifre";
            this.txtKayit_Sifre.Size = new System.Drawing.Size(228, 35);
            this.txtKayit_Sifre.TabIndex = 3;
            // 
            // txtKayit_Ad
            // 
            this.txtKayit_Ad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKayit_Ad.Location = new System.Drawing.Point(206, 265);
            this.txtKayit_Ad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKayit_Ad.Name = "txtKayit_Ad";
            this.txtKayit_Ad.Size = new System.Drawing.Size(228, 35);
            this.txtKayit_Ad.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 405);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adı Soyadı: ";
            // 
            // panelSifremi_Unuttum
            // 
            this.panelSifremi_Unuttum.BackColor = System.Drawing.Color.White;
            this.panelSifremi_Unuttum.Controls.Add(this.pictureBox3);
            this.panelSifremi_Unuttum.Controls.Add(this.btnSifre_Degistir);
            this.panelSifremi_Unuttum.Controls.Add(this.label11);
            this.panelSifremi_Unuttum.Controls.Add(this.label12);
            this.panelSifremi_Unuttum.Controls.Add(this.txtKontrolSifre2);
            this.panelSifremi_Unuttum.Controls.Add(this.txtKontrolSifre1);
            this.panelSifremi_Unuttum.Controls.Add(this.txtKontrolAd);
            this.panelSifremi_Unuttum.Controls.Add(this.label10);
            this.panelSifremi_Unuttum.Location = new System.Drawing.Point(658, 348);
            this.panelSifremi_Unuttum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSifremi_Unuttum.Name = "panelSifremi_Unuttum";
            this.panelSifremi_Unuttum.Size = new System.Drawing.Size(459, 576);
            this.panelSifremi_Unuttum.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(138, 49);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 188);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // btnSifre_Degistir
            // 
            this.btnSifre_Degistir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifre_Degistir.Location = new System.Drawing.Point(63, 486);
            this.btnSifre_Degistir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSifre_Degistir.Name = "btnSifre_Degistir";
            this.btnSifre_Degistir.Size = new System.Drawing.Size(357, 62);
            this.btnSifre_Degistir.TabIndex = 7;
            this.btnSifre_Degistir.Text = "GÜNCELLE";
            this.btnSifre_Degistir.UseVisualStyleBackColor = true;
            this.btnSifre_Degistir.Click += new System.EventHandler(this.btnSifre_Degistir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 434);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 29);
            this.label11.TabIndex = 6;
            this.label11.Text = "Şifre Tekrar: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(111, 366);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 29);
            this.label12.TabIndex = 7;
            this.label12.Text = "Şifre: ";
            // 
            // txtKontrolSifre2
            // 
            this.txtKontrolSifre2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontrolSifre2.Location = new System.Drawing.Point(189, 425);
            this.txtKontrolSifre2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKontrolSifre2.Name = "txtKontrolSifre2";
            this.txtKontrolSifre2.Size = new System.Drawing.Size(228, 35);
            this.txtKontrolSifre2.TabIndex = 8;
            // 
            // txtKontrolSifre1
            // 
            this.txtKontrolSifre1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontrolSifre1.Location = new System.Drawing.Point(189, 365);
            this.txtKontrolSifre1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKontrolSifre1.Name = "txtKontrolSifre1";
            this.txtKontrolSifre1.Size = new System.Drawing.Size(228, 35);
            this.txtKontrolSifre1.TabIndex = 9;
            // 
            // txtKontrolAd
            // 
            this.txtKontrolAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKontrolAd.Location = new System.Drawing.Point(190, 300);
            this.txtKontrolAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKontrolAd.Name = "txtKontrolAd";
            this.txtKontrolAd.Size = new System.Drawing.Size(228, 35);
            this.txtKontrolAd.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 308);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "Ad Soyad: ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1876, 972);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(134, 65);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 188);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1876, 972);
            this.Controls.Add(this.panelSifremi_Unuttum);
            this.Controls.Add(this.panelKayit_Ol);
            this.Controls.Add(this.panelKullaniciGiris);
            this.Controls.Add(this.pictureBox4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.Form1_Giris_Load);
            this.panelKullaniciGiris.ResumeLayout(false);
            this.panelKullaniciGiris.PerformLayout();
            this.panelKayit_Ol.ResumeLayout(false);
            this.panelKayit_Ol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKayit)).EndInit();
            this.panelSifremi_Unuttum.ResumeLayout(false);
            this.panelSifremi_Unuttum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Panel panelKullaniciGiris;
        private System.Windows.Forms.TextBox txtGiris_Sifre;
        private System.Windows.Forms.TextBox txtGiris_Ad;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Label lblSifre_Unuttum;
        private System.Windows.Forms.Panel panelKayit_Ol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKayit_Mail;
        private System.Windows.Forms.TextBox txtKayit_Sifre_Tekrar;
        private System.Windows.Forms.TextBox txtKayit_Sifre;
        private System.Windows.Forms.TextBox txtKayit_Ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxKayit;
        private System.Windows.Forms.Button btnFoto_Sec;
        private System.Windows.Forms.Button btnKayit_Ol_Yeni_Kullanici;
        private System.Windows.Forms.TextBox txtKayit_Foto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelSifremi_Unuttum;
        private System.Windows.Forms.Button btnSifre_Degistir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKontrolSifre2;
        private System.Windows.Forms.TextBox txtKontrolSifre1;
        private System.Windows.Forms.TextBox txtKontrolAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKayit_Tel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

