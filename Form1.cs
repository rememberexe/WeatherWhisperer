using Newtonsoft.Json.Linq;
using WeatherWhisperer.Properties;
using Timer = System.Windows.Forms.Timer;

namespace WeatherWhisperer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string dosyaYolu = @"config.txt"; // Yazýlacak dosyanýn yolu Tema
            // Dosyadan metni okuma
            string okunanMetin = DosyadanOku(dosyaYolu);

            if (okunanMetin == "0")
            {

            }
            else if (okunanMetin == "1")
            {
                textBox1.BackColor = Color.FromArgb(150, 150, 150);
                textBox1.ForeColor = Color.Black;
                clsbtn.Image = Resources.lightclose;
                minimizebtn.Image = Resources.lightminimize;
                settingsbtn.Image = Resources.whitesettings;
                panel1.BackColor = Color.FromArgb(150, 150, 150);
                panel2.BackColor = Color.FromArgb(244, 244, 244);
                this.ForeColor = Color.Black;
                this.BackColor = Color.FromArgb(244, 244, 244);
            }
            timer1.Start();
;            this.Load += new EventHandler(MainForm_Load);
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
            // Dosyayý aç ve içeriði oku
            using (StreamReader reader = new StreamReader(dosyaYolu))
            {
                return reader.ReadToEnd();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Çalýþýlabilir ekran alanýný al (görev çubuðu hariç)
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Formun boyutlarýný al
            int formWidth = this.Width;
            int formHeight = this.Height;

            // Formun sol üst köþe koordinatlarýný hesapla (görev çubuðunun hemen üstü için)
            int x = workingArea.Width - formWidth;
            int y = workingArea.Height - formHeight;

            // Formun konumunu ayarla
            this.Location = new Point(x, y);

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
                    Application.Exit();
                }
            };
            timer.Start();

        }

        private void minimizebtn_Click(object sender, EventArgs e)
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
                    this.WindowState = FormWindowState.Minimized;
                    this.Opacity = 1;
                    timer.Stop();
                }
            };
            timer.Start();

        }

        int Move;
        int Mouse_X;
        int Mouse_Y;


        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }



        private async void searchbtn_ClickAsync(object sender, EventArgs e)
        {
            string apiKey = "44ef6b2cb8951f6a4fbc9d4b52cf5352"; // OpenWeatherMap API anahtarýný buraya ekleyin
            string city = textBox1.Text; // TextBox'tan þehir adýný alýn

            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=tr";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        timer1.Start();
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject weatherData = JObject.Parse(jsonResponse);

                        string cityName = weatherData["name"].ToString();
                        double temperature = Convert.ToDouble(weatherData["main"]["temp"]);
                        double minTemperature = Convert.ToDouble(weatherData["main"]["temp_min"]);
                        double maxTemperature = Convert.ToDouble(weatherData["main"]["temp_max"]);
                        double humidity = Convert.ToDouble(weatherData["main"]["humidity"]);
                        double windSpeed = Convert.ToDouble(weatherData["wind"]["speed"]);
                        string weatherDescription = weatherData["weather"][0]["description"].ToString();
                        string iconCode = weatherData["weather"][0]["icon"].ToString();
                        string iconUrl = $"http://openweathermap.org/img/wn/{iconCode}@2x.png";

                        location.Text = $"Konum : {cityName}";
                        citys.Text = $"{cityName} / {temperature}°C";
                        Tmpr.Text = $"{minTemperature}°C / {maxTemperature}°C";
                        hmd.Text = $"{humidity}% / Rüzgar Hýzý: {windSpeed} m/s";
                        wthr.Text = $"{weatherDescription}";

                        // Hava durumu ikonunu PictureBox'a yükle
                        WeatherPictureBox.Load(iconUrl);
                    }
                    else if (textBox1.Text == "")
                    {
                        location.Text = $"Konum : Lütfen bir þehir aratýn!";
                        citys.Text = $"";
                        Tmpr.Text = $"";
                        hmd.Text = $"";
                        wthr.Text = $"";
                    }
                    else
                    {
                        location.Text = $"Konum : Þehir ismini yanlýþ!";
                        citys.Text = $"";
                        Tmpr.Text = $"";
                        hmd.Text = $"";
                        wthr.Text = $"";
                    }
                }
                catch
                {
                    Application.Restart();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchbtn.PerformClick();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dosyaYolu = @"config.txt"; // Yazýlacak dosyanýn yolu Tema
            // Dosyadan metni okuma
            string okunanMetin = DosyadanOku(dosyaYolu);

            if (okunanMetin == "0")
            {
                textBox1.BackColor = Color.FromArgb(20, 20, 20);
                textBox1.ForeColor = Color.White;
                clsbtn.Image = Resources.darkclose;
                minimizebtn.Image = Resources.darkminimize;
                settingsbtn.Image = Resources.settings1;
                panel1.BackColor = Color.FromArgb(47, 47, 47);
                panel2.BackColor = Color.FromArgb(33, 33, 33);
                this.ForeColor = Color.White;
                this.BackColor = Color.FromArgb(33, 33 ,33);
            }
            else if (okunanMetin == "1")
            {
                textBox1.BackColor = Color.FromArgb(150, 150, 150);
                textBox1.ForeColor = Color.Black;
                clsbtn.Image = Resources.lightclose;
                minimizebtn.Image = Resources.lightminimize;
                settingsbtn.Image = Resources.whitesettings;
                panel1.BackColor = Color.FromArgb(150, 150, 150);
                panel2.BackColor = Color.FromArgb(244, 244, 244);
                this.ForeColor = Color.Black;
                this.BackColor = Color.FromArgb(244, 244, 244);
            }
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            settingsform stgn = new settingsform();
            stgn.ShowDialog();
        }
    }
}