namespace CezaeviProgram.MahkumIslemleri
{
    partial class MahkumKogusBilgilendirme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MahkumKogusBilgilendirme));
            this.bilgilendirme = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilendirme)).BeginInit();
            this.SuspendLayout();
            // 
            // bilgilendirme
            // 
            this.bilgilendirme.AllowUserToAddRows = false;
            this.bilgilendirme.AllowUserToDeleteRows = false;
            this.bilgilendirme.AllowUserToResizeRows = false;
            this.bilgilendirme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bilgilendirme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(243)))), ((int)(((byte)(180)))));
            this.bilgilendirme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bilgilendirme.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bilgilendirme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bilgilendirme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bilgilendirme.ColumnHeadersHeight = 38;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(243)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bilgilendirme.DefaultCellStyle = dataGridViewCellStyle4;
            this.bilgilendirme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bilgilendirme.EnableHeadersVisualStyles = false;
            this.bilgilendirme.GridColor = System.Drawing.Color.Black;
            this.bilgilendirme.Location = new System.Drawing.Point(0, 0);
            this.bilgilendirme.MultiSelect = false;
            this.bilgilendirme.Name = "bilgilendirme";
            this.bilgilendirme.ReadOnly = true;
            this.bilgilendirme.RowHeadersVisible = false;
            this.bilgilendirme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bilgilendirme.Size = new System.Drawing.Size(412, 208);
            this.bilgilendirme.TabIndex = 64;
            this.bilgilendirme.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bilgilendirme_CellDoubleClick);
            // 
            // MahkumKogusBilgilendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(412, 208);
            this.Controls.Add(this.bilgilendirme);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MahkumKogusBilgilendirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MahkumKogusBilgilendirme";
            this.Load += new System.EventHandler(this.MahkumKogusBilgilendirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bilgilendirme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bilgilendirme;
    }
}