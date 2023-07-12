using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Collections;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace CezaeviProgram.AyarMenuleri.KullaniciIslemleri
{
    public partial class KullaniciEkle : Form
    {
        private string comPort = Giris.comPort;
        private string kartID = "";
        private bool kartEkleniyor = true;
        private bool mouseDown;
        private Point lastLocation;
        private SerialPort arduinoPort;
        private CancellationTokenSource cancellationTokenSource;
        public KullaniciEkle()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length < 1) { MessageBox.Show("Kullanıcı adı en az 2 karakter olmalıdır"); }
            else if (textBox2.Text.Trim().Length < 7) { MessageBox.Show("Parola en az 8 karakter olmalıdır"); }
            else
            {
                int i = 0, x = 0;
                try
                {
                    using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("select kullaniciAdi from Kullanicilar where firmaID = @firmaID and kullaniciAdi = @kAdi", conn))
                        {
                            cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                            cmd.Parameters.AddWithValue("@kAdi", textBox1.Text.ToString());
                            using (SqlDataReader reader = cmd.ExecuteReader()) while (reader.Read()) i += 1;
                        }
                        using (SqlCommand cmd = new SqlCommand("select kartID from Kullanicilar where firmaID = @firmaID and kartID = @kartID", conn))
                        {
                            cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                            cmd.Parameters.AddWithValue("@kartID", kartID);
                            using (SqlDataReader reader = cmd.ExecuteReader()) while (reader.Read()) x += 1;
                        }
                        if (i != 0) { MessageBox.Show("Bu kullanıcı adı kullanılıyor, eklenemez"); }
                        else if (x != 0) {
                            MessageBox.Show("Bu kart kullanılıyor, lütfen yöneticinize kartı teslim edin");
                        }
                        else
                        {
                            string yetkisi = "";
                            ArrayList kutular = new ArrayList() { 
                                checkBox1, checkBox2, checkBox21,
                                checkBox3, checkBox4, checkBox5, checkBox22,
                                checkBox6, checkBox7, checkBox8, checkBox25,
                                checkBox9, checkBox10, checkBox11, checkBox23,
                                checkBox12, checkBox14, checkBox13, checkBox24,
                                checkBox15, checkBox17, checkBox18, checkBox19, checkBox16, checkBox27
                            };
                            foreach (CheckBox item in kutular) yetkisi += (item.Checked) ? "1," : "0,";
                            yetkisi = yetkisi.Trim(',');

                            using (SqlCommand cmd = new SqlCommand("insert into Kullanicilar values (@kullaniciAdi, @parola, @yetkiler, @aktiflik, @firmaID, @kartID)", conn))
                            {
                                cmd.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text.Trim());
                                cmd.Parameters.AddWithValue("@parola", textBox2.Text.Trim());
                                cmd.Parameters.AddWithValue("@yetkiler", yetkisi);
                                cmd.Parameters.AddWithValue("@aktiflik", (cb_Aktif.Checked) ? "1" : "0");
                                cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                                if (cb_KartBilgi.Text.Trim() != "")
                                    cmd.Parameters.AddWithValue("@kartID", kartID);
                                else
                                    cmd.Parameters.AddWithValue("@kartID", DBNull.Value);
                                cmd.ExecuteNonQuery();
                                KullaniciSorgu.add_or_edit = true;
                                cancellationTokenSource.Cancel();
                                kartEkleniyor = false;
                                MessageBox.Show("Yeni kullanıcı eklendi!");
                                Close();
                            }
                        }
                    }
                }
                catch { MessageBox.Show("Kullanıcı eklenemedi, bağlantınızı kontrol ediniz."); }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '_'))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && !textBox1.Text[0].ToString().All(Char.IsLetter))
            {
                textBox1.Text = textBox1.Text.Substring(1);
            }
        }

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
            } else
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

        private async void KullaniciEkle_Load(object sender, EventArgs e)
        {
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
                            kartID = kaID;
                            cb_KartBilgi.Text = kartID;
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

        private void KullaniciEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            kartEkleniyor = false;
            try
            {
                if (cancellationTokenSource != null)
                    cancellationTokenSource.Cancel();
            }
            catch { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMahkumIzin_Click(object sender, EventArgs e)
        {
            panel1.Visible = (panel1.Visible) ? false : true;
        }

        private void pnlTopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox12_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                if (cancellationTokenSource != null)
                    cancellationTokenSource.Cancel();
            }
            catch { }
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

        private void btnIzinIzin_Click(object sender, EventArgs e)
        {

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

        private void btnIzinIzin_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = (panel4.Visible) ? false : true;
        }

        private void btnPersonelIzin_Click(object sender, EventArgs e)
        {
            panel2.Visible = (panel2.Visible) ? false : true;
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

        private void button5_Click(object sender, EventArgs e)
        {
            kartID = "";
            cb_KartBilgi.Text = "Kartı okutun";
        }

        private void parolayiGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contextMenuStrip1.Items[0].Text == "Parolayı Göster")
            {
                contextMenuStrip1.Items[0].Text = "Parolayı Gizle";
                textBox2.PasswordChar = '\0';
            }
            else
            {
                contextMenuStrip1.Items[0].Text = "Parolayı Göster";
                textBox2.PasswordChar = '*';
            }
        }
    }
}
