namespace CezaeviProgram.IzinIslemleri
{
    partial class IzinSorgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzinSorgu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tarihBitis = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tarihBaslangic = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.kimlik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.izinKaydınıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.detay = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tarihBitis
            // 
            this.tarihBitis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tarihBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarihBitis.Location = new System.Drawing.Point(148, 79);
            this.tarihBitis.Name = "tarihBitis";
            this.tarihBitis.Size = new System.Drawing.Size(160, 20);
            this.tarihBitis.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "ekle.png";
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(520, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 54);
            this.button3.TabIndex = 28;
            this.button3.Text = "Yeni İzin";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sil.png");
            this.imageList1.Images.SetKeyName(1, "izin.png");
            this.imageList1.Images.SetKeyName(2, "ekle.png");
            this.imageList1.Images.SetKeyName(3, "calistir.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "calistir.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(227, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 54);
            this.button2.TabIndex = 27;
            this.button2.Text = "     Sorgulama Yap";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(341, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "İzin Detayı";
            // 
            // tarihBaslangic
            // 
            this.tarihBaslangic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tarihBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarihBaslangic.Location = new System.Drawing.Point(148, 48);
            this.tarihBaslangic.Name = "tarihBaslangic";
            this.tarihBaslangic.Size = new System.Drawing.Size(160, 20);
            this.tarihBaslangic.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "sil.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(11, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 54);
            this.button1.TabIndex = 26;
            this.button1.Text = "    Parametreleri\r\n   Temizle\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kimlik
            // 
            this.kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kimlik.Location = new System.Drawing.Point(148, 14);
            this.kimlik.MaxLength = 11;
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(160, 23);
            this.kimlik.TabIndex = 25;
            this.kimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kimlik_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tarih Bitiş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kimlik";
            // 
            // sdfToolStripMenuItem
            // 
            this.sdfToolStripMenuItem.Name = "sdfToolStripMenuItem";
            this.sdfToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.sdfToolStripMenuItem.Text = "İzin Kaydını Sil";
            this.sdfToolStripMenuItem.Click += new System.EventHandler(this.sdfToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfToolStripMenuItem,
            this.izinKaydınıDüzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 48);
            // 
            // izinKaydınıDüzenleToolStripMenuItem
            // 
            this.izinKaydınıDüzenleToolStripMenuItem.Name = "izinKaydınıDüzenleToolStripMenuItem";
            this.izinKaydınıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.izinKaydınıDüzenleToolStripMenuItem.Text = "İzin Açıklamasını Düzenle";
            this.izinKaydınıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.izinKaydiniDuzenleToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tarih Başlangıç";
            // 
            // detay
            // 
            this.detay.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detay.Location = new System.Drawing.Point(439, 12);
            this.detay.Multiline = true;
            this.detay.Name = "detay";
            this.detay.ReadOnly = true;
            this.detay.Size = new System.Drawing.Size(279, 97);
            this.detay.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(243)))), ((int)(((byte)(180)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 38;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(243)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(11, 176);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(707, 262);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IzinSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.detay);
            this.Controls.Add(this.tarihBitis);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tarihBaslangic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IzinSorgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IzinSorgu";
            this.Load += new System.EventHandler(this.IzinSorgu_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tarihBitis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tarihBaslangic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem sdfToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox detay;
        private System.Windows.Forms.ToolStripMenuItem izinKaydınıDüzenleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}