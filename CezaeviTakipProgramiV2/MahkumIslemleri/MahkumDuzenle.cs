using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CezaeviProgram.MahkumIslemleri
{
    public partial class MahkumDuzenle : Form
    {
        ArrayList butunKutular = new ArrayList();
        private bool mouseDown;
        private Point lastLocation;
        DataSet ds = new DataSet();
        Byte[] imageData;
        public static ComboBox k;
        static bool imageChanged = false;
        public MahkumDuzenle(DataGridViewRow row)
        {
            InitializeComponent();
            k = koguslar;
            kimlik.Text = row.Cells[1].Value.ToString();
            adi.Text = row.Cells[2].Value.ToString();
            butunKutular.Add(adi);
            soyadi.Text = row.Cells[3].Value.ToString();
            butunKutular.Add(soyadi);
            telefon.Text = row.Cells[4].Value.ToString();
            butunKutular.Add(telefon);
            adres.Text = row.Cells[5].Value.ToString();
            butunKutular.Add(adres);
            anneAdi.Text = row.Cells[6].Value.ToString();
            butunKutular.Add(anneAdi);
            babaAdi.Text = row.Cells[7].Value.ToString();
            butunKutular.Add(babaAdi);
            koguslar.Text = row.Cells[8].Value.ToString();
            imageData = (byte[])(row.Cells[10].Value);
            using (MemoryStream ms = new MemoryStream(imageData)) pictureBox1.Image = Image.FromStream(ms);
        }

        private void MahkumDuzenle_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
            using (SqlCommand cmd = new SqlCommand("select kogusID from Kogus where firmaID = @firmaID", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@firmaID", AnaBolum.firmaID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read()) koguslar.Items.Add(reader["kogusID"]);

                if (koguslar.Items.Count == 0) {
                    MessageBox.Show("Mahkum koğuşları için gerekli bilgiler eksik, lütfen koğuşları güncelleyin");
                    Close();
                } else { koguslar.SelectedIndex = 0; }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resimler(*.jpeg; *.jpg; *.png) | *.jpeg;*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        if (myStream.Length > 512000) MessageBox.Show("Dosya boyutu aşıldı!");
                        else
                        {
                            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                            imageChanged = true;
                        }
                    }
                }
                catch { MessageBox.Show("Resim belgesini kontrol ediniz."); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList durumlar = new ArrayList() {
                    adres.Text.Length < 9, adi.Text.Length < 2, soyadi.Text.Length < 1, anneAdi.Text.Length < 2,
                    babaAdi.Text.Length < 2, telefon.Text.Length != 10, pictureBox1.Image == null
            };

            if (durumlar.Contains(true)) MessageBox.Show("Bilgilerin doğruluğunu ve uzunluğunu kontrol ediniz!");
            else
            {
                string imageC = "";
                if (imageChanged)
                {
                    imageC = "resim = @resim,";
                    using (MemoryStream stream = new MemoryStream())
                    {
                        pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageData = stream.ToArray();
                    }
                }

                string cmd = "update top (1) Mahkum set adi = @adi, soyadi = @soyadi, " +
                    "telefon = @telefon, adres = @adres, anneAdi = @anneAdi, babaAdi = @babaAdi, " +
                    $"kogusID = @kogusID, {imageC} kayitTarih = @kayitTarih " +
                    "where kimlik = @kimlik";

                using (SqlConnection conn = new SqlConnection(AnaBolum.conn_str))
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(cmd, conn))
                        {
                            string tarih = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                            command.Parameters.AddWithValue("@kimlik", kimlik.Text);
                            command.Parameters.AddWithValue("@adi", adi.Text);
                            command.Parameters.AddWithValue("@soyadi", soyadi.Text);
                            command.Parameters.AddWithValue("@telefon", telefon.Text);
                            command.Parameters.AddWithValue("@adres", adres.Text);
                            command.Parameters.AddWithValue("@anneAdi", anneAdi.Text);
                            command.Parameters.AddWithValue("@babaAdi", babaAdi.Text);
                            command.Parameters.AddWithValue("@kogusID", koguslar.SelectedItem);
                            if (imageChanged) command.Parameters.AddWithValue("@resim", imageData);
                            command.Parameters.AddWithValue("@kayitTarih", tarih);
                            conn.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Kayıt güncellendi!");
                            Hide();
                        }
                    } catch { MessageBox.Show("Bilgilerinizin formatını kontrol ediniz"); }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MahkumKogusBilgilendirme mkogusbilgi = new MahkumKogusBilgilendirme(this.Name);
            mkogusbilgi.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

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
    }
}
