namespace LibrarySystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }
        public Book(string title, string author, string isbn, bool isAvailable = false)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = isAvailable;
        }
    }
}