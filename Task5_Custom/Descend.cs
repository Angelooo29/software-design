using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Custom
{
    internal class Descend
    {
        public int[] SortDescending(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            return numbers;
        }
    }
}
