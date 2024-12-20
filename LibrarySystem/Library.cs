namespace LibrarySystem
{
    public class Library
    {
        private readonly List<Book> _books = [];

        public void AddBook(Book book)
        {
            _books.Add(book);
            Console.WriteLine($"The book '{book.Title}' has been added to the library.");
        }

        public void BorrowBook(string title)
        {
            var book = _books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book is null)
            {
                Console.WriteLine($"The book '{title}' does not exist in the library.");
                return;
            }

            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                Console.WriteLine($"You have successfully borrowed '{title}'.");
            }
            else
            {
                Console.WriteLine($"The book '{title}' is currently unavailable.");
            }
        }

        public void ReturnBook(string title)
        {
            var book = _books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book is null)
            {
                Console.WriteLine($"The book '{title}' does not exist in the library.");
                return;
            }

            if (!book.IsAvailable)
            {
                book.IsAvailable = true;
                Console.WriteLine($"Thank you for returning '{title}'.");
            }
            else
            {
                Console.WriteLine($"The book '{title}' was already in the library.");
            }
        }
    }
}
