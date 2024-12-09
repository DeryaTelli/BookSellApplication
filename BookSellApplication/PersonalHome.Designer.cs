namespace BookSellApplication
{
    partial class PersonalHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnLogoutP = new System.Windows.Forms.Button();
            this.btnBookSellP = new System.Windows.Forms.Button();
            this.btnAnalyticP = new System.Windows.Forms.Button();
            this.btnDashboardP = new System.Windows.Forms.Button();
            this.btnBookStockP = new System.Windows.Forms.Button();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 137);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Some users text here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(52, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BookSellApplication.Properties.Resources.rb_4707__1_;
            this.pictureBox1.Location = new System.Drawing.Point(64, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 450);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelNav);
            this.panel2.Controls.Add(this.btnLogoutP);
            this.panel2.Controls.Add(this.btnBookSellP);
            this.panel2.Controls.Add(this.btnAnalyticP);
            this.panel2.Controls.Add(this.btnDashboardP);
            this.panel2.Controls.Add(this.btnBookStockP);
            this.panel2.Location = new System.Drawing.Point(3, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 304);
            this.panel2.TabIndex = 3;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelNav.Location = new System.Drawing.Point(0, 28);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(3, 100);
            this.panelNav.TabIndex = 3;
            // 
            // btnLogoutP
            // 
            this.btnLogoutP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogoutP.FlatAppearance.BorderSize = 0;
            this.btnLogoutP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutP.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutP.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogoutP.Image = global::BookSellApplication.Properties.Resources.setting_17107264__1_;
            this.btnLogoutP.Location = new System.Drawing.Point(0, 264);
            this.btnLogoutP.Name = "btnLogoutP";
            this.btnLogoutP.Size = new System.Drawing.Size(206, 40);
            this.btnLogoutP.TabIndex = 10;
            this.btnLogoutP.Text = "Logout";
            this.btnLogoutP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogoutP.UseVisualStyleBackColor = true;
            this.btnLogoutP.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogoutP.Leave += new System.EventHandler(this.btnLogoutP_Leave);
            // 
            // btnBookSellP
            // 
            this.btnBookSellP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookSellP.FlatAppearance.BorderSize = 0;
            this.btnBookSellP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSellP.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSellP.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBookSellP.Image = global::BookSellApplication.Properties.Resources.ledger_11771872__1_;
            this.btnBookSellP.Location = new System.Drawing.Point(0, 120);
            this.btnBookSellP.Name = "btnBookSellP";
            this.btnBookSellP.Size = new System.Drawing.Size(206, 40);
            this.btnBookSellP.TabIndex = 8;
            this.btnBookSellP.Text = "Book Sell";
            this.btnBookSellP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBookSellP.UseVisualStyleBackColor = true;
            this.btnBookSellP.Click += new System.EventHandler(this.btnBookSellP_Click);
            this.btnBookSellP.Leave += new System.EventHandler(this.btnBookSellP_Leave);
            // 
            // btnAnalyticP
            // 
            this.btnAnalyticP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalyticP.FlatAppearance.BorderSize = 0;
            this.btnAnalyticP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyticP.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyticP.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAnalyticP.Image = global::BookSellApplication.Properties.Resources.line_chart_15265966__1_;
            this.btnAnalyticP.Location = new System.Drawing.Point(0, 80);
            this.btnAnalyticP.Name = "btnAnalyticP";
            this.btnAnalyticP.Size = new System.Drawing.Size(206, 40);
            this.btnAnalyticP.TabIndex = 4;
            this.btnAnalyticP.Text = "Analytics";
            this.btnAnalyticP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnalyticP.UseVisualStyleBackColor = true;
            this.btnAnalyticP.Click += new System.EventHandler(this.btnAnalyticP_Click);
            this.btnAnalyticP.Leave += new System.EventHandler(this.btnAnalyticP_Leave);
            // 
            // btnDashboardP
            // 
            this.btnDashboardP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboardP.FlatAppearance.BorderSize = 0;
            this.btnDashboardP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardP.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardP.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDashboardP.Image = global::BookSellApplication.Properties.Resources.home_9449212__1_;
            this.btnDashboardP.Location = new System.Drawing.Point(0, 40);
            this.btnDashboardP.Name = "btnDashboardP";
            this.btnDashboardP.Size = new System.Drawing.Size(206, 40);
            this.btnDashboardP.TabIndex = 3;
            this.btnDashboardP.Text = "Dashboard";
            this.btnDashboardP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboardP.UseVisualStyleBackColor = true;
            this.btnDashboardP.Click += new System.EventHandler(this.btnDashboardP_Click);
            this.btnDashboardP.Leave += new System.EventHandler(this.btnDashboardP_Leave);
            // 
            // btnBookStockP
            // 
            this.btnBookStockP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookStockP.FlatAppearance.BorderSize = 0;
            this.btnBookStockP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookStockP.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookStockP.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBookStockP.Image = global::BookSellApplication.Properties.Resources.books_8798348__1_;
            this.btnBookStockP.Location = new System.Drawing.Point(0, 0);
            this.btnBookStockP.Name = "btnBookStockP";
            this.btnBookStockP.Size = new System.Drawing.Size(206, 40);
            this.btnBookStockP.TabIndex = 11;
            this.btnBookStockP.Text = "Book Stock";
            this.btnBookStockP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBookStockP.UseVisualStyleBackColor = true;
            this.btnBookStockP.Click += new System.EventHandler(this.btnBookStockP_Click);
            this.btnBookStockP.Leave += new System.EventHandler(this.btnBookStockP_Leave);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.AutoScroll = true;
            this.pnlFormLoader.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFormLoader.Location = new System.Drawing.Point(217, 0);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(683, 450);
            this.pnlFormLoader.TabIndex = 11;
            // 
            // PersonalHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookSellApplication.Properties.Resources.Screenshot_2024_12_02_134147;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalHome";
            this.Text = "PersonalHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnLogoutP;
        private System.Windows.Forms.Button btnBookSellP;
        private System.Windows.Forms.Button btnAnalyticP;
        private System.Windows.Forms.Button btnDashboardP;
        private System.Windows.Forms.Button btnBookStockP;
        private System.Windows.Forms.Panel pnlFormLoader;
    }
}