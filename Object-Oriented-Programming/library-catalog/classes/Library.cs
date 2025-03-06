using System.Security.Cryptography.X509Certificates;

public class Library {
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Book> Books { get; private set; }
    public List<MediaItem> MediaItems { get; private set; }

    public Library(string name, string address) {
        Name = name;
        Address = address;
        Books = new List<Book>();
        MediaItems = new List<MediaItem>();
    }

    public void AddBook(Book book) {
       Books.Add(book);
       Console.WriteLine($"Added book: {book.Title}");
    }

    public void RemoveBook(Book book) {
         if (Books.Remove(book))
        {
            Console.WriteLine($"Removed book: {book.Title}");
        }
        else
        {
            Console.WriteLine("Book not found in the library.");
        }
    }

    public void AddMediaItem(MediaItem mediaItem) {
        MediaItems.Add(mediaItem);
       Console.WriteLine($"Added media Item: {mediaItem.Title}");
    }

    public void RemoveMediaItem(MediaItem mediaItem) {
         if (MediaItems.Remove(mediaItem))
        {
            Console.WriteLine($"Removed media item: {mediaItem.Title}");
        }
        else
        {
            Console.WriteLine("Media item not found in the library.");
        }
    }

    public void PrintCatalog() {
         Console.WriteLine($"Library Catalog for {Name}, {Address}");
        Console.WriteLine("Books:");
        foreach (var book in Books){
            Console.WriteLine($"- {book.Title} by {book.Author} (ISBN: {book.ISBN}, Year: {book.PublicationYear})");
        }
        Console.WriteLine("Media Items:");
        foreach (var item in MediaItems){
            Console.WriteLine($"- {item.Title} ({item.MediaType}, Duration: {item.Duration} min)");
        }
    }
}