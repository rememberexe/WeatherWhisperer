using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherWhisperer.Properties;
using Timer = System.Windows.Forms.Timer;

namespace WeatherWhisperer
{
    public partial class settingsform : Form
    {
        public settingsform()
        {
            InitializeComponent();
            string dosyaYolu = @"config.txt"; // Yazılacak dosyanın yolu Tema
            // Dosyadan metni okuma
            string okunanMetin = DosyadanOku(dosyaYolu);
            if (okunanMetin == "0")
            {

            }
            else if (okunanMetin == "1")
            {
                thm = 1;
                pictureBox1.Image = Resources.whitesettings;
                clsbtn.Image = Resources.lightclose;
                label1.ForeColor = Color.Black;
                thminflbl.Text = $"White Mode";
                thmtglbtn.Image = Resources.tglofff;
                panel1.BackColor = Color.FromArgb(244, 244, 244);
                this.ForeColor = Color.Black;
            }
            timer1.Start();
            this.Opacity = 0;

            var timer = new Timer();
            timer.Interval = 2;
            timer.Tick += (s, ev) =>
            {
                this.Opacity += 0.08;

                if (this.Opacity >= 1)
                {
                    timer.Stop();
                    timer.Tick -= (ss, ee) => { };
                }
            };
            timer.Start();
        }

        // Dosyadan okuma metod
        static string DosyadanOku(string dosyaYolu)
        {
            // Dosyayı aç ve içeriği oku
            using (StreamReader reader = new StreamReader(dosyaYolu))
            {
                return reader.ReadToEnd();
            }
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;

            var timer = new Timer();
            timer.Interval = 2;
            timer.Tick += (s, ev) =>
            {
                this.Opacity -= 0.07;

                if (this.Opacity >= 1)
                {
                    timer.Stop();
                    timer.Tick -= (ss, ee) => { };
                }
                else if (this.Opacity == 0)
                {
                    this.Close();
                }
            };
            timer.Start();
        }

        int thm = 0;

        private void thmtglbtn_Click(object sender, EventArgs e)
        {
            if (thm == 0)
            {
                thmtglbtn.Image = Resources.tglofff;
                thm = 1;
                File.WriteAllText("config.txt", "1");
                thminflbl.Text = $"White Mode";
            }
            else if (thm == 1)
            {
                thmtglbtn.Image = Resources.tglonn;
                thm = 0;
                File.WriteAllText("config.txt", "0");
                thminflbl.Text = $"Dark Mode";
            }
        }

        private void settingsform_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dosyaYolu = @"config.txt"; // Yazılacak dosyanın yolu Tema
            // Dosyadan metni okuma
            string okunanMetin = DosyadanOku(dosyaYolu);
            if (okunanMetin == "0")
            {
                thm = 0;
                pictureBox1.Image = Resources.settings1;
                clsbtn.Image = Resources.darkclose;
                label1.ForeColor = Color.White;
                thminflbl.Text = $"Dark Mode";
                panel1.BackColor = Color.FromArgb(40, 40, 40);
                this.ForeColor = Color.White;
            }
            else if (okunanMetin == "1")
            {
                thm = 1;
                pictureBox1.Image = Resources.whitesettings;
                clsbtn.Image = Resources.lightclose;
                label1.ForeColor = Color.Black;
                thminflbl.Text = $"White Mode";
                panel1.BackColor = Color.FromArgb(244, 244, 244);
                this.ForeColor = Color.Black;
            }
        }
    }
}
