namespace BookSellApplication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txUserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ıconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ıconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txUserName
            // 
            this.txUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txUserName.ForeColor = System.Drawing.Color.Black;
            this.txUserName.Location = new System.Drawing.Point(79, 211);
            this.txUserName.Name = "txUserName";
            this.txUserName.Size = new System.Drawing.Size(198, 27);
            this.txUserName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(79, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 1);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(79, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 1);
            this.panel3.TabIndex = 8;
            // 
            // txPassword
            // 
            this.txPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txPassword.ForeColor = System.Drawing.Color.Black;
            this.txPassword.Location = new System.Drawing.Point(79, 302);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(198, 27);
            this.txPassword.TabIndex = 7;
            this.txPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(196, 369);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 52);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // ıconPictureBox2
            // 
            this.ıconPictureBox2.BackColor = System.Drawing.Color.White;
            this.ıconPictureBox2.ForeColor = System.Drawing.Color.Black;
            this.ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.ıconPictureBox2.IconColor = System.Drawing.Color.Black;
            this.ıconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox2.IconSize = 38;
            this.ıconPictureBox2.Location = new System.Drawing.Point(35, 291);
            this.ıconPictureBox2.Name = "ıconPictureBox2";
            this.ıconPictureBox2.Size = new System.Drawing.Size(38, 41);
            this.ıconPictureBox2.TabIndex = 9;
            this.ıconPictureBox2.TabStop = false;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.White;
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 38;
            this.ıconPictureBox1.Location = new System.Drawing.Point(35, 202);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(38, 39);
            this.ıconPictureBox1.TabIndex = 6;
            this.ıconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BookSellApplication.Properties.Resources.Purple_Modern_Futuristic_Technology_Presentation__1_;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ıconPictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 155);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Page";
            // 
            // ıconPictureBox3
            // 
            this.ıconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.ıconPictureBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ıconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ıconPictureBox3.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ıconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox3.IconSize = 92;
            this.ıconPictureBox3.Location = new System.Drawing.Point(145, 3);
            this.ıconPictureBox3.Name = "ıconPictureBox3";
            this.ıconPictureBox3.Size = new System.Drawing.Size(94, 92);
            this.ıconPictureBox3.TabIndex = 0;
            this.ıconPictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.ıconPictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txUserName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txUserName;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Button btnLogin;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

