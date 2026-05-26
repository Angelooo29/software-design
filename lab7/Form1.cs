using System.Diagnostics.Eventing.Reader;
using System.Net;
using Microsoft.EntityFrameworkCore;
using lab5;
using static lab5.Form1;

namespace lab7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private const int pageSize = 10;
		private int currentPage = 1;

		public async Task<List<string>> GetBooksByPageAsync(int pageNumber)
		{
			using (var context = new BookstoreContext())
			{
				var books = await context.Books
					.Include(b => b.Author)
					.OrderBy(b => b.BookID)
                    .Skip((pageNumber - 1) * pageSize)
					.Take(pageSize)
					.Select(b => $"{b.Title} by {b.Author.Name}")
					.ToListAsync();
				return books;
            }
		}

		private async void btnNextPage_Click(object sender, EventArgs e)
		{
			currentPage++;
			var books = await GetBooksByPageAsync(currentPage);
			listBoxBooks.DataSource = books;
			lblPageNumber.Text = $"Page {currentPage}";
        }

		private async void btnPreviousPage_Click(object sender, EventArgs e)
		{
			currentPage--;
			if (currentPage < 1)
				currentPage = 1;
			var books = await GetBooksByPageAsync(currentPage);
			listBoxBooks.DataSource = books;
			lblPageNumber.Text = $"Page {currentPage}";
        }

        public async Task SaveBookWithhandlingAsync(string bookTitle, string authorName)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };

                    context.Authors.Add(author);
                    context.Books.Add(book);

                    await context.SaveChangesAsync();

                    MessageBox.Show("Book and Author saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
            }
        }

        private async void btnAddBook_Click(object obj, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookWithhandlingAsync(bookTitle, authorName);
        }


        public async Task ExportBookAsync(string filePath)
		{
			var books = await GetBooksByPageAsync(currentPage);
			using (StreamWriter writer = new StreamWriter(filePath))
			{
				foreach (var book in books)
				{
					await writer.WriteLineAsync(book);
				}
            }
        }

		private async void btnExportBooks_Click(object sender, EventArgs e)
		{
			var saveFileDialog = new SaveFileDialog
			{
				Filter = "Text Files (*.txt)|*.txt",
				Title = "Save Book List"
			};
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = saveFileDialog.FileName;
				await ExportBookAsync(filePath);
				MessageBox.Show("Books exported successfully!");
            }
        }
    }
}
