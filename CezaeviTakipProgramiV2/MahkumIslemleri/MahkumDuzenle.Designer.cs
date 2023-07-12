namespace CezaeviProgram.MahkumIslemleri
{
    partial class MahkumDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MahkumDuzenle));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.kimlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.anneAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.babaAdi = new System.Windows.Forms.TextBox();
            this.koguslar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlImages = new System.Windows.Forms.ImageList(this.components);
            this.pnlTopBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.closeButton);
            this.pnlTopBar.Controls.Add(this.label1);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(702, 26);
            this.pnlTopBar.TabIndex = 0;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ImageIndex = 1;
            this.closeButton.ImageList = this.imageList1;
            this.closeButton.Location = new System.Drawing.Point(678, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 26);
            this.closeButton.TabIndex = 3;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buyut.png");
            this.imageList1.Images.SetKeyName(1, "kapat.png");
            this.imageList1.Images.SetKeyName(2, "kucult.png");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(223, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mahkum Düzenleme Paneli";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kimlik, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.adi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.soyadi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.telefon, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.adres, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.anneAdi, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.babaAdi, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.koguslar, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 439);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 54);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kimlik Bilgisi ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kimlik
            // 
            this.kimlik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.kimlik.Location = new System.Drawing.Point(224, 3);
            this.kimlik.MaxLength = 11;
            this.kimlik.Name = "kimlik";
            this.kimlik.ReadOnly = true;
            this.kimlik.Size = new System.Drawing.Size(216, 24);
            this.kimlik.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 54);
            this.label4.TabIndex = 35;
            this.label4.Text = "Adı                ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adi
            // 
            this.adi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.adi.Location = new System.Drawing.Point(224, 57);
            this.adi.MaxLength = 50;
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(216, 24);
            this.adi.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 54);
            this.label3.TabIndex = 37;
            this.label3.Text = "Soyadı          ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soyadi
            // 
            this.soyadi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.soyadi.Location = new System.Drawing.Point(224, 111);
            this.soyadi.MaxLength = 50;
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(216, 24);
            this.soyadi.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(3, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 54);
            this.label5.TabIndex = 39;
            this.label5.Text = "Telefon         ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // telefon
            // 
            this.telefon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.telefon.Location = new System.Drawing.Point(224, 165);
            this.telefon.MaxLength = 10;
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(216, 24);
            this.telefon.TabIndex = 40;
            this.telefon.Text = "5";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(3, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 54);
            this.label8.TabIndex = 41;
            this.label8.Text = "Adres            ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // adres
            // 
            this.adres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.adres.Location = new System.Drawing.Point(224, 219);
            this.adres.MaxLength = 300;
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(216, 48);
            this.adres.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(3, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 54);
            this.label7.TabIndex = 43;
            this.label7.Text = "Anne Adı       ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // anneAdi
            // 
            this.anneAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.anneAdi.Location = new System.Drawing.Point(224, 273);
            this.anneAdi.MaxLength = 50;
            this.anneAdi.Name = "anneAdi";
            this.anneAdi.Size = new System.Drawing.Size(216, 24);
            this.anneAdi.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(3, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 54);
            this.label6.TabIndex = 45;
            this.label6.Text = "Baba Adı       ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // babaAdi
            // 
            this.babaAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.babaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.babaAdi.Location = new System.Drawing.Point(224, 327);
            this.babaAdi.MaxLength = 50;
            this.babaAdi.Name = "babaAdi";
            this.babaAdi.Size = new System.Drawing.Size(216, 24);
            this.babaAdi.TabIndex = 46;
            // 
            // koguslar
            // 
            this.koguslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.koguslar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.koguslar.FormattingEnabled = true;
            this.koguslar.Location = new System.Drawing.Point(224, 381);
            this.koguslar.Name = "koguslar";
            this.koguslar.Size = new System.Drawing.Size(216, 24);
            this.koguslar.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(3, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 61);
            this.label9.TabIndex = 47;
            this.label9.Text = "Koğuş ID       ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label5_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(443, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.73171F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.2683F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(259, 439);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(38, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Resim seçmek için dokunun";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(39, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 60);
            this.button1.TabIndex = 46;
            this.button1.Text = "Düzeni Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // controlImages
            // 
            this.controlImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("controlImages.ImageStream")));
            this.controlImages.TransparentColor = System.Drawing.Color.Transparent;
            this.controlImages.Images.SetKeyName(0, "kapat.png");
            this.controlImages.Images.SetKeyName(1, "kucult.png");
            // 
            // MahkumDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(702, 465);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlTopBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MahkumDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mahkum Düzenle";
            this.Load += new System.EventHandler(this.MahkumDuzenle_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox anneAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox babaAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox koguslar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList controlImages;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button closeButton;
    }
}