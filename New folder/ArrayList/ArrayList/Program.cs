using System.Collections;
class Library
{
     static void Main()
    {
        //Creating an ArrayList to store book titles
        ArrayList book = new ArrayList();

        //Add book to library
        book.Add("The Greatest Gatsby");
        book.Add("To Kill a Mockingbird");
        book.Add("1984");
        book.Add("Moby Dick");
        book.Add("Pride and Prejudice");
        book.Add(100);

        Console.WriteLine("Books in the Library :\n");
        DisplayBooks(book);
    }
    static void DisplayBooks(ArrayList book)
    {
        foreach (var bookItem in book)
        {
            Console.WriteLine(bookItem);
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}