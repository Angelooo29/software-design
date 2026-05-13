using Microsoft.EntityFrameworkCore;

namespace lab5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public class Author
		{
			public int AuthorID { get; set; }
			public string Name { get; set; }
			public virtual ICollection<Book> Books { get; set; }

        }

		public class Book
		{
			public int BookID { get; set; }
			public string Title { get; set; }
			public int AuthorID { get; set; }
			public virtual Author Author { get; set; }
        }

		public void AddAuthorWithBook(string authorName, string bookTitle)
		{
			using (var context = new BookstoreContext())
			{
				var author = new Author { Name = authorName };
				var book = new Book { Title = bookTitle, Author = author };

				context.Authors.Add(author);
				context.Books.Add(book);
				context.SaveChanges();
            }
		}

		public List<string> GetBooksWithAuthors()
		{
			using (var context = new BookstoreContext())
			{
				var booksWithAuthors = context.Books
					.Include(b => b.Author)
					.Select(b => $"{b.Title} by {b.Author.Name}")
					.ToList();

				return booksWithAuthors;
			}
		}

		private void btnShowBooks_Click(object sender, EventArgs e)
		{
			var books = GetBooksWithAuthors();
			listBoxBooks.DataSource = books;
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text;
            string bookTitle = txtBookTitle.Text;

            if (!string.IsNullOrWhiteSpace(authorName) && !string.IsNullOrWhiteSpace(bookTitle))
            {
                AddAuthorWithBook(authorName, bookTitle);

                MessageBox.Show("Book and Author(s) Saved.");

                txtAuthorName.Clear();
                txtBookTitle.Clear();
            }
            else
            {
                MessageBox.Show("Please enter the Book title and the Author(s).");
            }
        }

        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
		{
			using (var context = new BookstoreContext())
			{
				var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);

				if (book != null)
				{
					book.Title = newTitle;
					book.Author.Name = newAuthorName;
					context.SaveChanges();
                }
            }
		}

        private void btnUpdateBooks_Click(object sender, EventArgs e)
		{
			int bookId = int.Parse(txtBookID.Text);
			UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
			MessageBox.Show("Book and Author(s) updated successfully.");
		}

        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var bookToDelete = context.Books.FirstOrDefault(b => b.BookID == bookId);

                if (bookToDelete != null)
                {
                    context.Books.Remove(bookToDelete);
                    context.SaveChanges();
                }
				
            }
        }

        private void btnDeleteBooks_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                DeleteBook(bookId);
                MessageBox.Show("Book deleted successfully!");

                btnShowBooks_Click(sender, e);

                txtBookID.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID to delete.");
            }
        }
    }
}
