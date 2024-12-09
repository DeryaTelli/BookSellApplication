using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Personal()
        {
            InitializeComponent();
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

        private void btnBookStock_Click(object sender, EventArgs e)
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
        private void btnBookSell_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnBookSell.Height;
            panelNav.Top=btnBookSell.Top;
            btnBookSell.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            BookSell bookSell = new BookSell() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            bookSell.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(bookSell);
            bookSell.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
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

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnBookSell_Leave(object sender, EventArgs e)
        {
            btnBookSell.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnAnalytic_Leave(object sender, EventArgs e)
        {
            btnAnalytic.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnDashboardP_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnBookStockP_Leave(object sender, EventArgs e)
        {
            btnBookStock.BackColor=Color.FromArgb(135, 206, 235);
        }
    }

}
