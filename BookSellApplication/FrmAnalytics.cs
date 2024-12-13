using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSellApplication
{
    public partial class FrmAnalytics : Form
    {
        private string connectionString = "Data Source=C:\\A-C#Dersleri\\BookSellApplication\\BookSellApplication\\library.db;Version=3;";

        public FrmAnalytics()
        {
            InitializeComponent();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kitap türleri ve her bir türdeki toplam kitap miktarını almak için SQL sorgusu
                    string query = @"
                SELECT bt.bookType, SUM(b.quantity) AS 'Total Quantity'
                FROM Book b
                INNER JOIN BookType bt ON b.bookTypeId = bt.bookTypeId
                GROUP BY bt.bookType";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        SQLiteDataReader reader = command.ExecuteReader();

                        // Grafiği temizle
                        chart1.Series.Clear();

                        // Yeni bir seri ekleyelim
                        var series = chart1.Series.Add("Book Types");

                        // Veriyi grafikte göstermek için, her türü ve kitap miktarını ekleyelim
                        while (reader.Read())
                        {
                            string bookType = reader["bookType"].ToString();
                            int totalQuantity = Convert.ToInt32(reader["Total Quantity"]);

                            // Veriyi grafiğe ekle (X: kitap türü, Y: toplam kitap miktarı)
                            series.Points.AddXY(bookType, totalQuantity);
                        }

                        // Grafik ayarları
                        series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        series.IsValueShownAsLabel = true; // Değerleri etiket olarak göster

                        // İsteğe bağlı olarak, grafik başlığını ekleyebilirsiniz
                        chart1.Titles.Clear();
                        chart1.Titles.Add("Kitap Türlerine Göre Toplam Kitap Miktarları");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                }
            }
        }

       

    }
}
