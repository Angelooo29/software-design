namespace lab3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name "disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            btnShowInfo = new Button();
            lstBookTypes = new ListBox();
            btnShowAll = new Button();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.Anchor = AnchorStyles.None;
            btnShowInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowInfo.Location = new Point(257, 405);
            btnShowInfo.Margin = new Padding(3, 4, 3, 4);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(100, 35);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "Show Info";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // lstBookTypes
            // 
            lstBookTypes.Anchor = AnchorStyles.None;
            lstBookTypes.FormattingEnabled = true;
            lstBookTypes.Location = new Point(62, 23);
            lstBookTypes.Margin = new Padding(3, 4, 3, 4);
            lstBookTypes.Name = "lstBookTypes";
            lstBookTypes.Size = new Size(654, 364);
            lstBookTypes.TabIndex = 1;
            // 
            // btnShowAll
            // 
            btnShowAll.Anchor = AnchorStyles.None;
            btnShowAll.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowAll.Location = new Point(406, 405);
            btnShowAll.Margin = new Padding(3, 4, 3, 4);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(100, 35);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(782, 453);
            Controls.Add(btnShowAll);
            Controls.Add(lstBookTypes);
            Controls.Add(btnShowInfo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookstore System";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowInfo;
        private ListBox lstBookTypes;
        private Button btnShowAll;
    }
}