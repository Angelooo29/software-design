namespace lab6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            txtAuthorName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            label3 = new Label();
            txtBookID = new TextBox();
            btnSearchBooks = new Button();
            txtSearchTitle = new TextBox();
            progressBar = new ProgressBar();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Anchor = AnchorStyles.None;
            btnFetchBooks.BackColor = Color.PaleGreen;
            btnFetchBooks.Location = new Point(198, 168);
            btnFetchBooks.Margin = new Padding(3, 4, 3, 4);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(100, 35);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch Book";
            btnFetchBooks.UseVisualStyleBackColor = false;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.Anchor = AnchorStyles.None;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(374, 61);
            listBoxBooks.Margin = new Padding(3, 4, 3, 4);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(354, 344);
            listBoxBooks.TabIndex = 1;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Anchor = AnchorStyles.None;
            txtAuthorName.Location = new Point(149, 94);
            txtAuthorName.Margin = new Padding(3, 4, 3, 4);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(195, 27);
            txtAuthorName.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(26, 94);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "Author Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(48, 46);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 5;
            label2.Text = "Book Title";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Anchor = AnchorStyles.None;
            txtBookTitle.Location = new Point(149, 46);
            txtBookTitle.Margin = new Padding(3, 4, 3, 4);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(195, 27);
            txtBookTitle.TabIndex = 4;
            // 
            // btnAddBook
            // 
            btnAddBook.Anchor = AnchorStyles.None;
            btnAddBook.BackColor = Color.PaleTurquoise;
            btnAddBook.Location = new Point(68, 168);
            btnAddBook.Margin = new Padding(3, 4, 3, 4);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(100, 35);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(62, 268);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 8;
            label3.Text = "Book ID";
            // 
            // txtBookID
            // 
            txtBookID.Anchor = AnchorStyles.None;
            txtBookID.Location = new Point(149, 265);
            txtBookID.Margin = new Padding(3, 4, 3, 4);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(195, 27);
            txtBookID.TabIndex = 7;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Anchor = AnchorStyles.None;
            btnSearchBooks.BackColor = Color.LightGray;
            btnSearchBooks.Location = new Point(628, 13);
            btnSearchBooks.Margin = new Padding(3, 4, 3, 4);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(100, 35);
            btnSearchBooks.TabIndex = 9;
            btnSearchBooks.Text = "Search";
            btnSearchBooks.UseVisualStyleBackColor = false;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Anchor = AnchorStyles.None;
            txtSearchTitle.Location = new Point(374, 18);
            txtSearchTitle.Margin = new Padding(3, 4, 3, 4);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(248, 27);
            txtSearchTitle.TabIndex = 10;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.None;
            progressBar.Location = new Point(405, 413);
            progressBar.Margin = new Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(288, 20);
            progressBar.TabIndex = 11;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Anchor = AnchorStyles.None;
            btnUpdateBook.BackColor = Color.Yellow;
            btnUpdateBook.Location = new Point(198, 331);
            btnUpdateBook.Margin = new Padding(3, 4, 3, 4);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(108, 35);
            btnUpdateBook.TabIndex = 12;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = false;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Anchor = AnchorStyles.None;
            btnDeleteBook.BackColor = Color.Plum;
            btnDeleteBook.Location = new Point(68, 331);
            btnDeleteBook.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(100, 35);
            btnDeleteBook.TabIndex = 13;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(782, 453);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(progressBar);
            Controls.Add(txtSearchTitle);
            Controls.Add(btnSearchBooks);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(btnAddBook);
            Controls.Add(label2);
            Controls.Add(txtBookTitle);
            Controls.Add(label1);
            Controls.Add(txtAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private TextBox txtAuthorName;
        private Label label1;
        private Label label2;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private Label label3;
        private TextBox txtBookID;
        private Button btnSearchBooks;
        private TextBox txtSearchTitle;
        private ProgressBar progressBar;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
    }
}