using MaterialSkin;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Data.SqlTypes;
using System.Windows.Controls;

namespace BookSellApplication
{
    public partial class AddUsers : Form
    {
        private string connectionString = "Data Source=C:\\A-C#Dersleri\\BookSellApplication\\BookSellApplication\\library.db;Version=3;";

        public AddUsers()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    userId AS 'User Id',
                    userName AS 'User Name',
                    name AS 'Name',
                    surname AS 'Surname',
                    password AS 'Password',
                    phone AS 'Phone',
                    email AS 'Email',
                    authorityId AS 'Authority'
                FROM User";

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataUserTable.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading Users: {ex.Message}");
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            string userName = txUserName.Text;
            string name = txName.Text;
            string surname = txSurname.Text;
            string password = txPassword.Text;
            string email = txEmail.Text;
            string phone = mtxPhone.Text;



            // Giriş doğrulaması
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname)|| string.IsNullOrWhiteSpace(password)||
                string.IsNullOrWhiteSpace(email)|| string.IsNullOrWhiteSpace(phone))


            {
                MessageBox.Show("Please enter valid values for all fields.");
                return;
            }


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))


            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO User (userName,name,surname, password, phone, email , authorityId) VALUES (@userName, @name, @surname, @password, @phone, @email, '2')";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@email", email);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Personal added successfully!");
                        LoadUsers(); // Tabloyu güncelle
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the personal: {ex.Message}");
                }


            }
        }
        private void ClearInputs()
        {
            txUserName.Clear();
            txName.Clear();
            txSurname.Clear();
            txPassword.Clear();
            mtxPhone.Clear();
            txEmail.Clear();
        }


        private int selectedUserId = -1; // Seçilen user ID'sini tutan değişken
        // DataGridView hücresine tıklanıldığında seçilen user bilgilerini al
        private void dataUserTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır seçildiğinde
            {
                DataGridViewRow row = dataUserTable.Rows[e.RowIndex];

                // Tüm sütunları al ve textbox'lara aktar
                // Seçilen kitabın ID'sini sakla, doğru sütun adı ile
                selectedUserId = Convert.ToInt32(row.Cells["User Id"].Value);  // Burada ID sütunu doğru olmalı
                txUserName.Text = row.Cells["User Name"].Value.ToString();
                txName.Text = row.Cells["Name"].Value.ToString();
                txSurname.Text = row.Cells["Surname"].Value.ToString();
                txPassword.Text = row.Cells["Password"].Value.ToString();
                txEmail.Text = row.Cells["Email"].Value.ToString();
                mtxPhone.Text = row.Cells["Phone"].Value.ToString();


            }

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

            string userName = txUserName.Text;
            string name = txName.Text;
            string surname = txSurname.Text;
            string password = txPassword.Text;
            string email = txEmail.Text;
            string phone = mtxPhone.Text;


            // Giriş doğrulaması
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname)|| string.IsNullOrWhiteSpace(password)||
                string.IsNullOrWhiteSpace(email)|| string.IsNullOrWhiteSpace(phone))

            {
                MessageBox.Show("Please enter valid values for all fields.");
                return;
            }

          
            // Seçilen user ID'si kontrolü
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a personal to update.");
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

               
                try
                {
                    connection.Open();
                    string query = @"UPDATE User 
                             SET userName = @userName, 
                                 name = @name, 
                                 surname = @surname, 
                                 password = @password, 
                                 email = @email, 
                                 phone = @phone 
                             WHERE userId = @id";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@id", selectedUserId);  // ID parametresini ekle

                        // Güncellemeyi gerçekleştir
                        command.ExecuteNonQuery();
                        MessageBox.Show("Personal updated successfully!");
                        LoadUsers(); // Tabloyu güncelle
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the personal: {ex.Message}");
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1) // Eğer hiçbir kitap seçilmemişse
            {
                MessageBox.Show("Please select a personal to delete.");
                return;
            }

            // Silme işlemi için kullanıcıdan onay al
            var confirmation = MessageBox.Show("Are you sure you want to delete this personal?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM User WHERE userId = @id";

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", selectedUserId);

                            // Silme işlemini gerçekleştir
                            command.ExecuteNonQuery();
                            MessageBox.Show("Personal deleted successfully!");

                            // Tabloyu güncelle
                            LoadUsers();

                            // Seçilen kitabın ID'sini sıfırla
                            selectedUserId = -1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the personal: {ex.Message}");
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
                LoadUsers(); // Eğer arama yapılmazsa, tüm kitaplar tekrar yüklenir
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Arama kelimesine göre SQL sorgusunu oluştur
                    string query = "SELECT * FROM User WHERE name LIKE @searchQuery";

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
                            MessageBox.Show("Personal didn't found ");
                        }


                        // DataGridView'a arama sonuçlarını yükle
                        dataUserTable.DataSource = dataTable;
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
