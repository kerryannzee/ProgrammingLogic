namespace Lab7;

class Book
{
    private string title;
    private string author;

    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }

    public Book(string newTitle)
    {
        title = newTitle;
        author = "Unknown Author";  
    }

    public Book(string newTitle, string newAuthor)
    {
        title = newTitle;
        author = newAuthor;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine("Book 1 Title: " + book1.GetTitle());  
        Console.WriteLine("Book 1 Author: " + book1.GetAuthor());  

        book1.SetTitle("C# Fundamentals");
        book1.SetAuthor("John Doe");
        Console.WriteLine("Book 1 Updated Title: " + book1.GetTitle());  
        Console.WriteLine("Book 1 Updated Author: " + book1.GetAuthor());  

        Book book2 = new Book("Advanced C#");
        Console.WriteLine("Book 2 Title: " + book2.GetTitle()); 
        Console.WriteLine("Book 2 Author: " + book2.GetAuthor());  

        Book book3 = new Book("LINQ in Action", "Joe Smith");
        Console.WriteLine("Book 3 Title: " + book3.GetTitle());   
        Console.WriteLine("Book 3 Author: " + book3.GetAuthor()); 

        Book book4 = new Book();
        book4.SetTitle("C# Design Patterns");
        book4.SetAuthor("Jane Doe");
        Console.WriteLine("Book 4 Updated Title: " + book4.GetTitle());   
        Console.WriteLine("Book 4 Updated Author: " + book4.GetAuthor()); 
    }
}
