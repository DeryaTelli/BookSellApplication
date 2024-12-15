using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BookSellApplication
{
    public partial class BookStock : Form
    {
        private string connectionString = "Data Source=C:\\A-C#Dersleri\\BookSellApplication\\BookSellApplication\\library.db;Version=3;";

        public BookStock()
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
                            pageNumber AS 'Page Number',
                            price AS 'Price',
                            quantity AS 'Quantity',
                            bookTypeId AS 'Book Type ID'
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

        

       

        private void btnStockAdd_Click(object sender, EventArgs e)
        {
            string bookName = txBookName.Text;
            string author = txAuthor.Text;
            int pageNumber = Convert.ToInt32(txPageNumber.Text);
            decimal price = Convert.ToDecimal(txPrice.Text);
            int quantity = Convert.ToInt32(txQuantity.Text);
            int bookTypeId = cbBookType.SelectedIndex;

            // Giriş doğrulaması
            if (string.IsNullOrWhiteSpace(bookName) || string.IsNullOrWhiteSpace(author) ||
                !int.TryParse(txPageNumber.Text, out pageNumber) ||
                !decimal.TryParse(txPrice.Text, out price) ||
                !int.TryParse(txQuantity.Text, out quantity) ||
                cbBookType.SelectedIndex == -1) // ComboBox seçilmemişse
            {
                MessageBox.Show("Please enter valid values for all fields.");
                return;
            }

            bookTypeId = cbBookType.SelectedIndex + 1; // ComboBox'taki seçilen indeksin +1 halini al

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Book (bookName, author, pageNumber, price, quantity, bookTypeId) VALUES (@bookName, @author, @pageNumber, @price, @quantity, @bookTypeId)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@bookName", bookName);
                        command.Parameters.AddWithValue("@author", author);
                        command.Parameters.AddWithValue("@pageNumber", pageNumber);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@bookTypeId", bookTypeId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Book added successfully!");
                        LoadBooks(); // Tabloyu güncelle
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the book: {ex.Message}");
                }
            }
        }
        private void ClearInputs()
        {
            txBookName.Clear();
            txAuthor.Clear();
            txPageNumber.Clear();
            txPrice.Clear();
            txQuantity.Clear();
            cbBookType.SelectedIndex = -1; // ComboBox seçimlerini temizle
        }


        private int selectedBookId = -1; // Seçilen kitabın ID'sini tutan değişken
        // DataGridView hücresine tıklanıldığında seçilen kitabın bilgilerini al
        private void dataBookTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır seçildiğinde
            {
                DataGridViewRow row = dataBookTable.Rows[e.RowIndex];

                // Tüm sütunları al ve textbox'lara aktar
                // Seçilen kitabın ID'sini sakla, doğru sütun adı ile
                selectedBookId = Convert.ToInt32(row.Cells["Book Id"].Value);  // Burada ID sütunu doğru olmalı
                txBookName.Text = row.Cells["Book Name"].Value.ToString();
                txAuthor.Text = row.Cells["Author"].Value.ToString();
                txPageNumber.Text = row.Cells["Page Number"].Value.ToString();
                txPrice.Text = row.Cells["Price"].Value.ToString();
                txQuantity.Text = row.Cells["Quantity"].Value.ToString();
                cbBookType.SelectedIndex = Convert.ToInt32(row.Cells["Book Type ID"].Value) - 1; // ComboBox'taki seçili kitabı göster

                
            }
        }

        // Güncelleme butonunda verileri al ve güncelleme yap
        private void btnStockUpdate_Click(object sender, EventArgs e)
        {
            string bookName = txBookName.Text;
            string author = txAuthor.Text;
            int pageNumber;
            decimal price;
            int quantity;
            int bookTypeId;

            // Giriş doğrulaması
            if (string.IsNullOrWhiteSpace(bookName) ||
                string.IsNullOrWhiteSpace(author) ||
                !int.TryParse(txPageNumber.Text, out pageNumber) ||
                !decimal.TryParse(txPrice.Text, out price) ||
                !int.TryParse(txQuantity.Text, out quantity) ||
                cbBookType.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter valid values for all fields.");
                return;
            }

            // ComboBox seçimini al
            bookTypeId = cbBookType.SelectedIndex + 1; // ComboBox'taki seçilen indeksin +1 hali

            // Seçilen kitap ID'si kontrolü
            if (selectedBookId == -1)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE Book 
                             SET bookName = @bookName, 
                                 author = @author, 
                                 pageNumber = @pageNumber, 
                                 price = @price, 
                                 quantity = @quantity, 
                                 bookTypeId = @bookTypeId 
                             WHERE bookId = @id";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@bookName", bookName);
                        command.Parameters.AddWithValue("@author", author);
                        command.Parameters.AddWithValue("@pageNumber", pageNumber);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@bookTypeId", bookTypeId);
                        command.Parameters.AddWithValue("@id", selectedBookId);  // ID parametresini ekle

                        // Güncellemeyi gerçekleştir
                        command.ExecuteNonQuery();
                        MessageBox.Show("Book updated successfully!");
                        LoadBooks(); // Tabloyu güncelle
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the book: {ex.Message}");
                }
            }
        }


        private void btnStockDelete_Click(object sender, EventArgs e)
        {

            if (selectedBookId == -1) // Eğer hiçbir kitap seçilmemişse
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            // Silme işlemi için kullanıcıdan onay al
            var confirmation = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Book WHERE bookId = @id";

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", selectedBookId);

                            // Silme işlemini gerçekleştir
                            command.ExecuteNonQuery();
                            MessageBox.Show("Book deleted successfully!");

                            // Tabloyu güncelle
                            LoadBooks();

                            // Seçilen kitabın ID'sini sıfırla
                            selectedBookId = -1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the book: {ex.Message}");
                    }
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

    }
}


    

