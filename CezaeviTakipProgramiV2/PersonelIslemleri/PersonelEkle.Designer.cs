namespace CezaeviProgram.PersonelIslemleri
{
    partial class PersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnKucult = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnBuyut = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblPnl3 = new System.Windows.Forms.TableLayoutPanel();
            this.gorevYerBilgi = new System.Windows.Forms.TextBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tblPnl4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gorevYeri = new System.Windows.Forms.ComboBox();
            this.tblPnl2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.tblPnl1 = new System.Windows.Forms.TableLayoutPanel();
            this.maas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.giris = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.babaAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kimlik = new System.Windows.Forms.TextBox();
            this.lblPersonelTipi = new System.Windows.Forms.Label();
            this.personelTipi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.anneAdi = new System.Windows.Forms.TextBox();
            this.pnlTopBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tblPnl3.SuspendLayout();
            this.tblPnl4.SuspendLayout();
            this.tblPnl2.SuspendLayout();
            this.tblPnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Gray;
            this.pnlTopBar.Controls.Add(this.panel3);
            this.pnlTopBar.Controls.Add(this.label13);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(579, 39);
            this.pnlTopBar.TabIndex = 0;
            this.pnlTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopBar_Paint);
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnKucult);
            this.panel3.Controls.Add(this.btnBuyut);
            this.panel3.Controls.Add(this.btnKapat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(503, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 39);
            this.panel3.TabIndex = 4;
            // 
            // btnKucult
            // 
            this.btnKucult.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKucult.FlatAppearance.BorderSize = 0;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.ImageKey = "kucult.png";
            this.btnKucult.ImageList = this.imageList2;
            this.btnKucult.Location = new System.Drawing.Point(4, 0);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(24, 39);
            this.btnKucult.TabIndex = 2;
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "buyut.png");
            this.imageList2.Images.SetKeyName(1, "kapat.png");
            this.imageList2.Images.SetKeyName(2, "kucult.png");
            // 
            // btnBuyut
            // 
            this.btnBuyut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuyut.FlatAppearance.BorderSize = 0;
            this.btnBuyut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyut.ImageKey = "buyut.png";
            this.btnBuyut.ImageList = this.imageList2;
            this.btnBuyut.Location = new System.Drawing.Point(28, 0);
            this.btnBuyut.Name = "btnBuyut";
            this.btnBuyut.Size = new System.Drawing.Size(24, 39);
            this.btnBuyut.TabIndex = 1;
            this.btnBuyut.UseVisualStyleBackColor = true;
            this.btnBuyut.Click += new System.EventHandler(this.btnBuyut_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ImageKey = "kapat.png";
            this.btnKapat.ImageList = this.imageList2;
            this.btnKapat.Location = new System.Drawing.Point(52, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(24, 39);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(216, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = "Personel Ekle";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            this.label13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove);
            this.label13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tblPnl3);
            this.panel2.Controls.Add(this.tblPnl4);
            this.panel2.Controls.Add(this.tblPnl2);
            this.panel2.Controls.Add(this.tblPnl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 372);
            this.panel2.TabIndex = 2;
            // 
            // tblPnl3
            // 
            this.tblPnl3.ColumnCount = 1;
            this.tblPnl3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.58363F));
            this.tblPnl3.Controls.Add(this.gorevYerBilgi, 0, 0);
            this.tblPnl3.Controls.Add(this.btnPersonelEkle, 0, 1);
            this.tblPnl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnl3.Location = new System.Drawing.Point(304, 205);
            this.tblPnl3.Name = "tblPnl3";
            this.tblPnl3.RowCount = 2;
            this.tblPnl3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPnl3.Size = new System.Drawing.Size(275, 167);
            this.tblPnl3.TabIndex = 4;
            // 
            // gorevYerBilgi
            // 
            this.gorevYerBilgi.BackColor = System.Drawing.SystemColors.Window;
            this.gorevYerBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gorevYerBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.gorevYerBilgi.Location = new System.Drawing.Point(3, 3);
            this.gorevYerBilgi.Multiline = true;
            this.gorevYerBilgi.Name = "gorevYerBilgi";
            this.gorevYerBilgi.ReadOnly = true;
            this.gorevYerBilgi.Size = new System.Drawing.Size(269, 77);
            this.gorevYerBilgi.TabIndex = 135;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPersonelEkle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnPersonelEkle.ForeColor = System.Drawing.Color.Black;
            this.btnPersonelEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelEkle.ImageIndex = 0;
            this.btnPersonelEkle.ImageList = this.imageList1;
            this.btnPersonelEkle.Location = new System.Drawing.Point(3, 86);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(269, 78);
            this.btnPersonelEkle.TabIndex = 138;
            this.btnPersonelEkle.Text = "Personeli Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ekle.png");
            // 
            // tblPnl4
            // 
            this.tblPnl4.ColumnCount = 2;
            this.tblPnl4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl4.Controls.Add(this.label1, 0, 0);
            this.tblPnl4.Controls.Add(this.gorevYeri, 1, 0);
            this.tblPnl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPnl4.Location = new System.Drawing.Point(304, 164);
            this.tblPnl4.Name = "tblPnl4";
            this.tblPnl4.RowCount = 1;
            this.tblPnl4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl4.Size = new System.Drawing.Size(275, 41);
            this.tblPnl4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Olive;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 41);
            this.label1.TabIndex = 128;
            this.label1.Text = "Görev Yeri   ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gorevYeri
            // 
            this.gorevYeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gorevYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gorevYeri.FormattingEnabled = true;
            this.gorevYeri.Location = new System.Drawing.Point(140, 3);
            this.gorevYeri.Name = "gorevYeri";
            this.gorevYeri.Size = new System.Drawing.Size(132, 24);
            this.gorevYeri.TabIndex = 133;
            this.gorevYeri.SelectedIndexChanged += new System.EventHandler(this.gorevYeri_SelectedIndexChanged);
            this.gorevYeri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.disable_KeyDown);
            // 
            // tblPnl2
            // 
            this.tblPnl2.ColumnCount = 1;
            this.tblPnl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl2.Controls.Add(this.label6, 0, 0);
            this.tblPnl2.Controls.Add(this.adres, 0, 1);
            this.tblPnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPnl2.Location = new System.Drawing.Point(304, 0);
            this.tblPnl2.Name = "tblPnl2";
            this.tblPnl2.RowCount = 2;
            this.tblPnl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.71289F));
            this.tblPnl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.28711F));
            this.tblPnl2.Size = new System.Drawing.Size(275, 164);
            this.tblPnl2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Olive;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 61);
            this.label6.TabIndex = 121;
            this.label6.Text = "Adres";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adres
            // 
            this.adres.BackColor = System.Drawing.SystemColors.Window;
            this.adres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.adres.Location = new System.Drawing.Point(3, 64);
            this.adres.MaxLength = 300;
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(269, 97);
            this.adres.TabIndex = 124;
            // 
            // tblPnl1
            // 
            this.tblPnl1.ColumnCount = 2;
            this.tblPnl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl1.Controls.Add(this.maas, 1, 9);
            this.tblPnl1.Controls.Add(this.label12, 0, 9);
            this.tblPnl1.Controls.Add(this.cikis, 1, 8);
            this.tblPnl1.Controls.Add(this.label11, 0, 8);
            this.tblPnl1.Controls.Add(this.giris, 1, 7);
            this.tblPnl1.Controls.Add(this.label9, 0, 7);
            this.tblPnl1.Controls.Add(this.telefon, 1, 6);
            this.tblPnl1.Controls.Add(this.label5, 0, 6);
            this.tblPnl1.Controls.Add(this.babaAdi, 1, 5);
            this.tblPnl1.Controls.Add(this.label8, 0, 5);
            this.tblPnl1.Controls.Add(this.label7, 0, 4);
            this.tblPnl1.Controls.Add(this.label2, 0, 0);
            this.tblPnl1.Controls.Add(this.kimlik, 1, 0);
            this.tblPnl1.Controls.Add(this.lblPersonelTipi, 0, 1);
            this.tblPnl1.Controls.Add(this.personelTipi, 1, 1);
            this.tblPnl1.Controls.Add(this.label3, 0, 2);
            this.tblPnl1.Controls.Add(this.adi, 1, 2);
            this.tblPnl1.Controls.Add(this.label4, 0, 3);
            this.tblPnl1.Controls.Add(this.soyadi, 1, 3);
            this.tblPnl1.Controls.Add(this.anneAdi, 1, 4);
            this.tblPnl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tblPnl1.Location = new System.Drawing.Point(0, 0);
            this.tblPnl1.Name = "tblPnl1";
            this.tblPnl1.RowCount = 10;
            this.tblPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPnl1.Size = new System.Drawing.Size(304, 372);
            this.tblPnl1.TabIndex = 2;
            // 
            // maas
            // 
            this.maas.BackColor = System.Drawing.SystemColors.Window;
            this.maas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.maas.Location = new System.Drawing.Point(155, 336);
            this.maas.MaxLength = 11;
            this.maas.Multiline = true;
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(146, 33);
            this.maas.TabIndex = 137;
            this.maas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sNum_KeyPress);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Olive;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label12.Location = new System.Drawing.Point(3, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 39);
            this.label12.TabIndex = 136;
            this.label12.Text = "Maaş           ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cikis
            // 
            this.cikis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cikis.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.cikis.CustomFormat = "HH:mm:ss";
            this.cikis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cikis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cikis.Location = new System.Drawing.Point(155, 299);
            this.cikis.Name = "cikis";
            this.cikis.ShowUpDown = true;
            this.cikis.Size = new System.Drawing.Size(146, 24);
            this.cikis.TabIndex = 134;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Olive;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.Location = new System.Drawing.Point(3, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 37);
            this.label11.TabIndex = 133;
            this.label11.Text = "Çıkış Saati   ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // giris
            // 
            this.giris.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.giris.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.giris.CustomFormat = "HH:mm:ss";
            this.giris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.giris.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.giris.Location = new System.Drawing.Point(155, 262);
            this.giris.Name = "giris";
            this.giris.ShowUpDown = true;
            this.giris.Size = new System.Drawing.Size(146, 24);
            this.giris.TabIndex = 132;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Olive;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(3, 259);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 37);
            this.label9.TabIndex = 131;
            this.label9.Text = "Giriş Saati    ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefon
            // 
            this.telefon.BackColor = System.Drawing.SystemColors.Window;
            this.telefon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.telefon.Location = new System.Drawing.Point(155, 225);
            this.telefon.MaxLength = 10;
            this.telefon.Multiline = true;
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(146, 31);
            this.telefon.TabIndex = 130;
            this.telefon.Text = "5";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Olive;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(3, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 37);
            this.label5.TabIndex = 129;
            this.label5.Text = "Telefon        ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // babaAdi
            // 
            this.babaAdi.BackColor = System.Drawing.SystemColors.Window;
            this.babaAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.babaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.babaAdi.Location = new System.Drawing.Point(155, 188);
            this.babaAdi.MaxLength = 50;
            this.babaAdi.Multiline = true;
            this.babaAdi.Name = "babaAdi";
            this.babaAdi.Size = new System.Drawing.Size(146, 31);
            this.babaAdi.TabIndex = 128;
            this.babaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Olive;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(3, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 37);
            this.label8.TabIndex = 127;
            this.label8.Text = "Baba Adı      ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Olive;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(3, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 37);
            this.label7.TabIndex = 122;
            this.label7.Text = "Anne Adı      ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Olive;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 37);
            this.label2.TabIndex = 112;
            this.label2.Text = "Kimlik            ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kimlik
            // 
            this.kimlik.BackColor = System.Drawing.SystemColors.Window;
            this.kimlik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.kimlik.Location = new System.Drawing.Point(155, 3);
            this.kimlik.MaxLength = 11;
            this.kimlik.Multiline = true;
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(146, 31);
            this.kimlik.TabIndex = 117;
            this.kimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // lblPersonelTipi
            // 
            this.lblPersonelTipi.BackColor = System.Drawing.Color.Olive;
            this.lblPersonelTipi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPersonelTipi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPersonelTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPersonelTipi.Location = new System.Drawing.Point(3, 37);
            this.lblPersonelTipi.Name = "lblPersonelTipi";
            this.lblPersonelTipi.Size = new System.Drawing.Size(146, 37);
            this.lblPersonelTipi.TabIndex = 118;
            this.lblPersonelTipi.Text = "Personel Tipi";
            this.lblPersonelTipi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPersonelTipi.Click += new System.EventHandler(this.lblPersonelTipi_Click);
            // 
            // personelTipi
            // 
            this.personelTipi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personelTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.personelTipi.FormattingEnabled = true;
            this.personelTipi.Location = new System.Drawing.Point(155, 40);
            this.personelTipi.Name = "personelTipi";
            this.personelTipi.Size = new System.Drawing.Size(146, 24);
            this.personelTipi.TabIndex = 119;
            this.personelTipi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.disable_KeyDown);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Olive;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 37);
            this.label3.TabIndex = 120;
            this.label3.Text = "Adı                ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adi
            // 
            this.adi.BackColor = System.Drawing.SystemColors.Window;
            this.adi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.adi.Location = new System.Drawing.Point(155, 77);
            this.adi.MaxLength = 50;
            this.adi.Multiline = true;
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(146, 31);
            this.adi.TabIndex = 121;
            this.adi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Olive;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 37);
            this.label4.TabIndex = 122;
            this.label4.Text = "Soyadı          ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soyadi
            // 
            this.soyadi.BackColor = System.Drawing.SystemColors.Window;
            this.soyadi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.soyadi.Location = new System.Drawing.Point(155, 114);
            this.soyadi.MaxLength = 50;
            this.soyadi.Multiline = true;
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(146, 31);
            this.soyadi.TabIndex = 123;
            this.soyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // anneAdi
            // 
            this.anneAdi.BackColor = System.Drawing.SystemColors.Window;
            this.anneAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.anneAdi.Location = new System.Drawing.Point(155, 151);
            this.anneAdi.MaxLength = 50;
            this.anneAdi.Multiline = true;
            this.anneAdi.Name = "anneAdi";
            this.anneAdi.Size = new System.Drawing.Size(146, 31);
            this.anneAdi.TabIndex = 126;
            this.anneAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(579, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(556, 411);
            this.Name = "PersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tblPnl3.ResumeLayout(false);
            this.tblPnl3.PerformLayout();
            this.tblPnl4.ResumeLayout(false);
            this.tblPnl4.PerformLayout();
            this.tblPnl2.ResumeLayout(false);
            this.tblPnl2.PerformLayout();
            this.tblPnl1.ResumeLayout(false);
            this.tblPnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tblPnl3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox gorevYerBilgi;
        private System.Windows.Forms.TableLayoutPanel tblPnl4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox gorevYeri;
        private System.Windows.Forms.TableLayoutPanel tblPnl2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TableLayoutPanel tblPnl1;
        private System.Windows.Forms.TextBox maas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker cikis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker giris;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox babaAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.Label lblPersonelTipi;
        private System.Windows.Forms.ComboBox personelTipi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.TextBox anneAdi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnBuyut;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnPersonelEkle;
    }
}