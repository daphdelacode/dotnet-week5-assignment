using System;

class Program
{
    static void Main()
    {
        Library library = new Library();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Library Management System ===");
            Console.WriteLine("1. Add New Book");
            Console.WriteLine("2. Display All Books");
            Console.WriteLine("3. Search Book by Title");
            Console.WriteLine("4. Search by Author");
            Console.WriteLine("5. Borrow Book");
            Console.WriteLine("6. Return Book");
            Console.WriteLine("7. Display Statistics");
            Console.WriteLine("8. Exit");

            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Book book = new Book();

                    Console.Write("Title: ");
                    book.Title = Console.ReadLine();

                    Console.Write("Author: ");
                    book.Author = Console.ReadLine();

                    Console.Write("ISBN: ");
                    book.ISBN = Console.ReadLine();

                    Console.Write("Category: ");
                    book.Category = Console.ReadLine();

                    Console.Write("Price: ");
                    book.Price = decimal.Parse(Console.ReadLine());

                    Console.Write("Copies: ");
                    book.CopiesAvailable = int.Parse(Console.ReadLine());

                    library.AddBook(book);
                    break;

                case "2":
                    library.DisplayAllBooks();
                    break;

                case "3":
                    Console.Write("Enter title: ");
                    library.SearchByTitle(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter author: ");
                    library.SearchByAuthor(Console.ReadLine());
                    break;

                case "5":
                    Console.Write("Enter ISBN: ");
                    library.BorrowBook(Console.ReadLine());
                    break;

                case "6":
                    Console.Write("Enter ISBN: ");
                    library.ReturnBook(Console.ReadLine());
                    break;

                case "7":
                    library.DisplayStatistics();
                    break;

                case "8":
                    running = false;
                    break;
            }
        }
    }
}
