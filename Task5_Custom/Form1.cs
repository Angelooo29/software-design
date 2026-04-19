using System.Globalization;

namespace Task5_Custom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };

            Descend descend = new Descend();

            int[] descended = descend.SortDescending(numbers);

            listBoxResults.DataSource = descended;
        }
    }
}
