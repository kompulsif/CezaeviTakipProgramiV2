using System;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using System.Management;

namespace CezaeviProgram
{
    public partial class OkuyucuKontrol : Form
    {
        public OkuyucuKontrol()
        {
            InitializeComponent();
        }

        public string firmaID = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();
            portNames.Distinct();

            if (portNames.Length == 0)
            {
                label1.Text = "Okuyucu Bulunamadı";
                comboBox1.Visible = false;
                label2.Visible = true;
            }
            else
            {
                foreach (string comPortName in portNames)
                {
                    string query = $"SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%({comPortName})%'";
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
                    ManagementObjectCollection results = searcher.Get();
                    
                    foreach (ManagementObject result in results)
                    {
                        comboBox1.Items.Add(comPortName + " :: " + result["Caption"].ToString());
                    }
                }
                comboBox1.SelectedIndex = 0;
            }
        }       
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
                button2_Click(new Object(), new EventArgs());
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Visible)
            {
                string p = comboBox1.Text.Split(new string[] { " :: " }, StringSplitOptions.None)[0];
                Giris g = new Giris(p);
                g.firmaID = this.firmaID;
                g.Show();
                this.Hide();
            } else
            {
                Giris g = new Giris("");
                g.firmaID = this.firmaID;
                g.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
