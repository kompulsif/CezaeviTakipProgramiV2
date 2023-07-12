namespace CezaeviProgram
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tBoxKullanici = new System.Windows.Forms.TextBox();
            this.tBoxParola = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(6)))), ((int)(((byte)(17)))));
            this.pnlTopBar.Controls.Add(this.button2);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(369, 25);
            this.pnlTopBar.TabIndex = 0;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(338, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 25);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tBoxKullanici
            // 
            this.tBoxKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.tBoxKullanici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.tBoxKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.tBoxKullanici.Location = new System.Drawing.Point(113, 147);
            this.tBoxKullanici.Name = "tBoxKullanici";
            this.tBoxKullanici.Size = new System.Drawing.Size(152, 26);
            this.tBoxKullanici.TabIndex = 1;
            this.tBoxKullanici.TextChanged += new System.EventHandler(this.tBoxKullanici_TextChanged);
            this.tBoxKullanici.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxKullanici_KeyDown);
            this.tBoxKullanici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxKullanici_KeyPress);
            // 
            // tBoxParola
            // 
            this.tBoxParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.tBoxParola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.tBoxParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.tBoxParola.Location = new System.Drawing.Point(72, 218);
            this.tBoxParola.Name = "tBoxParola";
            this.tBoxParola.PasswordChar = '*';
            this.tBoxParola.Size = new System.Drawing.Size(176, 20);
            this.tBoxParola.TabIndex = 3;
            this.tBoxParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxParola_KeyDown);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Location = new System.Drawing.Point(81, 307);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(195, 35);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.AuthControlUserPass);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Girişi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.tBoxParola);
            this.Controls.Add(this.tBoxKullanici);
            this.Controls.Add(this.pnlTopBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.TextBox tBoxKullanici;
        private System.Windows.Forms.TextBox tBoxParola;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}