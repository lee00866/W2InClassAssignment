using System.Globalization;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }

    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }

    public string DisplayInfo()
    {
        return "Title: " + Title + "\nAuthor: " + Author + "\nYear Published: " + YearPublished; 
    }
}