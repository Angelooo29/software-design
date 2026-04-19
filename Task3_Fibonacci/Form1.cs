namespace Task3_Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNumber.Text);

            int result = Fibonacci(n);

            lblResult.Text = "Result = " + result;
        }

        // Recursive Fibonacci Function
        public int Fibonacci(int n)
        {
            if (n == 0) return 0;       // Base case: F(0) = 0
            if (n == 1) return 1;       // Base case: F(1) = 1
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
