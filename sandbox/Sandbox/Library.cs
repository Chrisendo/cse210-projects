public class Library
{
    private List<Book> _books; // ... _books = new List<Book>();

    public Library()
    {
        _books = new List<Book>();
    }


    public void DisplayCatalog()
    {
        Console.WriteLine("The Catalog is: ");

        foreach (Book b in _books)
        {
            b.Display();
        }
    }

    public void AddBook(Book theBook)
    {
        _books.Add(theBook);
    }
}