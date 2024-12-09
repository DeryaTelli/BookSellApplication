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
    public partial class PersonalHome : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse);

        public PersonalHome()
        {
            InitializeComponent();
            Region=System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNav.Height=btnDashboardP.Height;
            panelNav.Top=btnDashboardP.Top;
            panelNav.Left=btnDashboardP.Left;
            btnDashboardP.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            Dashboard dashboard = new Dashboard() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            dashboard.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnBookStockP_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnBookStockP.Height;
            panelNav.Top=btnBookStockP.Top;
            btnBookStockP.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            BookStock bookStock = new BookStock { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            bookStock.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(bookStock);
            bookStock.Show();
        }

        private void btnDashboardP_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnDashboardP.Height;
            panelNav.Top=btnDashboardP.Top;
            panelNav.Left=btnDashboardP.Left;
            btnDashboardP.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            Dashboard dashboard = new Dashboard() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            dashboard.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnAnalyticP_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnAnalyticP.Height;
            panelNav.Top=btnAnalyticP.Top;
            btnAnalyticP.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            FrmAnalytics frmAnalytics = new FrmAnalytics() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            frmAnalytics.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAnalytics);
            frmAnalytics.Show();
        }

        private void btnBookSellP_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnBookSellP.Height;
            panelNav.Top=btnBookSellP.Top;
            btnBookSellP.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            BookSell bookSell = new BookSell() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            bookSell.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(bookSell);
            bookSell.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelNav.Height=btnLogoutP.Height;
            panelNav.Top=btnLogoutP.Top;
            btnLogoutP.BackColor=Color.FromArgb(146, 158, 173);
            //lblTitle.Text="Dashboard";
            this.pnlFormLoader.Controls.Clear();
            Logout logout = new Logout() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true };
            logout.FormBorderStyle=FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(logout);
            logout.Show();
        }

        private void btnLogoutP_Leave(object sender, EventArgs e)
        {
            btnLogoutP.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnBookSellP_Leave(object sender, EventArgs e)
        {
            btnBookSellP.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnAnalyticP_Leave(object sender, EventArgs e)
        {
            btnAnalyticP.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnDashboardP_Leave(object sender, EventArgs e)
        {
            btnDashboardP.BackColor=Color.FromArgb(135, 206, 235);
        }

        private void btnBookStockP_Leave(object sender, EventArgs e)
        {
            btnBookStockP.BackColor=Color.FromArgb(135, 206, 235);
        }
    }
}
