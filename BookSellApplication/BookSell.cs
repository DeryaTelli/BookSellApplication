using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace BookSellApplication
{
    public partial class BookSell : Form
    {
        private string connectionString = "Data Source=C:\\A-C#Dersleri\\BookSellApplication\\BookSellApplication\\library.db;Version=3;";

        public BookSell()
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
                            bookId AS 'Book Id',
                            bookName AS 'Book Name',
                            author AS 'Author',                         
                            price AS 'Price',
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
                    string query = "SELECT * FROM Book WHERE bookName LIKE @searchQuery";

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

        private void btnSell_Click(object sender, EventArgs e)
        {
          
            // Önce DataGridView'den seçilen satırı alıyoruz
            if (dataBookTable.CurrentRow != null) // Satır seçilmiş mi kontrol ediyoruz
            {
                try
                {
                    // Seçilen kitap bilgilerini alıyoruz
                    string bookName = dataBookTable.CurrentRow.Cells["Book Name"].Value.ToString();
                    string author = dataBookTable.CurrentRow.Cells["Author"].Value.ToString();
                    int currentQuantity = Convert.ToInt32(dataBookTable.CurrentRow.Cells["Quantity"].Value);
                    double price = Convert.ToDouble(dataBookTable.CurrentRow.Cells["Price"].Value);

                    // Kullanıcının girdiği satış miktarını alıyoruz
                    int sellQuantity = Convert.ToInt32(txQuantity.Text);

                    // Eğer satış miktarı stoktan fazla ise uyarı veriyoruz
                    if (sellQuantity > currentQuantity)
                    {
                        MessageBox.Show("Satış miktarı mevcut stoktan fazla olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Yeni miktarı hesaplıyoruz
                    int newQuantity = currentQuantity - sellQuantity;

                    // Toplam fiyatı hesaplıyoruz
                    double totalPrice = sellQuantity * price;

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        // 1. Adım: Book tablosundaki quantity değerini güncelle
                        string updateBookQuery = "UPDATE Book SET quantity = @newQuantity WHERE bookName = @bookName AND author = @author";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateBookQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@newQuantity", newQuantity);
                            updateCommand.Parameters.AddWithValue("@bookName", bookName);
                            updateCommand.Parameters.AddWithValue("@author", author);
                            updateCommand.ExecuteNonQuery();
                        }

                        // 2. Adım: Siparişi Order tablosuna ekle
                        string insertOrderQuery = @"
                        INSERT INTO [Order] (bookName, author, quantity, price, orderDate)
                        VALUES (@bookName, @author, @quantity, @price, @orderDate)";

                        using (SQLiteCommand insertCommand = new SQLiteCommand(insertOrderQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@bookName", bookName);
                            insertCommand.Parameters.AddWithValue("@author", author);
                            insertCommand.Parameters.AddWithValue("@quantity", sellQuantity);
                            insertCommand.Parameters.AddWithValue("@price", totalPrice);
                            insertCommand.Parameters.AddWithValue("@orderDate", DateTime.Now.ToString("yyyy-MM-dd"));
                            insertCommand.ExecuteNonQuery();
                        }


                        connection.Close();
                    }

                    // Kullanıcıya başarı mesajı gösteriyoruz
                    MessageBox.Show("Satış başarıyla gerçekleştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // DataGridView'i güncellemek için kitapları tekrar yükle
                    LoadBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        

        }
    }
}
