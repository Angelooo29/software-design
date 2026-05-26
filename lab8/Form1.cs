using Newtonsoft.Json.Linq;

namespace lab8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        //public async Task<string> GetBookInfoFromAPIAsync(string isbn)
        //{
        //    string apiUrl = $"https://www.googleapis.com/books/v1/volumes?q=isbn:{isbn}";
        //    using (HttpClient client = new HttpClient())
        //    {
        //        var response = await client.GetStringAsync(apiUrl);
        //        var jsonResponse = JObject.Parse(response);

        //        if (jsonResponse["items"] != null && jsonResponse["items"].HasValues)
        //        {
        //            var title = jsonResponse["items"][0]["volumeInfo"]["title"]?.ToString() ?? "No Title";

        //            var authorToken = jsonResponse["items"][0]["volumeInfo"]["authors"];
        //            var authors = authorToken != null
        //                ? string.Join(", ", authorToken.Select(a => a.ToString()))
        //                : "Unknown Author";

        //            return $"Title: {title}\nAuthors: {authors}";
        //        }
        //        else
        //        {
        //            return "No book found for this ISBN.";
        //        }
        //    }
        //}

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();

            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Please enter an ISBN first.");
                return;
            }

            txtBookDetails.Text = "Searching Google Books...";

            string result = await GetBookInfoSafeAsync(isbn);
            txtBookDetails.Text = result;
        }

        public async Task<string> GetBookInfoSafeAsync(string isbn)
        {
            string apiUrl = $"https://www.googleapis.com/books/v1/volumes?q=isbn:{isbn}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(10);

                    var response = await client.GetStringAsync(apiUrl);
                    var json = JObject.Parse(response);

                    if (json["items"] == null || !json["items"].Any())
                    {
                        return "Result: No book found with that ISBN.";
                    }

                    var firstBook = json["items"][0]["volumeInfo"];

                    string title = firstBook["title"]?.ToString() ?? "Unknown Title";

                    var authorList = firstBook["authors"];
                    string authors = authorList != null
                        ? string.Join(", ", authorList.Select(a => a.ToString()))
                        : "Unknown Author";

                    return $"Title: {title}\r\nAuthors: {authors}";
                }
            }
            catch (HttpRequestException)
            {
                return "Error! Could not connect to the internet.";
            }
            catch (TaskCanceledException)
            {
                return "Error! The request timed out. Try again.";
            }
            catch (Exception ex)
            {
                return $"Unexpected Error. {ex.Message}";
            }
        }

        public async Task<string> GetBookInfoWithErrorHandlingAsync(string isbn)
		{
			string apiUrl = $"https://www.googleapis.com/book/v1/volumes?q=isbn:{isbn}";
			try
			{
				using (HttpClient client = new HttpClient())
				{
					var response = await client.GetStringAsync(apiUrl);
					var jsonResponse = JObject.Parse(response);

                    var title = jsonResponse["items"]?[0]?["volumeInfo"]?["title"]?.ToString() ?? "No Title Found"; ;
                    var authorList = jsonResponse["items"]?[0]?["volumeInfo"]?["authors"];
                    var authors = authorList != null
                        ? string.Join(", ", authorList.Select(a => a.ToString()))
                        : "Unknown Author";

                    return $"Title: {title}\nAuthors: {authors}";
				}
			}
			catch (HttpRequestException)
			{
				return "Error: Unable to fetch data from API. Please check your connection or try again later.";
			}
			catch (Exception ex)
			{
				return $"Error: {ex.Message}";
			}
		}
	}
}
