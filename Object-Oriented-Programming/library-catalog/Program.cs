public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library("City Library", "123 Main St");

        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", 1925);
        Book book2 = new Book("1984", "George Orwell", "9780451524935", 1949);

        library.AddBook(book1);
        library.AddBook(book2);

        MediaItem mediaItem1 = new MediaItem("Inception", "DVD", 148);
        MediaItem mediaItem2 = new MediaItem("The Dark Side of the Moon", "CD", 42);

        library.AddMediaItem(mediaItem1);
        library.AddMediaItem(mediaItem2);

        library.PrintCatalog();

        library.RemoveBook(book1);
        library.PrintCatalog();

        library.RemoveMediaItem(mediaItem1);
        library.PrintCatalog();
    }
}