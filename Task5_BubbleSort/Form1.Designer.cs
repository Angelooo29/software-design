namespace Task5_BubbleSort
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
            btnSort = new Button();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Location = new Point(89, 171);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(116, 60);
            btnSort.TabIndex = 0;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click_2;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(287, 136);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(244, 184);
            listBoxResults.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResults);
            Controls.Add(btnSort);
            Name = "Form1";
            Text = "Bubble Sort";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSort;
        private ListBox listBoxResults;
    }
}
