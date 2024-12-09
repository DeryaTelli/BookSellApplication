using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BookSellApplication
{
    public partial class Form1 : Form
    {

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
            Region=System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 300; // Genişlik
            this.Height = 400; // Yükseklik
          

        }
       


        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txUserName.Text =="Derya" && txPassword.Text=="123456") 
            {
               // MessageBox.Show("You are now logged in!");
                // İkinci formu oluştur ve göster
                Form2 secondForm = new Form2();
                secondForm.Show();

                // (Opsiyonel) İlk formu gizlemek isterseniz
                this.Hide();

            }else if (txUserName.Text =="Derya2" && txPassword.Text=="123456")
            { 
                Personal personal= new Personal();
                personal.Show();
                this.Hide();

            }
            else if (txUserName.Text == "" || txPassword.Text=="")
            {
                MessageBox.Show("Please give UserName && Password to proceed");
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txUserName_Enter(object sender, EventArgs e)
        {
            if (txUserName.Text =="Username")
            {
                txUserName.Text="";
                txUserName.ForeColor=Color.Black;
            }
        }

        private void txUserName_Leave(object sender, EventArgs e)
        {
            if (txUserName.Text =="")
            {
                txUserName.Text="Username";
                txUserName.ForeColor=Color.Silver;
            }
        }

        private void txPassword_Enter(object sender, EventArgs e)
        {
            if (txPassword.Text =="Password")
            {
                txPassword.Text="";
                txPassword.ForeColor=Color.Black;
            }
        }
        private void txPassword_Leave(object sender, EventArgs e)
        {
            if (txPassword.Text =="")
            {
                txPassword.Text="Password";
                txPassword.ForeColor=Color.Silver;
            }
        }
    }
}
