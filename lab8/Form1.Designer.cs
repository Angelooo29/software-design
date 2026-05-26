using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace lab8
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
            label3 = new Label();
            txtISBN = new TextBox();
            btnFetchBook = new Button();
            txtBookDetails = new TextBox();
            groupBox1 = new GroupBox();
            lstAuthorBooks = new ListBox();
            btnSearchAuthor = new Button();
            txtAuthorSearch = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 45);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 11;
            label3.Text = "ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(6, 78);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(227, 27);
            txtISBN.TabIndex = 0;
            // 
            // btnFetchBook
            // 
            btnFetchBook.BackColor = Color.LightSteelBlue;
            btnFetchBook.Location = new Point(239, 71);
            btnFetchBook.Name = "btnFetchBook";
            btnFetchBook.Size = new Size(143, 40);
            btnFetchBook.TabIndex = 1;
            btnFetchBook.Text = "Fetch Books";
            btnFetchBook.UseVisualStyleBackColor = false;
            btnFetchBook.Click += btnFetchBooks_Click;
            // 
            // txtBookDetails
            // 
            txtBookDetails.Location = new Point(6, 129);
            txtBookDetails.Multiline = true;
            txtBookDetails.Name = "txtBookDetails";
            txtBookDetails.Size = new Size(376, 324);
            txtBookDetails.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstAuthorBooks);
            groupBox1.Controls.Add(btnSearchAuthor);
            groupBox1.Controls.Add(txtAuthorSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 453);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search by Author";
            // 
            // lstAuthorBooks
            // 
            lstAuthorBooks.FormattingEnabled = true;
            lstAuthorBooks.Location = new Point(6, 129);
            lstAuthorBooks.Name = "lstAuthorBooks";
            lstAuthorBooks.Size = new Size(382, 324);
            lstAuthorBooks.TabIndex = 16;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.BackColor = Color.LightSteelBlue;
            btnSearchAuthor.Location = new Point(225, 71);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(143, 40);
            btnSearchAuthor.TabIndex = 15;
            btnSearchAuthor.Text = "Search Author";
            btnSearchAuthor.UseVisualStyleBackColor = false;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
            // 
            // txtAuthorSearch
            // 
            txtAuthorSearch.Location = new Point(12, 78);
            txtAuthorSearch.Name = "txtAuthorSearch";
            txtAuthorSearch.Size = new Size(207, 27);
            txtAuthorSearch.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 15;
            label1.Text = "Author Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtBookDetails);
            groupBox2.Controls.Add(txtISBN);
            groupBox2.Controls.Add(btnFetchBook);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(400, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(382, 453);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search by ISBN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(782, 453);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private TextBox txtISBN;
        private Button btnFetchBook;
        private TextBox txtBookDetails;
        private GroupBox groupBox1;
        private Button btnSearchAuthor;
        private TextBox txtAuthorSearch;
        private Label label1;
        private ListBox lstAuthorBooks;
        private GroupBox groupBox2;
    }
}

