namespace Task4
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
            button1 = new Button();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(159, 213);
            button1.Name = "button1";
            button1.Size = new Size(126, 50);
            button1.TabIndex = 0;
            button1.Text = "Sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSort_Click_1;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(342, 146);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(103, 204);
            listBoxResults.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResults);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBoxResults;
    }
}
