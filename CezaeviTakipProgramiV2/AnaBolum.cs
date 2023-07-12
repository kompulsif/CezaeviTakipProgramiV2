using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CezaeviProgram.AyarMenuleri;
using CezaeviProgram.IzinIslemleri;
using CezaeviProgram.MahkumIslemleri;
using CezaeviProgram.PersonelIslemleri;
using CezaeviProgram.ZiyaretciIslemleri;

namespace CezaeviProgram
{
    public partial class AnaBolum : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public static string firmaID;
        public static Label label_sonuc;
        public static string conn_str = "Server= localhost; Database=Cezaevi; Integrated Security=True;";
        public static SqlConnection conn = new SqlConnection(conn_str);
        public static DataGridViewRow duzenlenecekMahkum;
        public static TextBox kTextPublic;
        public static Dictionary<string, string> yetkiler;
        public AnaBolum(string fid, string kAdi, string y)
        {
            InitializeComponent();
            firmaID = fid;
            lblKullaniciSonuc.Text = kAdi;
            kTextPublic = kogusID;
            try
            {
                using (SqlCommand cmd = new SqlCommand("select firmaAdi from Firma where id = @firmaID", conn))
                {
                    cmd.Parameters.AddWithValue("@firmaID", firmaID);
                    conn.Open();
                    lblFirmaAdiSonuc.Text = (string)cmd.ExecuteScalar();
                }
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu, bağlantınızı kontrol edip tekrar deneyin");
                Close();
            }

            string[] values = y.Split(',');
            string[] keys = {
                "mahkum_duzenle", "mahkum_ekle", "mahkum_sil",
                "izin_islem", "izin_duzenle", "izin_ekle", "izin_sil",
                "personel_islem", "personel_duzenle", "personel_ekle", "personel_sil",
                "yoklama_islem", "yoklama_duzenle", "yoklama_ekle", "yoklama_sil",
                "ziyaretci_islem", "ziyaretci_duzenle", "ziyaretci_ekle", "ziyaretci_sil",
                "ayarlar_tam", "kogus_ayarlari", "ziyaret_odasi_ayarlari",
                "gorev_yeri_ayarlari", "personel_tip_ayarlari", "kullanici_ayarlari"
            };
            yetkiler = Enumerable.Range(0, keys.Length).ToDictionary(i => keys[i], i => values[i]);
        }

        private void AnaBolum_Load(object sender, EventArgs e)
        {
            try
            {
                label_sonuc = lblSayiSonuc;
                if (conn.State.ToString() == "Closed")
                    conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "select firmaID, kimlik as Kimlik, adi as Adı, " +
                    "soyadi as Soyadı, telefon as Telefon, " +
                    "adres as Adres, anneAdi as 'Anne Adı', " +
                    "babaAdi as 'Baba Adı', kogusID as 'Koğuş ID', " +
                    $"kayitTarih as 'Kayıt Tarihi', resim as resim from Mahkum where firmaID = {firmaID}", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Mahkum");
                dgwMahkumKayitlar.DataSource = ds.Tables["Mahkum"];
                dgwMahkumKayitlar.Columns[0].Visible = false;
                dgwMahkumKayitlar.Columns[10].Visible = false;
                dgwMahkumKayitlar.Columns[9].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm";
                lblSayiSonuc.Text = dgwMahkumKayitlar.RowCount.ToString();
                baslangic.Text = "1999/01/01 00:00";
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu, bağlantınızı kontrol edip tekrar deneyin");
                Close();
            }
        }

        private void dgwMahkumKayitlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwMahkumKayitlar.SelectedRows.Count > 0)
            {
                int indx = dgwMahkumKayitlar.CurrentCell.RowIndex;
                DataGridViewRow row = dgwMahkumKayitlar.Rows[indx];
                ArrayList aramalar = new ArrayList() {
                    kimlik, adi, soyadi, telefon,
                    adres, anneAdi, babaAdi, kogusID};
                int i = 0;
                for (; i < aramalar.Count; i++)
                {
                    TextBox t = (TextBox)aramalar[i];
                    t.Text = row.Cells[i + 1].Value.ToString();
                }
                var cultureInfo = new CultureInfo("tr-TR");
                kayitTarih.Text = row.Cells[i + 1].FormattedValue.ToString();
                MemoryStream ms = new MemoryStream((byte[])row.Cells[10].Value);
                pictureBox1.Image = Image.FromStream(ms);
                ms.Close();
            }
        }

        #region formMoveActions
        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
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

        private void pnlTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        #region inputFilters
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
        #endregion

        #region queryActions
        private void btnMahkumSorgu_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> sartlar = new Dictionary<string, string>();
            if (kimlik.Text.Trim() != "") sartlar["kimlik"] = $"kimlik = '{kimlik.Text.Trim()}%'";
            if (telefon.Text.Trim() != "") sartlar["telefon"] = $"telefon = '{telefon.Text.Trim()}%'";
            if (adi.Text.Trim() != "") sartlar["adi"] = $"adi like '%{adi.Text.Trim()}%'";
            if (soyadi.Text.Trim() != "") sartlar["soyadi"] = $"soyadi like '%{soyadi.Text.Trim()}%'";
            if (adres.Text.Trim() != "") sartlar["adres"] = $"adres like '%{adres.Text.Trim()}%'";
            if (anneAdi.Text.Trim() != "") sartlar["anneAdi"] = $"anneAdi like '%{anneAdi.Text.Trim()}%'";
            if (babaAdi.Text.Trim() != "") sartlar["babaAdi"] = $"babaAdi like '%{babaAdi.Text.Trim()}%'";
            if (kogusID.Text.Trim() != "") sartlar["kogusID"] = $"kogusID = '{kogusID.Text.Trim()}'";
            string kosullar = String.Join(" and ", sartlar.Values);
            string sinir = (sartlar.Keys.Contains("kimlik")) ? "select top 1 " : "select ";
            string komut = sinir + "firmaID, kimlik as Kimlik, adi as Adı, " +
                        "soyadi as Soyadı, telefon as Telefon, " +
                        "adres as Adres, anneAdi as 'Anne Adı', " +
                        "babaAdi as 'Baba Adı', kogusID as 'Koğuş ID', " +
                        $"kayitTarih as 'Kayıt Tarihi', resim as resim from Mahkum where firmaID = {firmaID} and kayitTarih between '{baslangic.Text}' and '{bitis.Text}' ";
            if (kosullar != "") komut += "and " + kosullar;
            using (SqlDataAdapter da = new SqlDataAdapter(komut, conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds, "Sonuclar");
                dgwMahkumKayitlar.DataSource = ds.Tables["Sonuclar"];
                lblSayiSonuc.Text = dgwMahkumKayitlar.RowCount.ToString();
            }
        }

        private void btnFiltreTemizle_Click(object sender, EventArgs e)
        {
            kimlik.Text = "";
            adi.Text = "";
            soyadi.Text = "";
            kogusID.Text = "";
            baslangic.Text = "1999/01/01 00:00";
            bitis.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            anneAdi.Text = "";
            babaAdi.Text = "";
            adres.Text = "";
            telefon.Text = "";
            kayitTarih.Text = "";
            pictureBox1.Image = null;
        }
        #endregion

        #region rightClickActions
        private void mahkumuDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwMahkumKayitlar.SelectedRows.Count > 0)
            {
                if (yetkiler["mahkum_duzenle"] == "1")
                {
                    int indx = dgwMahkumKayitlar.SelectedCells[0].RowIndex;
                    MahkumDuzenle md = new MahkumDuzenle(dgwMahkumKayitlar.Rows[indx]);
                    md.ShowDialog();
                }
                else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
            }
            else MessageBox.Show("Bir Mahkum seçmelisiniz.");
        }

        public void yeniMahkumEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (yetkiler["mahkum_ekle"] == "1")
            {
                MahkumEkle mekle = new MahkumEkle();
                mekle.ShowDialog();
            }
            else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }

        private void mahkumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwMahkumKayitlar.SelectedRows.Count > 0)
            {
                if (AnaBolum.yetkiler["mahkum_sil"] == "1")
                {
                    int indx = dgwMahkumKayitlar.SelectedCells[0].RowIndex;
                    DataGridViewRow r = dgwMahkumKayitlar.Rows[indx];
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("delete top(1) from Mahkum where kimlik = @kimlik", conn))
                        {
                            cmd.Parameters.AddWithValue("@kimlik", r.Cells[1].Value);
                            cmd.ExecuteNonQuery();
                            dgwMahkumKayitlar.Rows.RemoveAt(indx);
                            lblSayiSonuc.Text = (int.Parse(lblSayiSonuc.Text) - 1).ToString();
                            MessageBox.Show("Seçili mahkum silindi!");
                            btnFiltreTemizle_Click(sender, e);
                            btnMahkumSorgu_Click(sender, e);
                        }
                    }
                    catch { MessageBox.Show("Silme işlemi tamamlanamadı, bağlantınızı kontrol ediniz"); }
                }
                else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
            }
            else MessageBox.Show("Bir Mahkum seçmelisiniz");
        }
        #endregion

        #region menuButtonsActions
        private void btnYoklamaIslemleri_Click(object sender, EventArgs e)
        {
            if (yetkiler["yoklama_islem"] == "1")
            {
                YoklamaSorgu ysor = new YoklamaSorgu();
                ysor.ShowDialog();
            }
            else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }

        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            if (yetkiler["personel_islem"] == "1")
            {
                PersonelSorgu psorgu = new PersonelSorgu();
                psorgu.ShowDialog();
            }
            else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }

        private void btnIzinIslemleri_Click(object sender, EventArgs e)
        {
            if (yetkiler["izin_islem"] == "1")
            {
                IzinSorgu iSor = new IzinSorgu();
                iSor.ShowDialog();
            }
            else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }

        private void btnZiyaretIslemleri_Click(object sender, EventArgs e)
        {
            if (yetkiler["ziyaretci_islem"] == "1")
            {
                ZiyaretciSorgu ziySorgu = new ZiyaretciSorgu();
                ziySorgu.ShowDialog();
            }
            else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (yetkiler["ayarlar_tam"] == "1")
            {
                AyarMenusu aMenusu = new AyarMenusu();
                aMenusu.ShowDialog();
            }
            else { MessageBox.Show("Bu işlem için yetkiniz yok!"); }
        }
        #endregion

        private void lblKogusTipi_Click(object sender, EventArgs e)
        {
            MahkumKogusBilgilendirme mkbilgi = new MahkumKogusBilgilendirme(this.Name);
            mkbilgi.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Dispose();
            }
            catch { }
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState is FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            } else { this.WindowState = FormWindowState.Maximized; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
