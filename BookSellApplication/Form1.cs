using System;
using System.Data.SQLite; // SQLite için gerekli
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookSellApplication
{
    public partial class Form1 : Form
    {
        private int loginAttempts = 3; // Giriş deneme hakkı

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 300; // Genişlik
            this.Height = 400; // Yükseklik
        }

        // Form1'de giriş yapıldığında, kullanıcı adı ve şifreyi kontrol ediyoruz.
        private void button1_Click(object sender, EventArgs e)
        {
            if (loginAttempts == 0)
            {
                MessageBox.Show("Too many failed attempts! Application will close.");
                Application.Exit();
            }

            string connectionString = "Data Source=C:\\A-C#Dersleri\\BookSellApplication\\BookSellApplication\\library.db;Version=3;";
            string query = "SELECT authorityId, userId FROM User WHERE userName = @userName AND password = @password";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userName", txUserName.Text);
                        command.Parameters.AddWithValue("@password", txPassword.Text);

                        SQLiteDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int authorityId = Convert.ToInt32(reader["authorityId"]);
                            string userId = reader["userId"].ToString(); // Kullanıcının ID'sini al

                            // Hata ayıklama: Kullanıcı ID'sini kontrol et
                          //  MessageBox.Show($"User ID: {userId}");

                            switch (authorityId)
                            {
                                case 1:
                                    Form2 adminForm = new Form2(userId); // Kullanıcı ID'sini Form2'ye geçir
                                    adminForm.Show();
                                    break;

                                case 2:
                                    
                                    Personal personalForm = new Personal(userId); // userId'yi doğru şekilde geçir
                                    personalForm.Show();
                                    break;

                                default:
                                    MessageBox.Show("No page available for this authority!");
                                    break;
                            }
                            this.Hide();
                        }
                        else
                        {
                            loginAttempts--;
                            MessageBox.Show($"Invalid credentials! Remaining attempts: {loginAttempts}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


    }
}
