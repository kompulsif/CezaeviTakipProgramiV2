namespace CezaeviProgram
{
    partial class FirmaSecim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaSecim));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwFirmaSecim = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFirmaSecim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Seçim Paneli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwFirmaSecim
            // 
            this.dgwFirmaSecim.AllowUserToAddRows = false;
            this.dgwFirmaSecim.AllowUserToDeleteRows = false;
            this.dgwFirmaSecim.AllowUserToResizeRows = false;
            this.dgwFirmaSecim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFirmaSecim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(243)))), ((int)(((byte)(180)))));
            this.dgwFirmaSecim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwFirmaSecim.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwFirmaSecim.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwFirmaSecim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwFirmaSecim.ColumnHeadersHeight = 38;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(243)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwFirmaSecim.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwFirmaSecim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwFirmaSecim.EnableHeadersVisualStyles = false;
            this.dgwFirmaSecim.GridColor = System.Drawing.Color.Black;
            this.dgwFirmaSecim.Location = new System.Drawing.Point(0, 35);
            this.dgwFirmaSecim.MultiSelect = false;
            this.dgwFirmaSecim.Name = "dgwFirmaSecim";
            this.dgwFirmaSecim.ReadOnly = true;
            this.dgwFirmaSecim.RowHeadersVisible = false;
            this.dgwFirmaSecim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFirmaSecim.Size = new System.Drawing.Size(800, 415);
            this.dgwFirmaSecim.TabIndex = 60;
            this.dgwFirmaSecim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwFirmaSecim_CellDoubleClick);
            // 
            // FirmaSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwFirmaSecim);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirmaSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma Seçim Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirmaSecim_FormClosing);
            this.Load += new System.EventHandler(this.FirmaSecim_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFirmaSecim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwFirmaSecim;
    }
}