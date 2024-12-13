using System;
using System.Data.SQLite;
using System.IO;

namespace BookSellApplication
{
    internal class DatabaseHelper
    {
        // Göreli yolu belirtip tam bir yol oluşturuyoruz
        private static string relativePath = @"..\..\Files\library.db";
        private static string absolutePath = Path.GetFullPath(relativePath);
        private static string connectionString = $"Data Source={absolutePath};Version=3;";


        public static void InitializeDatabase()
        {
            try
            {
                // Dosyanın bulunduğu klasörü kontrol et ve oluştur
                string directoryPath = Path.GetDirectoryName(absolutePath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Eğer dosya yoksa oluştur
                if (!File.Exists(absolutePath))
                {
                    SQLiteConnection.CreateFile(absolutePath);
                    Console.WriteLine($"Database created at: {absolutePath}");
                }

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Authority Tablosu
                    string createAuthorityTable = @"
                    CREATE TABLE IF NOT EXISTS Authority (
                        authorityId INTEGER PRIMARY KEY AUTOINCREMENT,
                        authority TEXT NOT NULL
                    );";

                    // User Tablosu
                    string createUserTable = @"
                    CREATE TABLE IF NOT EXISTS User (
                        userId INTEGER PRIMARY KEY AUTOINCREMENT,
                        userName TEXT NOT NULL,
                        name TEXT NOT NULL,
                        surname TEXT NOT NULL,
                        password TEXT NOT NULL,
                        phone TEXT NOT NULL,
                        email TEXT NOT NULL,
                        authorityId INTEGER,
                        FOREIGN KEY(authorityId) REFERENCES Authority(authorityId)
                    );";

                    // BookType Tablosu
                    string createBookTypeTable = @"
                    CREATE TABLE IF NOT EXISTS BookType (
                        bookTypeId INTEGER PRIMARY KEY AUTOINCREMENT,
                        bookType TEXT NOT NULL
                    );";

                    // Book Tablosu
                    string createBookTable = @"
                    CREATE TABLE IF NOT EXISTS Book (
                        bookId INTEGER PRIMARY KEY AUTOINCREMENT,
                        bookName TEXT NOT NULL,
                        author TEXT NOT NULL,
                        pageNumber INTEGER NOT NULL,
                        price REAL NOT NULL,
                        quantity INTEGER NOT NULL,
                        bookTypeId INTEGER,
                        FOREIGN KEY(bookTypeId) REFERENCES BookType(bookTypeId)
                    );";

                    // Order Tablosu
                    string createOrderTable = @"
                    CREATE TABLE IF NOT EXISTS [Order] (
                        orderId INTEGER PRIMARY KEY AUTOINCREMENT,
                        bookName TEXT NOT NULL,
                        author TEXT NOT NULL,
                        price REAL NOT NULL
                    );";

                    // SQL komutlarını çalıştır
                    using (var command = new SQLiteCommand(createAuthorityTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (var command = new SQLiteCommand(createUserTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (var command = new SQLiteCommand(createBookTypeTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (var command = new SQLiteCommand(createBookTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (var command = new SQLiteCommand(createOrderTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("Tables created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
