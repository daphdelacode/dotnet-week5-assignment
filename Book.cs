using System;

public class Book
{
    private decimal _price;
    private int _copiesAvailable;

    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string Category { get; set; }

    // Price validation (must be >= 0)
    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value >= 0)
                _price = value;
            else
                Console.WriteLine("Price cannot be negative.");
        }
    }

    // Copies validation (must be >= 0)
    public int CopiesAvailable
    {
        get { return _copiesAvailable; }
        set
        {
            if (value >= 0)
                _copiesAvailable = value;
        }
    }

    // Computed property
    public bool IsAvailable
    {
        get { return CopiesAvailable > 0; }
    }
}
