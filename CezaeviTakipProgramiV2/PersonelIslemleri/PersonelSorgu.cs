using CezaeviProgram;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CezaeviProgram.PersonelIslemleri
{
    public partial class PersonelSorgu : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public static Dictionary<string, string> gorevYeriSozluk;
        public static Dictionary<string, string> personelTipleri;
        public static ComboBox gy;
        public static ComboBox pt;
        public PersonelSorgu()
        {
            InitializeComponent();
        }

        private void PersonelSorgu_Load(object sender, EventArgs e)
        {
            gorevYeriSozluk = new Dictionary<string, string>();
            personelTipleri = new Dictionary<string, string>();
            giris.CustomFormat = "HH:mm:ss";
            cikis.CustomFormat = "HH:mm:ss";
            tarihBaslangic.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            tarihBaslangic.Value = DateTime.Parse("1900/01/01 00:00:00");
            tarihBitis.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            giris.Value = DateTime.Parse("00:01:00");
            cikis.Value = DateTime.Parse("23:59:59");
            gy = gorevYeri;
            pt = personelTipi;
            string command = "select personelID, kimlik as Kimlik, adi as Adi, soyadi as Soyadi, anneAdi as 'Anne Adı', " +
                "babaAdi as 'Baba Adı', telefon as 'Telefon', adres as 'Adres', tipi as 'Personel', isAlimTarihi as 'Kayıt Tarihi', " +
                "gorevYeri as 'Görev Yeri', giris as 'Giriş Saati', cikis as 'Çıkış Saati', maas as 'Maaşı' " +
                $"from Personel where firmaID = {AnaBolum.firmaID}";

            using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(command, conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Personeller");
                    personelTipi.Items.Add("");
                    using (SqlCommand cmd = new SqlCommand("select tipID, tip from PersonelTipleri where firmaID = @firmaID", conn))
                    {
                        cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                personelTipleri.Add(reader[0].ToString(), reader[1].ToString());
                                personelTipi.Items.Add(reader[0].ToString());
                            }
                        }
                        personelTipi.SelectedIndex = 0;
                        gorevYeri.Items.Add("");
                        cmd.CommandText = $"select * from Bolge where firmaID = {AnaBolum.firmaID}";
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                gorevYeriSozluk.Add(reader[0].ToString(), reader[1].ToString());
                                gorevYeri.Items.Add(reader[0].ToString());
                            }
                        }
                        gorevYeri.SelectedIndex = 0;
                    }
                    dgwSorguSonuc.DataSource = ds.Tables["Personeller"];
                    dgwSorguSonuc.Columns[0].Visible = false;
                    dgwSorguSonuc.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgwSorguSonuc.Columns[9].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm";
                }
            }
        }

        #region ButtonClickActions
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            kimlik.Text = "";
            adi.Text = "";
            soyadi.Text = "";
            anneAdi.Text = "";
            babaAdi.Text = "";
            adres.Text = "";
            telefon.Text = "";
            maas.Text = "";
            personelTipi.SelectedIndex = 0;
            gorevYeri.SelectedIndex = 0;
            tarihBaslangic.Value = DateTime.Parse("1900/01/01 00:00:00");
            tarihBitis.Value = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            giris.Value = DateTime.Parse("00:01:00");
            cikis.Value = DateTime.Parse(DateTime.Now.ToString("HH:mm:ss"));
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            ArrayList alist = new ArrayList() {
                kimlik.Text.Trim() != "" && kimlik.TextLength != 11,
                telefon.Text.Trim() != "" && telefon.TextLength != 10,
                adi.Text.Trim() != "" && adi.TextLength < 3,
                soyadi.Text.Trim() != "" && soyadi.TextLength < 2,
                anneAdi.Text.Trim() != "" && anneAdi.TextLength < 3,
                babaAdi.Text.Trim() != "" && babaAdi.TextLength < 3,
                adres.Text.Trim() != "" && adres.Text.Length < 10,
                maas.Text.Trim() != "" && maas.Text.Length < 4
            };

            if (alist.Contains(true)) MessageBox.Show("Lütfen bilgileri doğru uzunlukta girdiğinize dikkat ediniz");
            else
            {
                string kosul = $"kimlik like '%{kimlik.Text}%' and adi like '%{adi.Text}%' and soyadi like '%{soyadi.Text}%' and " +
                                $"telefon like '%{telefon.Text}%' and anneAdi like '%{anneAdi.Text}%' and babaAdi like '%{babaAdi.Text}%' and " +
                                $"gorevYeri like '%{gorevYeri.SelectedItem}%' and tipi like '%{personelTipi.SelectedItem}%' and " +
                                $"maas >= '{maas.Text}' and isAlimTarihi between '{tarihBaslangic.Value.ToString("yyyy/MM/dd HH:mm:ss")}' and '{tarihBitis.Value.ToString("yyyy/MM/dd HH:mm:ss")}'";

                string select = "select personelID, kimlik as Kimlik, adi as Adi, soyadi as Soyadi, anneAdi as 'Anne Adı', " +
                "babaAdi as 'Baba Adı', telefon as 'Telefon', adres as 'Adres', tipi as 'Personel', isAlimTarihi as 'Kayıt Tarihi', " +
                "gorevYeri as 'Görev Yeri', giris as 'Giriş Saati', cikis as 'Çıkış Saati', maas as 'Maaşı' " +
                "from Personel where firmaID = @firmaID and " + kosul;

                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                using (SqlCommand cmd = new SqlCommand(select, conn))
                {
                    cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                    if (radioButton1.Checked) cmd.CommandText += $" and giris >= '{giris.Value.ToString("HH:mm:ss")}'";
                    else cmd.CommandText += $" and cikis <= '{cikis.Value.ToString().Split(' ')[1]}'";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        conn.Open();
                        DataSet ds = new DataSet();
                        da.Fill(ds, "PersonelSorgu");
                        dgwSorguSonuc.DataSource = ds.Tables["PersonelSorgu"];
                    }
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (AnaBolum.yetkiler["personel_ekle"] == "1")
            {
                PersonelEkle pekle = new PersonelEkle();
                pekle.ShowDialog();
                if (pekle.eklendi)
                {
                    btnTemizle_Click(sender, e);
                    btnSorgu_Click(sender, e);
                }
            }
            else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }
        #endregion

        #region lblClickInfoMenus
        private void lblPersonelTip_Click(object sender, EventArgs e)
        {
            PersonelTipBilgilendirme pbilgi = new PersonelTipBilgilendirme(this.Name);
            pbilgi.ShowDialog();
        }

        private void lblGorevYeri_Click(object sender, EventArgs e)
        {
            GorevYeriBilgilendirme gb = new GorevYeriBilgilendirme();
            gb.ShowDialog();
        }
        #endregion

        #region RightClickActions
        private void personeliSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwSorguSonuc.SelectedRows.Count > 0)
            {
                if (AnaBolum.yetkiler["personel_sil"] == "1")
                {
                    DataGridViewRow r = dgwSorguSonuc.SelectedRows[0];
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    using (SqlCommand cmd = new SqlCommand("delete from Personel where personelID = @perID", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@perID", r.Cells[0].Value.ToString());
                        cmd.ExecuteNonQuery();
                        dgwSorguSonuc.Rows.RemoveAt(r.Index);
                        MessageBox.Show("Seçili personel silindi!");
                        btnSorgu_Click(sender, e);
                    }
                }
                else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
            }
            else { MessageBox.Show("Seçili bir personel bulunamadı!"); }
        }

        private void personeliDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwSorguSonuc.SelectedRows.Count > 0)
            {
                if (AnaBolum.yetkiler["personel_duzenle"] == "1")
                {
                    DataGridViewRow r = dgwSorguSonuc.SelectedRows[0];
                    PersonelDuzenle pduzenle = new PersonelDuzenle(r);
                    pduzenle.ShowDialog();
                    if (pduzenle.duzenlendi)
                    {
                        btnTemizle_Click(sender, e);
                        btnSorgu_Click(sender, e);
                    }
                }
                else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
            }
            else { MessageBox.Show("Seçili bir personel bulunamadı!"); }
        }
        #endregion

        #region KeyPressDownEvents
        private void maas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
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

        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void x_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        #endregion

        #region MoveForm
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
        #endregion

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

        private void dgwSorguSonuc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwSorguSonuc.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgwSorguSonuc.SelectedRows[0];
                kimlik.Text = r.Cells[1].Value.ToString();
                adi.Text = r.Cells[2].Value.ToString();
                soyadi.Text = r.Cells[3].Value.ToString();
                anneAdi.Text = r.Cells[4].Value.ToString();
                babaAdi.Text = r.Cells[5].Value.ToString();
                telefon.Text = r.Cells[6].Value.ToString();
                adres.Text = r.Cells[7].Value.ToString();
                personelTipi.Text = r.Cells[8].Value.ToString();
                kayitTarih.Text = r.Cells[9].FormattedValue.ToString();
                gorevYeri.Text = r.Cells[10].Value.ToString();
                giris.Text = r.Cells[11].Value.ToString();
                cikis.Text = r.Cells[12].Value.ToString();
                maas.Text = r.Cells[13].Value.ToString().Replace(',', '.');
            }
        }
    }
}
