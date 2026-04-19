namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        private void btnSort_Click_1(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortednumbers = ProceduralSort(numbers);
            listBoxResults.DataSource = sortednumbers;
        }
    }
}
