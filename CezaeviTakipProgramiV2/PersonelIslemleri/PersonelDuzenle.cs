using CezaeviProgram;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CezaeviProgram.PersonelIslemleri
{
    public partial class PersonelDuzenle : Form
    {
        public static ComboBox pt;
        public bool duzenlendi = false;
        public PersonelDuzenle(DataGridViewRow row)
        {
            InitializeComponent();
            kimlik.Text = row.Cells[1].Value.ToString();
            adi.Text = row.Cells[2].Value.ToString();
            soyadi.Text = row.Cells[3].Value.ToString();
            adres.Text = row.Cells[7].Value.ToString();
            personelTipi.Text = row.Cells[8].Value.ToString();
            telefon.Text = row.Cells[6].Value.ToString();
            anneAdi.Text = row.Cells[4].Value.ToString();
            babaAdi.Text = row.Cells[5].Value.ToString();
            gorevYeri.Text = row.Cells[10].Value.ToString();
            DateTime gTarihFormat = DateTime.ParseExact(row.Cells[11].Value.ToString(), "HH:mm:ss", null);
            DateTime cTarihFormat = DateTime.ParseExact(row.Cells[12].Value.ToString(), "HH:mm:ss", null);
            giris.Text = gTarihFormat.ToString();
            cikis.Text = cTarihFormat.ToString();
            maas.Text = row.Cells[13].Value.ToString().Replace(',', '.');
            pt = personelTipi;
        }
        private bool mouseDown;
        private Point lastLocation;
        Dictionary<string, string> gorevYeriSozluk = new Dictionary<string, string>();

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnlTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }


        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            if (this.WindowState is FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            ArrayList durumlar = new ArrayList() {
                adi.Text.Trim().Length < 2, soyadi.Text.Trim().Length < 1,
                adres.Text.Trim().Length < 9, telefon.Text.Trim().Length != 10, anneAdi.Text.Trim().Length < 2,
                babaAdi.Text.Trim().Length < 2, maas.Text.Trim().Length < 3,
            };
            if (durumlar.Contains(true)) MessageBox.Show("Bilgiler uygun uzunlukta değil");
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand(
                        "update Personel set tipi = @tipi, adi = @adi, soyadi = @soyadi, adres = @adres, " +
                        "telefon = @telefon, anneAdi = @anneAdi, babaAdi = @babaAdi, gorevYeri = @gorevYeri, " +
                        "giris = @giris, cikis = @cikis, maas = @maas where kimlik = @kimlik", conn))
                    {
                        cmd.Parameters.AddWithValue("@tipi", personelTipi.Text);
                        cmd.Parameters.AddWithValue("@adi", adi.Text);
                        cmd.Parameters.AddWithValue("@soyadi", soyadi.Text);
                        cmd.Parameters.AddWithValue("@adres", adres.Text);
                        cmd.Parameters.AddWithValue("@telefon", telefon.Text);
                        cmd.Parameters.AddWithValue("@anneAdi", anneAdi.Text);
                        cmd.Parameters.AddWithValue("@babaAdi", babaAdi.Text);
                        cmd.Parameters.AddWithValue("@gorevYeri", gorevYeri.Text);
                        cmd.Parameters.AddWithValue("@giris", giris.Text);
                        cmd.Parameters.AddWithValue("@cikis", cikis.Text);
                        cmd.Parameters.AddWithValue("@maas", maas.Text);
                        cmd.Parameters.AddWithValue("@kimlik", kimlik.Text.Trim());
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Personel bilgileri düzenlendi!");
                        duzenlendi = true;
                        Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Bilgi güncellenmesi sırasında bir problem oluştu.\n" +
                    "Bilgilerin formatlarını veya veritabanını kontrol ediniz.");
                }
            }
        }

        private void lblPersonelTipi_Click(object sender, EventArgs e)
        {
            PersonelTipBilgilendirme ptipbilgi = new PersonelTipBilgilendirme(this.Name);
            ptipbilgi.ShowDialog();
        }

        private void disable_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void gorevYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            gorevYerBilgi.Text = gorevYeriSozluk[gorevYeri.Text];
        }

        private void PersonelDuzenle_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("select distinct tipID from PersonelTipleri where firmaID = @firmaID", conn))
                {
                    cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            personelTipi.Items.Add(reader[0].ToString());
                    }
                    personelTipi.SelectedIndex = 0;
                    using (SqlCommand cmd2 = new SqlCommand("select * from Bolge where firmaID = @firmaID", conn))
                    {
                        cmd2.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                        using (SqlDataReader reader = cmd2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                gorevYeriSozluk.Add(reader[0].ToString(), reader[1].ToString());
                                gorevYeri.Items.Add(reader[0].ToString());
                            }
                        }
                    }
                    gorevYeri.SelectedIndex = 0;
                    gorevYerBilgi.Text = gorevYeriSozluk[gorevYeri.Text];
                }
            }
        }
    }
}
