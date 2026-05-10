namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            private string _title = string.Empty;

            public string Title
            {
                get { return _title; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Title cannot be empty.");
                    }
                    _title = value;
                }
            }

            public string? Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            private int _issueNumber;

            public int IssueNumber
            {
                get { return _issueNumber; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Issue number cannot be negative.");
                    }
                    _issueNumber = value;
                }
            }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public double FileSizeMB { get; set; }

            public override string GetInfo()
            {
                return $"{Title} (Ebook, {FileSizeMB}MB)";
            }

        }

        public class Textbook : Book
        {
            private string _subject = string.Empty;

            public string Subject
            {
                get { return _subject; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Subject cannot be empty.");
                    }
                    _subject = value;
                }
            }

            public override string GetInfo()
            {
                return $"{Title} by {Author} [Subject: {Subject}]";
            }
        }

        public class AudioBook : Book
        {
            public double Duration { get; set; }
            public string Narrator { get; set; } = string.Empty;

            public override string GetInfo()
            {
                return $"{Title} by {Author} (Narrated by {Narrator}, {Duration} hrs)";
            }
        }

        private void ProcessBooks(Book[] bookstoreInventory)
        {
            lstBookTypes.Items.Clear();

            foreach (Book item in bookstoreInventory)
            {
                lstBookTypes.Items.Add(item.GetInfo());
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine
            {
                Title = "Tech Weekly",
                Author = "Jane Doe",
                IssueNumber = 45
            };

            MessageBox.Show(myBook.GetInfo());
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Book[] myInventory = new Book[]
            {
                new Book
                {
                    Title = "Lord of the Rings",
                    Author = "J.R.R. Tolkien"
                },

                new Magazine
                {
                    Title = "Vogue",
                    Author = "Anna Wintour",
                    IssueNumber = 45
                },

                new Ebook
                {
                    Title = "GitHub: A Non-Technical Guide",
                    Author = "Brent Beer",
                    FileSizeMB = 5.2
                },

                new Textbook
                {
                    Title = "Introduction to Computer Programming",
                    Author = "Donald I. Cutler",
                    Subject = "Computer Engineering"
                },

                new AudioBook
                {
                    Title = "Rise of the Dragons",
                    Author = "Morgan Rice",
                    Narrator = "Stephen Fry",
                    Duration = 16.2
                }
            };

            ProcessBooks(myInventory);
        }
    }
}