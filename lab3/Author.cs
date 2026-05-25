using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab3.Form1;

namespace lab3
{
    public class Author
    {
        public int AuthorId { get; set; } // The Unique ID (Primary Key)
        public string Name { get; set; }

        // A relationship: One Author can have many Books
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
