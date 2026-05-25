using lab5;
using Microsoft.EntityFrameworkCore;
using static lab5.Form1;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async Task<List<string>> GetBooksAsync()
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(b => b.Author)
                                               .Select(b => $"{b.Title} by {b.Author.Name}")
                                               .ToListAsync();
                return books;
            }
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;

            var progress = new Progress<int>(percent =>
            {
                progressBar.Value = percent;
            });

            var books = await GetBooksWithProgressAsync(progress);
            listBoxBooks.DataSource = books;
        }

        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);

                await context.SaveChangesAsync();
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookAsync(bookTitle, authorName);

            MessageBox.Show("Book and Author saved successfully!");
        }

        public async Task UpdateBookAsync(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteBookAsync(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FirstOrDefaultAsync(b => b.BookID == bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task<List<string>> SearchBooksAsync(string title)
        {
            using (var context = new BookstoreContext())
            {
                return await context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Title.Contains(title))
                    .Select(b => $"{b.Title} by {b.Author.Name} (ID: {b.BookID})")
                    .ToListAsync();
            }
        }

        public async Task<List<string>> GetBooksWithProgressAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                var rawBooks = await context.Books.Include(b => b.Author).ToListAsync();
                var results = new List<string>();

                for (int i = 0; i < rawBooks.Count; i++)
                {
                    results.Add($"{rawBooks[i].Title} by {rawBooks[i].Author.Name}");

                    int percentage = (int)(((double)(i + 1) / rawBooks.Count) * 100);
                    progress.Report(percentage);

                    await Task.Delay(100);
                }
                return results;
            }
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                await UpdateBookAsync(bookId, txtBookTitle.Text, txtAuthorName.Text);
                MessageBox.Show("Updated Successfully!");
            }
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                await DeleteBookAsync(bookId);
                MessageBox.Show("Deleted Successfully!");
            }
        }

        private async void btnSearchBooks_Click(object sender, EventArgs e)
        {
            var results = await SearchBooksAsync(txtSearchTitle.Text);
            listBoxBooks.DataSource = results;
        }
    }
}