using System;
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
    public partial class Giris : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public static DataSet ds = new DataSet();
        public string firmaID;
        public static string kAdi;
        public static string comPort = null;
        private SerialPort arduinoPort;
        private CancellationTokenSource cancellationTokenSource;
        public Giris(string port)
        {
            InitializeComponent();
            comPort = port;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
            Application.Exit();
        }

        #region FormMoveActions
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

        #region AuthControls
        private void AuthControlCard(string kartID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server= localhost; Database=Cezaevi; Integrated Security=True;"))
                using (SqlDataAdapter da = new SqlDataAdapter($"select top 1 * from Kullanicilar where firmaID = '{firmaID}' and kartID = '{kartID}'", conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Bilgiler");
                    if (ds.Tables["Bilgiler"].Rows.Count == 1)
                    {
                        if (ds.Tables["Bilgiler"].Rows[0]["aktiflik"].ToString() == "1")
                        {
                            kAdi = ds.Tables["Bilgiler"].Rows[0]["kullaniciAdi"].ToString();
                            string yetkileri = ds.Tables["Bilgiler"].Rows[0]["yetkiler"].ToString();
                            AnaBolum anaBolum = new AnaBolum(firmaID, ds.Tables["Bilgiler"].Rows[0]["kullaniciAdi"].ToString(), yetkileri);
                            anaBolum.Show();
                            try
                            {
                                cancellationTokenSource.Cancel();
                                arduinoPort.Dispose();
                            }
                            catch { }
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hesabınız aktif değildir!\nLütfen yöneticinize başvurun");
                        }
                    }
                    else { MessageBox.Show("Kullanıcı bulunamadı!"); }
                }
            }
            catch { MessageBox.Show("Tekrar Deneyin..."); }
        }

        private void AuthControlUserPass(object sender, EventArgs e)
        {
            string kullaniciAdi = tBoxKullanici.Text.Trim();
            string parola = tBoxParola.Text.Trim();
            if (kullaniciAdi != "" && parola != "")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Server= localhost; Database=Cezaevi; Integrated Security=True;"))
                    using (SqlDataAdapter da = new SqlDataAdapter($"select top 1 * from Kullanicilar where firmaID = '{firmaID}' and kullaniciAdi = '{kullaniciAdi}' collate Latin1_General_CS_AI and parola = '{parola}' collate Latin1_General_CS_AI", conn))
                    {
                        conn.Open();
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Bilgiler");
                        if (ds.Tables["Bilgiler"].Rows.Count == 1)
                        {
                            if (ds.Tables["Bilgiler"].Rows[0]["aktiflik"].ToString() == "1")
                            {
                                string yetkileri = ds.Tables["Bilgiler"].Rows[0]["yetkiler"].ToString();
                                kAdi = kullaniciAdi;
                                AnaBolum anaBolum = new AnaBolum(firmaID, kullaniciAdi, yetkileri);
                                anaBolum.Show();
                                try
                                {
                                    cancellationTokenSource.Cancel();
                                    arduinoPort.Dispose();
                                }
                                catch { }
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Hesabınız aktif değildir!\nLütfen yöneticinize başvurun");
                                tBoxKullanici.Text = "";
                                tBoxParola.Text = "";
                                tBoxKullanici.Focus();
                            }
                        }
                        else { MessageBox.Show("Girdiğiniz bilgiler hatalıdır!"); }
                    }
                }
                catch { MessageBox.Show("Bağlantı hatası, daha sonra tekrar deneyin"); }
            }
            else { MessageBox.Show("Kullanıcı adı ve parolanızı giriniz"); }
        }
        #endregion

        #region PressConstraints
        private void tBoxKullanici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '_'))
            {
                e.Handled = true;
            }
        }

        private void tBoxKullanici_TextChanged(object sender, EventArgs e)
        {
            if (tBoxKullanici.Text.Length > 0 && !tBoxKullanici.Text[0].ToString().All(Char.IsLetter))
            {
                tBoxKullanici.Text = tBoxKullanici.Text.Substring(1);
            }
        }
        #endregion

        #region RFID_READING
        private async void Giris_Load(object sender, EventArgs e)
        {
            if (comPort != "") await StartRFIDReaderAsync();
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
                MessageBox.Show("Bağlantı noktasına erişim reddedildi, kullanıcı bilgileri ile giriş sağlayabilirsiniz");
                return;
            }
            catch
            {
                MessageBox.Show("Kart okuyucu ile bağlantı kurulamadı, kullanıcı bilgileri ile giriş sağlayınız");
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
                        string kartID = arduinoPort.ReadLine().Trim();
                        Invoke(new Action(() =>
                        {
                            AuthControlCard(kartID);
                        }));
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

        #region MissingValues
        private void tBoxKullanici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tBoxParola.Text != "") AuthControlUserPass(sender, new EventArgs());
                else tBoxParola.Focus();
            }
        }

        private void tBoxParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tBoxKullanici.Text.Trim() != "")
                {
                    AuthControlUserPass(sender, new EventArgs());
                }
                else tBoxKullanici.Focus();
            }
        }
        #endregion
    }
}
