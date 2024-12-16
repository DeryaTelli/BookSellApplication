using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSellApplication
{
    public partial class Personal : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse);
       private string currentUserId;
        public Personal(string userId)
        {
            InitializeComponent();
            currentUserId = userId;
            
            this.Width = 900;
            this.Height = 450;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // Anchor kullanarak panelNav'in hizalanmasını sağlıyoruz
            panelNav.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Butonlar için hizalama (Anchor kullanarak)
            btnDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBookStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAnalytic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBookSell.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
          
            panelNav.Height=btnDashboard.Height;
            panelNav.Top=btnDashboard.Top;
            panelNav.Left=btnDashboard.Left;
            btnDashboard.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.formPanel.Controls.Clear();
            Dashboard dashboard = new Dashboard() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            dashboard.FormBorderStyle=FormBorderStyle.None;
            this.formPanel.Controls.Add(dashboard);
            dashboard.Show();
            GetUserName();
        }

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



        private void btnBookStock_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnBookStock.Height;
            panelNav.Top=btnBookStock.Top;
            btnBookStock.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.formPanel.Controls.Clear();
            BookStock bookStock = new BookStock { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            bookStock.FormBorderStyle=FormBorderStyle.None;
            this.formPanel.Controls.Add(bookStock);
            bookStock.Show();
        }
       
    
        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            panelNav.Height=btnDashboard.Height;
            panelNav.Top=btnDashboard.Top;
            panelNav.Left=btnDashboard.Left;
            btnDashboard.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.formPanel.Controls.Clear();
            Dashboard dashboard = new Dashboard() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            dashboard.FormBorderStyle=FormBorderStyle.None;
            this.formPanel.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnAnalytic_Click_1(object sender, EventArgs e)
        {
            panelNav.Height=btnAnalytic.Height;
            panelNav.Top=btnAnalytic.Top;
            btnAnalytic.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.formPanel.Controls.Clear();
            FrmAnalytics frmAnalytics = new FrmAnalytics() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            frmAnalytics.FormBorderStyle=FormBorderStyle.None;
            this.formPanel.Controls.Add(frmAnalytics);
            frmAnalytics.Show();

        }

        private void btnBookSell_Click_1(object sender, EventArgs e)
        {
            panelNav.Height=btnBookSell.Height;
            panelNav.Top=btnBookSell.Top;
            btnBookSell.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.formPanel.Controls.Clear();
            BookSell bookSell = new BookSell() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            bookSell.FormBorderStyle=FormBorderStyle.None;
            this.formPanel.Controls.Add(bookSell);
            bookSell.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            panelNav.Height=btnLogout.Height;
            panelNav.Top=btnLogout.Top;
            btnLogout.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.formPanel.Controls.Clear();
            Logout logout = new Logout() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            logout.FormBorderStyle=FormBorderStyle.None;
            this.formPanel.Controls.Add(logout);
            logout.Show();

        }

        private void btnBookStock_Leave(object sender, EventArgs e)
        {
            btnBookStock.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnAnalytic_Leave(object sender, EventArgs e)
        {
            btnAnalytic.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnBookSell_Leave(object sender, EventArgs e)
        {
            btnBookSell.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
