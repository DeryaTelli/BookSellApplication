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
        private double lastPercentage = 0;

        public Dashboard()
        {
            InitializeComponent();
            LoadBooks();
            lastPercentage = GetProgressFromDatabase(); // Veritabanından progress oranını al
            if (lastPercentage == 0)
            {
                lastPercentage = 0; // Veritabanında 0 varsa, varsayılan olarak 0 ata
            }
            UpdatePercentageLabel(lastPercentage); // Label'ı güncelle
            CalculateTotalEarnings(); // Toplam kazanç hesaplamayı yap
        }

        private void UpdatePercentageLabel(double percentage)
        {
            // Yüzdeyi 0-100 arasında sınırlamak
            percentage = Math.Max(0, Math.Min(percentage, 100));

            // lblPercentage'yi güncelle
            lblPercentage.Text = $"{percentage:F1}%"; // Yüzdeyi düzgün şekilde yazdır
        }

        private void CalculateCircleProgressWeekly()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                string query = @"
            SELECT SUM(quantity) AS TotalBooksSold
            FROM [Order] 
            WHERE strftime('%Y-%W', orderDate) = strftime('%Y-%W', 'now')";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        int totalBooksSold = Convert.ToInt32(result);
                        int maxBooks = 50; // Maksimum hedef kitap sayısı

                        double percentage = (totalBooksSold / (double)maxBooks) * 100;
                        lastPercentage = percentage; // Değeri sakla

                        UpdatePercentageLabel(percentage); // Label'ı güncelle
                        UpdateProgressInDatabase(percentage); // Veritabanını güncelle
                    }
                    else
                    {
                        lastPercentage = 0;
                        UpdatePercentageLabel(0); // Label'ı 0 yap
                        MessageBox.Show("There are no book sales registered for this week.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private void UpdateProgressInDatabase(double percentage)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                string query = @"
            INSERT OR REPLACE INTO Progress (id, percentage) 
            VALUES (1, @percentage)"; // Veritabanında sadece bir satır olacak

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@percentage", percentage);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating progress: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private double GetProgressFromDatabase()
        {
            double percentage = 0;

            SQLiteConnection connection = new SQLiteConnection(connectionString);
            try
            {
                connection.Open();
                string query = @"
            SELECT percentage FROM Progress 
            WHERE id = 1"; // Veritabanından kaydedilen değeri al

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        percentage = Convert.ToDouble(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving progress: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

            return percentage;
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            // Form aktif olduğunda progress bar'ı veritabanından al
            lastPercentage = GetProgressFromDatabase();
            UpdatePercentageLabel(lastPercentage); // Label'ı güncelle
        }

        private void CalculateTotalEarnings()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                    SELECT SUM(price) AS TotalEarnings 
                    FROM [Order] 
                    WHERE strftime('%Y-%m', orderDate) = strftime('%Y-%m', 'now')";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

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
