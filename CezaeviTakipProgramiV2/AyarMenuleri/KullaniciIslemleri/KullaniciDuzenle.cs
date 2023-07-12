using CezaeviProgram.AyarMenuleri.KullaniciIslemleri;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CezaeviProgram
{
    public partial class KullaniciDuzenle : Form
    {
        private string comPort = Giris.comPort;
        private string kartID;
        private bool kartEkleniyor = true;
        private bool mouseDown;
        private Point lastLocation;
        private SerialPort arduinoPort;
        private CancellationTokenSource cancellationTokenSource;
        string kullaniciID;
        string kullaniciAdi;
        string durum;
        string aktiflik;
        string[] yetkiler;
        ArrayList kutular;
        public KullaniciDuzenle(DataGridViewRow r)
        {
            InitializeComponent();
            cb_Aktif.Text = (durum == "1") ? "Deaktif Et" : "Aktif Et";
            kullaniciID = r.Cells[0].Value.ToString();
            kullaniciAdi = r.Cells[1].Value.ToString();
            durum = r.Cells[4].Value.ToString();
            yetkiler = r.Cells[3].Value.ToString().Split(',');
            label5.Text = (durum == "1") ? "Hesap Durumu Aktif" : "Hesap Durumu Aktif Değil";
            cb_Aktif.Text = (durum == "1") ? "Deaktif Et" : "Aktif Et";
            textBox1.Text = kullaniciAdi;
            textBox2.Text = r.Cells[2].Value.ToString();
            kartID = r.Cells[6].Value.ToString().Trim();
            cb_KartBilgi.Text = kartID;
            kutular = new ArrayList() {
                checkBox1, checkBox2, checkBox21,
                checkBox3, checkBox4, checkBox5, checkBox22,
                checkBox6, checkBox7, checkBox8, checkBox25,
                checkBox9, checkBox10, checkBox11, checkBox23,
                checkBox12, checkBox14, checkBox13, checkBox24,
                checkBox15, checkBox17, checkBox18, checkBox19, checkBox16, checkBox27
            };
        }

        #region RfidReadOperations

        private async void KullaniciDuzenle_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < kutular.Count; i++)
            {
                CheckBox kutu = (CheckBox)kutular[i];
                if (yetkiler[i] == "1") kutu.Checked = true;
                else kutu.Checked = false;
            }

            if (comPort != "") await StartRFIDReaderAsync();
            else
            {
                MessageBox.Show("Kart okuyucu algılanamadı!");
            }
        }
        private async Task StartRFIDReaderAsync()
        {
            cancellationTokenSource = new CancellationTokenSource();
            try
            {
                arduinoPort = new SerialPort(comPort, 9600);
                arduinoPort.Open();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Bağlantı noktasına erişim reddedildi!");
                return;
            }
            catch
            {
                MessageBox.Show("Kart okuyucu ile bağlantı kurulamadı!");
                return;
            }

            try
            {
                await Task.Run(() => ReadRFIDTags(cancellationTokenSource.Token));
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Kart okuma iptal edildi!");
            }
            finally
            {
                if (arduinoPort != null && arduinoPort.IsOpen)
                    arduinoPort.Close();
            }
        }

        private void ReadRFIDTags(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    if (arduinoPort.BytesToRead > 0)
                    {
                        string kaID = arduinoPort.ReadLine().Trim();
                        if (kaID.Length > 2)
                        {
                            cb_KartBilgi.Text = kaID;
                        }
                        else cb_KartBilgi.Text = "Kart okunamadı!";
                    }
                }
                catch
                {
                    MessageBox.Show("Kart okuyucu bağlantısı sağlanamadı, kullanıcı bilgileri ile giriş yapınız");
                    return;
                }
            }
        }
        #endregion

        #region FormMoveActions
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

        #region PanelOpenOperations
        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Visible = (panel5.Visible) ? false : true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel6.Visible = (panel6.Visible) ? false : true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel7.Visible = (panel7.Visible) ? false : true;
        }

        private void btnIzinIzin_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = (panel4.Visible) ? false : true;
        }

        private void btnPersonelIzin_Click(object sender, EventArgs e)
        {
            panel2.Visible = (panel2.Visible) ? false : true;
        }
        private void btnMahkumIzin_Click(object sender, EventArgs e)
        {
            panel1.Visible = (panel1.Visible) ? false : true;
        }

        #endregion

        #region CheckBoxOpenOperations
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            checkBox20.Checked = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Visible = true;
                checkBox5.Visible = true;
                checkBox22.Visible = true;
            }
            else
            {
                checkBox4.Visible = false;
                checkBox4.Checked = false;
                checkBox5.Visible = false;
                checkBox5.Checked = false;
                checkBox22.Visible = false;
                checkBox22.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox7.Visible = true;
                checkBox8.Visible = true;
                checkBox25.Visible = true;
            }
            else
            {
                checkBox7.Visible = false;
                checkBox7.Checked = false;
                checkBox8.Visible = false;
                checkBox8.Checked = false;
                checkBox25.Visible = false;
                checkBox25.Checked = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox13.Visible = true;
                checkBox14.Visible = true;
                checkBox24.Visible = true;
            }
            else
            {
                checkBox13.Visible = false;
                checkBox13.Checked = false;
                checkBox14.Visible = false;
                checkBox14.Checked = false;
                checkBox24.Visible = false;
                checkBox24.Checked = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox16.Visible = true;
                checkBox17.Visible = true;
                checkBox18.Visible = true;
                checkBox19.Visible = true;
                checkBox27.Visible = true;
            }
            else
            {
                checkBox16.Visible = false;
                checkBox16.Checked = false;
                checkBox17.Visible = false;
                checkBox17.Checked = false;
                checkBox18.Visible = false;
                checkBox18.Checked = false;
                checkBox19.Visible = false;
                checkBox19.Checked = false;
                checkBox27.Visible = false;
                checkBox27.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Visible = true;
                checkBox5.Visible = true;
                checkBox22.Visible = true;
            }
            else
            {
                checkBox4.Visible = false;
                checkBox4.Checked = false;
                checkBox5.Visible = false;
                checkBox5.Checked = false;
                checkBox22.Visible = false;
                checkBox22.Checked = false;
            }
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox10.Visible = true;
                checkBox11.Visible = true;
                checkBox23.Visible = true;
            }
            else
            {
                checkBox10.Visible = false;
                checkBox10.Checked = false;
                checkBox11.Visible = false;
                checkBox11.Checked = false;
                checkBox23.Visible = false;
                checkBox23.Checked = false;
            }
        }
        #endregion

        #region FormBox
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            if (this.WindowState is FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                textBox1.Font = new Font("Verdana", 12);
                textBox2.Font = new Font("Verdana", 12);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                textBox1.Font = new Font("Verdana", tableLayoutPanel1.Width / 35);
                textBox2.Font = new Font("Verdana", tableLayoutPanel1.Width / 35);
            }
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            cb_KartBilgi.Text = "";
        }
        private void KullaniciDuzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            kartEkleniyor = false;
            try
            {
                if (cancellationTokenSource != null)
                    cancellationTokenSource.Cancel();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Length > 7)
            {
                while (true)
                {
                    try
                    {
                        if (cb_KartBilgi.Text.Trim().Length > 2)
                        {
                            DataSet ds = new DataSet();
                            using (SqlDataAdapter cmd = new SqlDataAdapter($"select top(1) kartID from Kullanicilar where id != '{kullaniciID}' and kartID = '{cb_KartBilgi.Text.Trim()}'", AnaBolum.conn))
                                cmd.Fill(ds, "T");
                            if (ds.Tables[0].Rows.Count == 1) {
                                MessageBox.Show("Bu kart zaten kullanımdadır, lütfen yöneticinize bildirin.");
                                break;
                            }
                        }
                        string yetkisi = "";
                        foreach (CheckBox item in kutular) yetkisi += (item.Checked) ? "1," : "0,";
                        yetkisi = yetkisi.Trim(',');
                        using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                        using (SqlCommand cmd = new SqlCommand("update Kullanicilar set parola = @parola, yetkiler = @yetkiler, aktiflik = @aktiflik, kartID = @kartID where id = @kullaniciID", conn))
                        {
                            cmd.Parameters.AddWithValue("@parola", textBox2.Text.Trim());
                            cmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                            cmd.Parameters.AddWithValue("@yetkiler", yetkisi);
                            if (cb_KartBilgi.Text.Trim() != "")
                                cmd.Parameters.AddWithValue("@kartID", cb_KartBilgi.Text.Trim());
                            else
                                cmd.Parameters.AddWithValue("@kartID", DBNull.Value);
                            
                            bool kapat = false;
                            if (durum == "1")
                            {
                                aktiflik = (cb_Aktif.Checked) ? "0" : "1";
                                kapat = (aktiflik == "0") ? true : false;
                            }
                            else aktiflik = (cb_Aktif.Checked) ? "1" : "0";
                            cmd.Parameters.AddWithValue("@aktiflik", aktiflik);
                            conn.Open();
                            cmd.ExecuteNonQuery();

                            if (kullaniciAdi == Giris.kAdi)
                            {
                                if (kapat)
                                {
                                    MessageBox.Show("Hesabınız artık aktif değildir, çıkış yapıldı!");
                                    Application.Exit();
                                }
                                else
                                {
                                    string[] values = yetkisi.Split(',');
                                    string[] keys = {
                                    "mahkum_duzenle", "mahkum_ekle", "mahkum_sil",
                                    "izin_islem", "izin_duzenle", "izin_ekle", "izin_sil",
                                    "personel_islem", "personel_duzenle", "personel_ekle", "personel_sil",
                                    "yoklama_islem", "yoklama_duzenle", "yoklama_ekle", "yoklama_sil",
                                    "ziyaretci_islem", "ziyaretci_duzenle", "ziyaretci_ekle", "ziyaretci_sil",
                                    "ayarlar_tam", "kogus_ayarlari", "ziyaret_odasi_ayarlari",
                                    "gorev_yeri_ayarlari", "personel_tip_ayarlari", "kullanici_ayarlari"
                                };
                                    AnaBolum.yetkiler = Enumerable.Range(0, keys.Length).ToDictionary(i => keys[i], i => values[i]);
                                }
                            }
                            KullaniciSorgu.add_or_edit = true;
                            Hide();
                            MessageBox.Show("Kullanıcının bilgileri düzenlendi!");
                            break;
                        }
                    }
                    catch
                    {
                        Hide();
                        MessageBox.Show("Kayıt güncellenemedi, bağlantınızı kontrol ediniz");
                        break;
                    }
                }
                
            }
            else { MessageBox.Show("Parola en az 8 en fazla 30 karakter olmalıdır!"); }
        }

        private void parolayiGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contextMenuStrip1.Items[0].Text == "Parolayı Göster")
            {
                contextMenuStrip1.Items[0].Text = "Parolayı Gizle";
                textBox2.PasswordChar = '\0';
            } else
            {
                contextMenuStrip1.Items[0].Text = "Parolayı Göster";
                textBox2.PasswordChar = '*';
            }
        }

        private void varsayilanKartiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb_KartBilgi.Text = kartID;
        }
    }
}
