namespace Task3_Power
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Power(int x, int n)
        {
            if (n == 0)
                return 1;
            else
                return x * Power(x, n - 1);
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtBase.Text);
            int n = int.Parse(txtExponent.Text);

            int result = Power(x, n);

            lblResult.Text = "Result = " + result;
        }
    }
}
