using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SQLite;

namespace BookSellApplication
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
         int nLeftRect,
         int nTopRect,
         int nRightRect,
         int nBottomRect,
         int nWidthEllipse,
         int nHeightEllipse);

        private string connectionString = "Data Source=C:\\A-C#Dersleri\\BookSellApplication\\BookSellApplication\\library.db;Version=3;";
       
        public Form2(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
            this.Width = 900;
            this.Height = 450;
            Region=System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNav.Height=btnDashboard.Height;
            panelNav.Top=btnDashboard.Top;
            panelNav.Left=btnDashboard.Left;
            btnDashboard.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            Dashboard dashboard = new Dashboard() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            dashboard.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard);
            dashboard.Show();

            GetUserName();
        }

        private string currentUserId;

        // Kullanıcının ismini almak için metod
        private void GetUserName()
        {
            string connectionString = "Data Source=C:\\A-C#Dersleri\\BookSellApplication\\BookSellApplication\\library.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                    SELECT name, surname
                    FROM User
                    WHERE userId = @userId";  // Kullanıcı ID'sine göre sorgu

                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", currentUserId); // currentUserId: Form1'den alınan kullanıcı ID'si

                    SQLiteDataReader reader = command.ExecuteReader();

                    if (reader.Read()) // Veritabanından kullanıcı bilgisi okunduysa
                    {
                        string firstName = reader["name"].ToString();
                        string lastName = reader["surname"].ToString();

                        // Kullanıcının ismini ve soyadını Label'a yazdıralım
                        lblUserName.Text = $"{firstName} {lastName}"; // lblUserName: Kullanıcı ismini gösterecek Label
                    }
                    else
                    {
                        // Kullanıcı bulunamazsa
                        lblUserName.Text = "User not found.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading user data: {ex.Message}");
                }
            }
        }




        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnDashboard.Height;
            panelNav.Top=btnDashboard.Top;
            panelNav.Left=btnDashboard.Left;
            btnDashboard.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            Dashboard dashboard = new Dashboard() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            dashboard.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard);
            dashboard.Show();
       
        }

        private void btnAnalytic_Click(object sender, EventArgs e)
        {

            panelNav.Height=btnAnalytic.Height;
            panelNav.Top=btnAnalytic.Top;
            btnAnalytic.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            FrmAnalytics frmAnalytics = new FrmAnalytics() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            frmAnalytics.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAnalytics);
            frmAnalytics.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnAddUser.Height;
            panelNav.Top=btnAddUser.Top;
            btnAddUser.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            AddUsers addUsers = new AddUsers() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            addUsers.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(addUsers);
            addUsers.Show();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnLogout.Height;
            panelNav.Top=btnLogout.Top;
            btnLogout.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            Logout logout = new Logout() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            logout.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(logout);
            logout.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnAnalytic_Leave(object sender, EventArgs e)
        {
            btnAnalytic.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnAddUser_Leave(object sender, EventArgs e)
        {
            btnAddUser.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
           btnLogout.BackColor=Color.FromArgb(135, 206, 235);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnBookStock.Height;
            panelNav.Top=btnBookStock.Top;
            btnBookStock.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            BookStock bookStock = new BookStock { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            bookStock.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(bookStock);
            bookStock.Show();
        }

        private void btnBookStock_Leave(object sender, EventArgs e)
        { 
            btnBookStock.BackColor=Color.FromArgb(135, 206, 235);
        }

        
    }
}
