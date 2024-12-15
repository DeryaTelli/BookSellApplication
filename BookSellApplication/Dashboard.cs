using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using System.Drawing;


namespace BookSellApplication
{
    public partial class Dashboard : Form
    {
        private string connectionString = "Data Source=C:\\A-C#Dersleri\\BookSellApplication\\BookSellApplication\\library.db;Version=3;";

        public Dashboard()
        {
            InitializeComponent();
            LoadBooks();
            CalculateCircleProgress();
            CalculateTotalEarnings();
            
            
        }




        private void CalculateCircleProgress()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Bu ayın toplam kitap satış adedini hesaplayan SQL sorgusu
                    string query = @"
                SELECT COUNT(*) AS TotalBooksSold
                FROM [Order] 
                WHERE strftime('%Y-%m', orderDate) = strftime('%Y-%m', 'now')";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            int totalBooksSold = Convert.ToInt32(result); // Bu ay satılan kitap sayısı
                            int maxBooks = 500; // Maksimum kitap satış adedi (hedef)

                            // Yüzdelik değeri hesaplama
                            double percentage = (totalBooksSold / (double)maxBooks) * 100;

                            // Progress bar özelliklerini ayarlama
                            bunifuCircleProgress1.Maximum = 100; // Progress bar maksimum yüzde 100 olacak
                            bunifuCircleProgress1.Value = (int)Math.Min(percentage, 100); // %100'ü aşmaz
                            bunifuCircleProgress1.SubScriptText = " Kitap"; // Ekstra açıklama
                            bunifuCircleProgress1.Text = $"{percentage:F1}%"; // Yüzdelik dilimi gösterir
                        }
                        else
                        {
                            MessageBox.Show("Bu ay için kayıtlı kitap satışı bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bunifuCircleProgress1.Value = 0;
                            bunifuCircleProgress1.Text = "0%";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Circle Chart yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void CalculateTotalEarnings()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Bu ayın toplam satışlarını hesaplayan SQL sorgusu
                    string query = @"
                SELECT SUM(price) AS TotalEarnings 
                FROM [Order] 
                WHERE strftime('%Y-%m', orderDate) = strftime('%Y-%m', 'now')";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        // Eğer sonuç NULL değilse, toplam tutarı label'a yaz
                        if (result != DBNull.Value && result != null)
                        {
                            double totalEarnings = Convert.ToDouble(result);
                            labelEarn.Text = totalEarnings.ToString();
                        }
                        else
                        {
                            labelEarn.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while calculating total earnings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        

        private void LoadBooks()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            bookName AS 'Book Name',
                            quantity AS 'Quantity'
                        FROM Book";

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataBookTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading books: {ex.Message}");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                LoadBooks();
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            bookName AS 'Book Name', 
                            quantity AS 'Quantity'
                        FROM Book
                        WHERE bookName LIKE @searchQuery";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

                        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Book didn't found.");
                        }

                        dataBookTable.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while searching: {ex.Message}");
                }
            }
        }
    }
}
