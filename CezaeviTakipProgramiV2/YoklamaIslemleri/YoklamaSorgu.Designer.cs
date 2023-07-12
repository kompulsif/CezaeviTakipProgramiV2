namespace CezaeviProgram
{
    partial class YoklamaSorgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoklamaSorgu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliKaydıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kimlik = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.durum = new System.Windows.Forms.ComboBox();
            this.tarihBaslangic = new System.Windows.Forms.DateTimePicker();
            this.tarihBitis = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfToolStripMenuItem,
            this.seçiliKaydıDüzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 48);
            // 
            // sdfToolStripMenuItem
            // 
            this.sdfToolStripMenuItem.Name = "sdfToolStripMenuItem";
            this.sdfToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sdfToolStripMenuItem.Text = "Seçili Kaydı Sil";
            this.sdfToolStripMenuItem.Click += new System.EventHandler(this.sdfToolStripMenuItem_Click);
            // 
            // seçiliKaydıDüzenleToolStripMenuItem
            // 
            this.seçiliKaydıDüzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.varToolStripMenuItem,
            this.yokToolStripMenuItem});
            this.seçiliKaydıDüzenleToolStripMenuItem.Name = "seçiliKaydıDüzenleToolStripMenuItem";
            this.seçiliKaydıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.seçiliKaydıDüzenleToolStripMenuItem.Text = "Kayıt Durum Değiştir";
            // 
            // varToolStripMenuItem
            // 
            this.varToolStripMenuItem.Name = "varToolStripMenuItem";
            this.varToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.varToolStripMenuItem.Text = "Var";
            this.varToolStripMenuItem.Click += new System.EventHandler(this.varToolStripMenuItem_Click);
            // 
            // yokToolStripMenuItem
            // 
            this.yokToolStripMenuItem.Name = "yokToolStripMenuItem";
            this.yokToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.yokToolStripMenuItem.Text = "Yok";
            this.yokToolStripMenuItem.Click += new System.EventHandler(this.yokToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kimlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih Başlangıç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(336, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarih Bitiş";
            // 
            // kimlik
            // 
            this.kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kimlik.Location = new System.Drawing.Point(149, 29);
            this.kimlik.MaxLength = 11;
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(160, 23);
            this.kimlik.TabIndex = 8;
            this.kimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kimlik_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "sil.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(149, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "    Parametreleri\r\n   Temizle\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "calistir.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(433, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 54);
            this.button2.TabIndex = 15;
            this.button2.Text = "     Sorgulama Yap";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.ImageKey = "ekle.png";
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(620, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 133);
            this.button3.TabIndex = 16;
            this.button3.Text = "\r\n\r\n\r\n\r\n\r\nYeni Kayıt Ekle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(336, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Durum";
            // 
            // durum
            // 
            this.durum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.durum.FormattingEnabled = true;
            this.durum.Location = new System.Drawing.Point(433, 30);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(160, 21);
            this.durum.TabIndex = 17;
            this.durum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.durum_KeyDown);
            // 
            // tarihBaslangic
            // 
            this.tarihBaslangic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tarihBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarihBaslangic.Location = new System.Drawing.Point(149, 66);
            this.tarihBaslangic.Name = "tarihBaslangic";
            this.tarihBaslangic.Size = new System.Drawing.Size(160, 20);
            this.tarihBaslangic.TabIndex = 18;
            // 
            // tarihBitis
            // 
            this.tarihBitis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tarihBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarihBitis.Location = new System.Drawing.Point(433, 66);
            this.tarihBitis.Name = "tarihBitis";
            this.tarihBitis.Size = new System.Drawing.Size(160, 20);
            this.tarihBitis.TabIndex = 19;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 38;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(243)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 185);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(731, 262);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // YoklamaSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(731, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tarihBitis);
            this.Controls.Add(this.tarihBaslangic);
            this.Controls.Add(this.durum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(747, 486);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(747, 486);
            this.Name = "YoklamaSorgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yoklama Sorgu Paneli";
            this.Load += new System.EventHandler(this.YoklamaSorgu_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliKaydıDüzenleToolStripMenuItem;
        private System.Windows.Forms.TextBox kimlik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox durum;
        private System.Windows.Forms.DateTimePicker tarihBaslangic;
        private System.Windows.Forms.DateTimePicker tarihBitis;
        private System.Windows.Forms.ToolStripMenuItem varToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yokToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}