namespace Lab7;

using System;

class Book
{
    private string title;
    private string author;

    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }

    public Book(string title)
    {
        this.title = title;
        author = "Unknown Author";
    } 

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public string BookTitle()
    {
        return title;
    }

    public void GiveTitle(string newTitle)
    {
        title = newTitle;
    }

    public string AuthorName()
    {
        return author;
    }

    public void GiveAuthor(string newAuthor)
    {
        author = newAuthor;
    }

}

class Program

{

    static void Main()
    {
        Book book1 = new Book();
        Console.WriteLine(book1.BookTitle());

        book1.GiveTitle("C# Fundamentals");
        Console.WriteLine(book1.BookTitle());

        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.BookTitle());

        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine("Title: " + book3.BookTitle());
        Console.WriteLine("Author " + book3.AuthorName());

        Book book4 = new Book();
        book4.GiveTitle("Mastering C#");
        book4.GiveAuthor("Jane Smith");
        Console.WriteLine("Title: " + book4.BookTitle());
        Console.WriteLine("Author: " + book4.AuthorName());


    }
}
