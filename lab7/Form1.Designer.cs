namespace lab7
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
            lblPageNumber = new Label();
            btnPreviousPage = new Button();
            btnNextPage = new Button();
            listBoxBooks = new ListBox();
            btnAddBook = new Button();
            btnExportBooks = new Button();
            txtAuthorName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBookTitle = new TextBox();
            SuspendLayout();
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(532, 388);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(56, 20);
            lblPageNumber.TabIndex = 0;
            lblPageNumber.Text = "Page: 1";
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(391, 381);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(110, 35);
            btnPreviousPage.TabIndex = 6;
            btnPreviousPage.Text = "Previous Page";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(618, 381);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(100, 35);
            btnNextPage.TabIndex = 7;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(351, 34);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(419, 324);
            listBoxBooks.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.LightSkyBlue;
            btnAddBook.Location = new Point(41, 236);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(100, 35);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnExportBooks
            // 
            btnExportBooks.BackColor = Color.Plum;
            btnExportBooks.Location = new Point(186, 236);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(114, 35);
            btnExportBooks.TabIndex = 3;
            btnExportBooks.Text = "Export Books";
            btnExportBooks.UseVisualStyleBackColor = false;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(132, 143);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(188, 27);
            txtAuthorName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 146);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 7;
            label1.Text = "Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 94);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 9;
            label2.Text = "Book Title";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(132, 91);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(188, 27);
            txtBookTitle.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(782, 453);
            Controls.Add(label2);
            Controls.Add(txtBookTitle);
            Controls.Add(label1);
            Controls.Add(txtAuthorName);
            Controls.Add(btnExportBooks);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Controls.Add(btnNextPage);
            Controls.Add(btnPreviousPage);
            Controls.Add(lblPageNumber);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageNumber;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private ListBox listBoxBooks;
        private Button btnAddBook;
        private Button btnExportBooks;
        private TextBox txtAuthorName;
        private Label label1;
        private Label label2;
        private TextBox txtBookTitle;
    }
}
