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
    public partial class Dashboard : Form
    {
        private string connectionString = "Data Source=C:\\A-C#Dersleri\\BookSellApplication\\BookSellApplication\\library.db;Version=3;";

        public Dashboard()
        {
            InitializeComponent();
            LoadBooks();
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
            // Arama kutusundan alınan arama kelimesi
            string searchQuery = txSearch.Text.Trim();

            // Eğer arama kutusu boşsa, tüm kitapları göster
            if (string.IsNullOrEmpty(searchQuery))
            {
                LoadBooks(); // Eğer arama yapılmazsa, tüm kitaplar tekrar yüklenir
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Arama kelimesine göre SQL sorgusunu oluştur
                    string query = @"
                SELECT 
                    bookName AS 'Book Name', 
                    quantity AS 'Quantity'
                FROM Book
                WHERE bookName LIKE @searchQuery";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Arama kelimesi için parametre ekle
                        command.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");

                        // Sorguyu çalıştır ve sonuçları oku
                        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Eğer veri bulunmazsa, kullanıcıya mesaj göster
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Book didn't found ");
                        }

                        // DataGridView'a arama sonuçlarını yükle
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

