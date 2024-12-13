namespace BookSellApplication
{
    partial class BookStock
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.dataBookTable = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStockUpdate = new System.Windows.Forms.Button();
            this.btnStockDelete = new System.Windows.Forms.Button();
            this.btnStockAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txBookName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txAuthor = new System.Windows.Forms.TextBox();
            this.txPageNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbBookType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txQuantity = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBookTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::BookSellApplication.Properties.Resources.Purple_Modern_Futuristic_Technology_Presentation__3_;
            this.panel9.Controls.Add(this.btnSearch);
            this.panel9.Controls.Add(this.txSearch);
            this.panel9.Controls.Add(this.dataBookTable);
            this.panel9.Location = new System.Drawing.Point(26, 39);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(645, 227);
            this.panel9.TabIndex = 26;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.Image = global::BookSellApplication.Properties.Resources.search_7712341;
            this.btnSearch.Location = new System.Drawing.Point(593, 17);
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
            this.txSearch.Location = new System.Drawing.Point(304, 17);
            this.txSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txSearch.Multiline = true;
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(285, 30);
            this.txSearch.TabIndex = 21;
            // 
            // dataBookTable
            // 
            this.dataBookTable.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataBookTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBookTable.Location = new System.Drawing.Point(11, 62);
            this.dataBookTable.Name = "dataBookTable";
            this.dataBookTable.RowHeadersWidth = 51;
            this.dataBookTable.RowTemplate.Height = 24;
            this.dataBookTable.Size = new System.Drawing.Size(618, 150);
            this.dataBookTable.TabIndex = 20;
            this.dataBookTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBookTable_CellContentClick);
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
            this.lblTitle.Size = new System.Drawing.Size(193, 36);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Book Stocks";
            // 
            // btnStockUpdate
            // 
            this.btnStockUpdate.FlatAppearance.BorderSize = 0;
            this.btnStockUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockUpdate.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockUpdate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStockUpdate.Image = global::BookSellApplication.Properties.Resources.book_8568665;
            this.btnStockUpdate.Location = new System.Drawing.Point(522, 337);
            this.btnStockUpdate.Name = "btnStockUpdate";
            this.btnStockUpdate.Size = new System.Drawing.Size(156, 38);
            this.btnStockUpdate.TabIndex = 30;
            this.btnStockUpdate.Text = "Stock Update";
            this.btnStockUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockUpdate.UseVisualStyleBackColor = true;
            this.btnStockUpdate.Click += new System.EventHandler(this.btnStockUpdate_Click);
            // 
            // btnStockDelete
            // 
            this.btnStockDelete.FlatAppearance.BorderSize = 0;
            this.btnStockDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockDelete.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStockDelete.Image = global::BookSellApplication.Properties.Resources.book_4797697;
            this.btnStockDelete.Location = new System.Drawing.Point(522, 385);
            this.btnStockDelete.Name = "btnStockDelete";
            this.btnStockDelete.Size = new System.Drawing.Size(156, 38);
            this.btnStockDelete.TabIndex = 29;
            this.btnStockDelete.Text = "Stock Delete";
            this.btnStockDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockDelete.UseVisualStyleBackColor = true;
            this.btnStockDelete.Click += new System.EventHandler(this.btnStockDelete_Click);
            // 
            // btnStockAdd
            // 
            this.btnStockAdd.FlatAppearance.BorderSize = 0;
            this.btnStockAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockAdd.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockAdd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStockAdd.Image = global::BookSellApplication.Properties.Resources.book_11065794;
            this.btnStockAdd.Location = new System.Drawing.Point(522, 288);
            this.btnStockAdd.Name = "btnStockAdd";
            this.btnStockAdd.Size = new System.Drawing.Size(156, 38);
            this.btnStockAdd.TabIndex = 28;
            this.btnStockAdd.Text = "Stock Add";
            this.btnStockAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockAdd.UseVisualStyleBackColor = true;
            this.btnStockAdd.Click += new System.EventHandler(this.btnStockAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(13, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Page Number";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(136, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 1);
            this.panel3.TabIndex = 8;
            // 
            // txBookName
            // 
            this.txBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBookName.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBookName.ForeColor = System.Drawing.Color.Silver;
            this.txBookName.Location = new System.Drawing.Point(136, 20);
            this.txBookName.Name = "txBookName";
            this.txBookName.Size = new System.Drawing.Size(190, 20);
            this.txBookName.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(136, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 1);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(137, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(47, 1);
            this.panel4.TabIndex = 13;
            // 
            // txAuthor
            // 
            this.txAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txAuthor.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAuthor.ForeColor = System.Drawing.Color.Silver;
            this.txAuthor.Location = new System.Drawing.Point(136, 66);
            this.txAuthor.Name = "txAuthor";
            this.txAuthor.Size = new System.Drawing.Size(190, 20);
            this.txAuthor.TabIndex = 10;
            // 
            // txPageNumber
            // 
            this.txPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPageNumber.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPageNumber.ForeColor = System.Drawing.Color.Silver;
            this.txPageNumber.Location = new System.Drawing.Point(137, 108);
            this.txPageNumber.Name = "txPageNumber";
            this.txPageNumber.Size = new System.Drawing.Size(47, 20);
            this.txPageNumber.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(203, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Price";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(263, 131);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(47, 1);
            this.panel6.TabIndex = 19;
            // 
            // txPrice
            // 
            this.txPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txPrice.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrice.ForeColor = System.Drawing.Color.Silver;
            this.txPrice.Location = new System.Drawing.Point(263, 109);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(47, 20);
            this.txPrice.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(346, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Quantity";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BookSellApplication.Properties.Resources.Purple_Modern_Futuristic_Technology_Presentation__1_;
            this.panel1.Controls.Add(this.cbBookType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txQuantity);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txPrice);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.txPageNumber);
            this.panel1.Controls.Add(this.txAuthor);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txBookName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(25, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 163);
            this.panel1.TabIndex = 27;
            // 
            // cbBookType
            // 
            this.cbBookType.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.cbBookType.ForeColor = System.Drawing.Color.Silver;
            this.cbBookType.FormattingEnabled = true;
            this.cbBookType.Items.AddRange(new object[] {
            "Fiction",
            "Non-Fiction",
            "Science",
            "Fantasy",
            "Biography",
            "History",
            "Mystery",
            "Romance",
            "Horror",
            "Self-Help"});
            this.cbBookType.Location = new System.Drawing.Point(356, 55);
            this.cbBookType.Name = "cbBookType";
            this.cbBookType.Size = new System.Drawing.Size(121, 28);
            this.cbBookType.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(357, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Book Type";
            // 
            // txQuantity
            // 
            this.txQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txQuantity.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQuantity.ForeColor = System.Drawing.Color.Silver;
            this.txQuantity.Location = new System.Drawing.Point(437, 108);
            this.txQuantity.Name = "txQuantity";
            this.txQuantity.Size = new System.Drawing.Size(47, 20);
            this.txQuantity.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(437, 131);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(47, 1);
            this.panel5.TabIndex = 22;
            // 
            // BookStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookSellApplication.Properties.Resources.Screenshot_2024_12_02_134147;
            this.ClientSize = new System.Drawing.Size(683, 447);
            this.Controls.Add(this.btnStockUpdate);
            this.Controls.Add(this.btnStockDelete);
            this.Controls.Add(this.btnStockAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookStock";
            this.Text = "BookStock";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBookTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.DataGridView dataBookTable;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStockUpdate;
        private System.Windows.Forms.Button btnStockDelete;
        private System.Windows.Forms.Button btnStockAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txBookName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txAuthor;
        private System.Windows.Forms.TextBox txPageNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txQuantity;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbBookType;
        private System.Windows.Forms.Label label1;
    }
}