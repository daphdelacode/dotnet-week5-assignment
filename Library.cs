using System;
using System.Collections.Generic;

public class Library
{
    public string LibraryName { get; set; }

    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully!");
    }

    public void DisplayAllBooks()
    {
        Console.WriteLine("\n=== All Books ===");

        foreach (var book in books)
        {
            Console.WriteLine($"{book.ISBN} | {book.Title} | {book.Author} | {book.Price:C} | {book.CopiesAvailable} | {(book.IsAvailable ? "Yes" : "No")}");
        }
    }

    public void SearchByTitle(string title)
    {
        foreach (var book in books)
        {
            if (book.Title.ToLower().Contains(title.ToLower()))
            {
                Console.WriteLine($"{book.Title} by {book.Author}");
            }
        }
    }

    public void SearchByAuthor(string author)
    {
        foreach (var book in books)
        {
            if (book.Author.ToLower().Contains(author.ToLower()))
            {
                Console.WriteLine($"{book.Title} - {book.Author}");
            }
        }
    }

    public void BorrowBook(string isbn)
    {
        foreach (var book in books)
        {
            if (book.ISBN == isbn && book.CopiesAvailable > 0)
            {
                book.CopiesAvailable--;
                Console.WriteLine("Book borrowed.");
                return;
            }
        }

        Console.WriteLine("Book not available.");
    }

    public void ReturnBook(string isbn)
    {
        foreach (var book in books)
        {
            if (book.ISBN == isbn)
            {
                book.CopiesAvailable++;
                Console.WriteLine("Book returned.");
                return;
            }
        }
    }

    public void DisplayStatistics()
    {
        Console.WriteLine($"Total Books: {books.Count}");

        int totalCopies = 0;

        foreach (var book in books)
        {
            totalCopies += book.CopiesAvailable;
        }

        Console.WriteLine($"Total Copies Available: {totalCopies}");
    }
}
