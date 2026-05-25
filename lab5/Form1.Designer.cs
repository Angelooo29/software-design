namespace lab5
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
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            txtAddBooks = new Button();
            listBoxBooks = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnUpdateBook = new Button();
            txtBookID = new TextBox();
            label3 = new Label();
            btnShowBooks = new Button();
            btnDeleteBooks = new Button();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(191, 147);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(208, 27);
            txtAuthorName.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(191, 92);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(208, 27);
            txtBookTitle.TabIndex = 1;
            // 
            // txtAddBooks
            // 
            txtAddBooks.BackColor = Color.Cyan;
            txtAddBooks.Location = new Point(115, 204);
            txtAddBooks.Name = "txtAddBooks";
            txtAddBooks.Size = new Size(100, 35);
            txtAddBooks.TabIndex = 3;
            txtAddBooks.Text = "Add";
            txtAddBooks.UseVisualStyleBackColor = false;
            txtAddBooks.Click += btnAddBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(426, 86);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(333, 264);
            listBoxBooks.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 95);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 7;
            label1.Text = "Book Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 147);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 8;
            label2.Text = "Author Name";
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.BackColor = Color.GreenYellow;
            btnUpdateBook.Location = new Point(115, 321);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(100, 35);
            btnUpdateBook.TabIndex = 6;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = false;
            btnUpdateBook.Click += btnUpdateBooks_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(191, 260);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(208, 27);
            txtBookID.TabIndex = 5;
            txtBookID.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 267);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 11;
            label3.Text = "Book ID";
            // 
            // btnShowBooks
            // 
            btnShowBooks.BackColor = Color.Aquamarine;
            btnShowBooks.Location = new Point(250, 204);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(100, 35);
            btnShowBooks.TabIndex = 4;
            btnShowBooks.Text = "Show";
            btnShowBooks.UseVisualStyleBackColor = false;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // btnDeleteBooks
            // 
            btnDeleteBooks.BackColor = Color.Tomato;
            btnDeleteBooks.Location = new Point(250, 321);
            btnDeleteBooks.Name = "btnDeleteBooks";
            btnDeleteBooks.Size = new Size(100, 35);
            btnDeleteBooks.TabIndex = 7;
            btnDeleteBooks.Text = "Delete";
            btnDeleteBooks.UseVisualStyleBackColor = false;
            btnDeleteBooks.Click += btnDeleteBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(782, 453);
            Controls.Add(btnDeleteBooks);
            Controls.Add(btnShowBooks);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(btnUpdateBook);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxBooks);
            Controls.Add(txtAddBooks);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button txtAddBooks;
        private ListBox listBoxBooks;
        private Label label1;
        private Label label2;
        private Button btnUpdateBook;
        private TextBox txtBookID;
        private Label label3;
        private Button btnShowBooks;
        private Button btnDeleteBooks;
    }
}