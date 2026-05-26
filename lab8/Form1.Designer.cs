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
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 51);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 11;
            label3.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(179, 48);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(227, 27);
            txtISBN.TabIndex = 0;
            // 
            // btnFetchBook
            // 
            btnFetchBook.BackColor = Color.LightSteelBlue;
            btnFetchBook.Location = new Point(454, 41);
            btnFetchBook.Name = "btnFetchBook";
            btnFetchBook.Size = new Size(143, 40);
            btnFetchBook.TabIndex = 1;
            btnFetchBook.Text = "Fetch Books";
            btnFetchBook.UseVisualStyleBackColor = false;
            btnFetchBook.Click += btnFetchBooks_Click;
            // 
            // txtBookDetails
            // 
            txtBookDetails.Location = new Point(159, 104);
            txtBookDetails.Multiline = true;
            txtBookDetails.Name = "txtBookDetails";
            txtBookDetails.Size = new Size(452, 318);
            txtBookDetails.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(782, 453);
            Controls.Add(txtBookDetails);
            Controls.Add(btnFetchBook);
            Controls.Add(label3);
            Controls.Add(txtISBN);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txtISBN;
        private Button btnFetchBook;
        private TextBox txtBookDetails;
    }
}

