using LibrarySystem;

class Program
{
    static void Main(string[] args)
    {
        var library = new Library();

        var book1 = new Book("My Uncle Napoleon", "Iraj Pezeshkzad", "12345");
        var book2 = new Book("The Blind Owl", "Sadegh Hedayat", "67890");
        var book3 = new Book("Savushun", "Simin Daneshvar", "11223");
        var book4 = new Book("Kelidar", "Mahmoud Dowlatabadi", "33445");

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);

        library.BorrowBook("My Uncle Napoleon");
        library.BorrowBook("My Uncle Napoleon");

        library.ReturnBook("My Uncle Napoleon");
        library.ReturnBook("The Blind Owl");
    }
}