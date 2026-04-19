namespace Task5_BubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click_2(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4, 8, 6, 9, 7 };

            int[] sorted = BubbleSort(numbers);

            listBoxResults.DataSource = sorted;
        }
        public int[] BubbleSort(int[] numbers)
        {
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Swap numbers[j] and numbers[j + 1]
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;       
        }
        }
    }

