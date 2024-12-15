namespace BookSellApplication
{
    partial class BookSell
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
            this.btnSell = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.dataBookTable = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txQuantity = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBookTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSell
            // 
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSell.Image = global::BookSellApplication.Properties.Resources.book_12096241__1_;
            this.btnSell.Location = new System.Drawing.Point(415, 345);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(159, 60);
            this.btnSell.TabIndex = 34;
            this.btnSell.Text = "Book Sell";
            this.btnSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::BookSellApplication.Properties.Resources.Purple_Modern_Futuristic_Technology_Presentation__3_;
            this.panel9.Controls.Add(this.txQuantity);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.btnSearch);
            this.panel9.Controls.Add(this.txSearch);
            this.panel9.Controls.Add(this.dataBookTable);
            this.panel9.Location = new System.Drawing.Point(72, 64);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(502, 275);
            this.panel9.TabIndex = 32;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.Image = global::BookSellApplication.Properties.Resources.search_7712341;
            this.btnSearch.Location = new System.Drawing.Point(426, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 30);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txSearch
            // 
            this.txSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txSearch.BackColor = System.Drawing.Color.LightBlue;
            this.txSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txSearch.Location = new System.Drawing.Point(99, 23);
            this.txSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txSearch.Multiline = true;
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(321, 30);
            this.txSearch.TabIndex = 21;
            // 
            // dataBookTable
            // 
            this.dataBookTable.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataBookTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBookTable.Location = new System.Drawing.Point(27, 68);
            this.dataBookTable.Name = "dataBookTable";
            this.dataBookTable.RowHeadersWidth = 51;
            this.dataBookTable.RowTemplate.Height = 24;
            this.dataBookTable.Size = new System.Drawing.Size(430, 150);
            this.dataBookTable.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 36);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Sell Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BookSellApplication.Properties.Resources.rb_21493306031;
            this.pictureBox1.Location = new System.Drawing.Point(-15, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // txQuantity
            // 
            this.txQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txQuantity.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQuantity.ForeColor = System.Drawing.Color.Black;
            this.txQuantity.Location = new System.Drawing.Point(433, 235);
            this.txQuantity.Name = "txQuantity";
            this.txQuantity.Size = new System.Drawing.Size(47, 20);
            this.txQuantity.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(433, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(47, 1);
            this.panel5.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(342, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Quantity";
            // 
            // BookSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookSellApplication.Properties.Resources.Screenshot_2024_12_02_134147;
            this.ClientSize = new System.Drawing.Size(683, 447);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookSell";
            this.Text = "BookSell";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBookTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.DataGridView dataBookTable;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txQuantity;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
    }
}