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
            btnShowInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowInfo.Location = new Point(70, 158);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(127, 52);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "Show Info";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // lstBookTypes
            // 
            lstBookTypes.Anchor = AnchorStyles.None;
            lstBookTypes.FormattingEnabled = true;
            lstBookTypes.ItemHeight = 15;
            lstBookTypes.Location = new Point(266, 51);
            lstBookTypes.Name = "lstBookTypes";
            lstBookTypes.Size = new Size(477, 349);
            lstBookTypes.TabIndex = 1;
            // 
            // btnShowAll
            // 
            btnShowAll.Anchor = AnchorStyles.None;
            btnShowAll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAll.Location = new Point(70, 240);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(127, 52);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowAll);
            Controls.Add(lstBookTypes);
            Controls.Add(btnShowInfo);
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