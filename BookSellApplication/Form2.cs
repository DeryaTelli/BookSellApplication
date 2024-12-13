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

        public Form2()
        {
            InitializeComponent();
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
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNav_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
