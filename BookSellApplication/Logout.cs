using System;
using System.Windows.Forms;

namespace BookSellApplication
{
    public partial class Logout : Form
    {
        private Timer timer;
        private int progressValue = 0;

        public Logout()
        {
            InitializeComponent();

            // ProgressBar ayarları
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            // Timer ayarları
            timer = new Timer();
            timer.Interval = 50; // Her 50 milisaniyede bir çalışacak
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // ProgressBar'ı doldur
            progressValue += 2; // Artış hızı
            progressBar1.Value = progressValue;

            // Yüzde bilgisini Label'a yaz
            labelnfo.Text = $"Exiting... {progressValue}%";

            // ProgressBar dolduğunda uygulamayı kapat
            if (progressValue >= 100)
            {
                timer.Stop();
                Application.Exit(); // Uygulamayı kapat
            }
        }
    }
}
