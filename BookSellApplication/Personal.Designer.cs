namespace BookSellApplication
{
    partial class Personal
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBookSell = new System.Windows.Forms.Button();
            this.btnAnalytic = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBookStock = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 450);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 137);
            this.panel1.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUserName.Location = new System.Drawing.Point(52, 79);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 18);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.panelNav);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnBookSell);
            this.panel2.Controls.Add(this.btnAnalytic);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.btnBookStock);
            this.panel2.Location = new System.Drawing.Point(0, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 304);
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
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogout.Image = global::BookSellApplication.Properties.Resources.setting_17107264__1_;
            this.btnLogout.Location = new System.Drawing.Point(0, 264);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 40);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            this.btnLogout.Leave += new System.EventHandler(this.btnLogout_Leave);
            // 
            // btnBookSell
            // 
            this.btnBookSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookSell.FlatAppearance.BorderSize = 0;
            this.btnBookSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSell.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSell.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBookSell.Image = global::BookSellApplication.Properties.Resources.ledger_11771872__1_1;
            this.btnBookSell.Location = new System.Drawing.Point(0, 120);
            this.btnBookSell.Name = "btnBookSell";
            this.btnBookSell.Size = new System.Drawing.Size(220, 40);
            this.btnBookSell.TabIndex = 8;
            this.btnBookSell.Text = "Book Sell";
            this.btnBookSell.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBookSell.UseVisualStyleBackColor = true;
            this.btnBookSell.Click += new System.EventHandler(this.btnBookSell_Click_1);
            this.btnBookSell.Leave += new System.EventHandler(this.btnBookSell_Leave);
            // 
            // btnAnalytic
            // 
            this.btnAnalytic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalytic.FlatAppearance.BorderSize = 0;
            this.btnAnalytic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytic.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytic.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAnalytic.Image = global::BookSellApplication.Properties.Resources.line_chart_15265966__1_;
            this.btnAnalytic.Location = new System.Drawing.Point(0, 80);
            this.btnAnalytic.Name = "btnAnalytic";
            this.btnAnalytic.Size = new System.Drawing.Size(220, 40);
            this.btnAnalytic.TabIndex = 4;
            this.btnAnalytic.Text = "Analytics";
            this.btnAnalytic.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnalytic.UseVisualStyleBackColor = true;
            this.btnAnalytic.Click += new System.EventHandler(this.btnAnalytic_Click_1);
            this.btnAnalytic.Leave += new System.EventHandler(this.btnAnalytic_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDashboard.Image = global::BookSellApplication.Properties.Resources.home_9449212__1_;
            this.btnDashboard.Location = new System.Drawing.Point(0, 40);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 40);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // btnBookStock
            // 
            this.btnBookStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookStock.FlatAppearance.BorderSize = 0;
            this.btnBookStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookStock.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookStock.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBookStock.Image = global::BookSellApplication.Properties.Resources.books_8798348__1_;
            this.btnBookStock.Location = new System.Drawing.Point(0, 0);
            this.btnBookStock.Name = "btnBookStock";
            this.btnBookStock.Size = new System.Drawing.Size(220, 40);
            this.btnBookStock.TabIndex = 11;
            this.btnBookStock.Text = "Book Stock";
            this.btnBookStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBookStock.UseVisualStyleBackColor = true;
            this.btnBookStock.Click += new System.EventHandler(this.btnBookStock_Click);
            this.btnBookStock.Leave += new System.EventHandler(this.btnBookStock_Leave);
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.Transparent;
            this.formPanel.Location = new System.Drawing.Point(218, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(682, 461);
            this.formPanel.TabIndex = 11;
            this.formPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formPanel_Paint);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookSellApplication.Properties.Resources.Screenshot_2024_12_02_134147;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Personal";
            this.Text = "Personal";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBookSell;
        private System.Windows.Forms.Button btnAnalytic;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBookStock;
        private System.Windows.Forms.Panel formPanel;
    }
}