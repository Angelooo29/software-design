namespace Task3_Power
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
            label1 = new Label();
            txtBase = new TextBox();
            label2 = new Label();
            txtExponent = new TextBox();
            btnCompute = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 146);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter base (x) =";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(395, 146);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(125, 27);
            txtBase.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 206);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter exponent (n) =";
            // 
            // txtExponent
            // 
            txtExponent.Location = new Point(395, 203);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(125, 27);
            txtExponent.TabIndex = 3;
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(267, 260);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(101, 39);
            btnCompute.TabIndex = 4;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(374, 269);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(67, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result = ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCompute);
            Controls.Add(txtExponent);
            Controls.Add(label2);
            Controls.Add(txtBase);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recursive Power Calculation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBase;
        private Label label2;
        private TextBox txtExponent;
        private Button btnCompute;
        private Label lblResult;
    }
}
