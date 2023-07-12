using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CezaeviProgram
{
    public partial class FirmaSecim : Form
    {
        public FirmaSecim()
        {
            InitializeComponent();
        }

        private void FirmaSecim_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server= localhost; Database=Cezaevi; Integrated Security=True;"))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("select * from Firma", conn))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Firmalar");
                        dgwFirmaSecim.DataSource = ds.Tables["Firmalar"];
                        dgwFirmaSecim.Columns[0].Visible = false;
                    }
                }
                if (dgwFirmaSecim.Rows.Count == 0) {
                    MessageBox.Show("Seçilebilecek bir firma bulunmuyor. Lütfen veritabanı yöneticisi tarafından eklenmesini talep ediniz.");
                    this.Close();
                }
            } catch {
                MessageBox.Show("Firma bilgileri alınırken bir problem oluştu. Lütfen tekrar deneyiniz.");
                this.Close();
            }
        }

        private void FirmaSecim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgwFirmaSecim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwFirmaSecim.SelectedRows.Count > 0)
            {
                OkuyucuKontrol oKontrol = new OkuyucuKontrol();
                oKontrol.firmaID = dgwFirmaSecim.SelectedRows[0].Cells[0].Value.ToString();
                this.Hide();
                oKontrol.Show();
            }
        }
    }
}
