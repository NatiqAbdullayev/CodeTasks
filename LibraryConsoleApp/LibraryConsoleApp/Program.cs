using LibraryConsoleApp.Models;

namespace LibraryConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        bool status = true;

        do
        {
            Console.WriteLine(
                "Menu\r\n1. Add book\r\n2. Get book by id\r\n3. Remove book\r\n4. Get all books\r\n5.Update book \r\n0. Quit\n");
            Console.Write("Enter option:");
            string op = Console.ReadLine();
            int result;

            switch (op)
            {


                case "1":
                    Console.WriteLine("Enter fields");

                    Console.Write("Name:");
                    string? name = Console.ReadLine();
                    Console.Write("Author name:");
                    string? auth = Console.ReadLine();
                    Console.Write("Price:");
                    string? price = Console.ReadLine();


                    if (name is null && auth is not null && Int32.TryParse(price, out result) == false)
                    {
                        Console.WriteLine("Yalnis deyerler daxil edildi");
                        break;
                    }
                    else
                    {
                        Int32.TryParse(price, out result);
                        Book book = new(name, auth, result);
                        Library l1 = new Library();
                        l1.AddBook(book);

                    }
                    break;
                case "2":

                    Console.Write("Enter id:");
                    string? id = Console.ReadLine();
                    bool valid = Int32.TryParse(id, out result);

                    if (valid == false)
                    {
                        Console.WriteLine("reqem daxil edin");
                        break;
                    }
                    else
                    {
                        Library l2 = new Library();
                        var entity = l2.GetBookById(result);
                        Console.WriteLine(entity);
                    }

                    break;
                case "3":
                    Console.WriteLine("Remove book");
                    Console.Write("Enter id:");
                    string? id2 = Console.ReadLine();
                    bool valid2 = Int32.TryParse(id2, out result);

                    if (valid2 == false)
                    {
                        Console.WriteLine("reqem daxil edin");
                        break;
                    }
                    else
                    {
                        Library l2 = new Library();
                        l2.RemoveBook(result);
                    }
                    break;
                case "4":
                    Library l = new Library();
                    l.GetAllBooks();
                    break;


                case "5":
                    Console.WriteLine("Update book");

                    Console.Write("Enter id: ");
                    string? updateId = Console.ReadLine();

                    if (!Int32.TryParse(updateId, out int bookId))
                    {
                        Console.WriteLine("Duzgun id daxil edin");
                        break;
                    }

                    Console.Write("New name: ");
                    string? newName = Console.ReadLine();

                    Console.Write("New author name: ");
                    string? newAuthor = Console.ReadLine();

                    Console.Write("New price: ");
                    string? newPrice = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newAuthor) || !Int32.TryParse(newPrice, out int newParsedPrice))
                    {
                        Console.WriteLine("Yalnis deyerler daxil edildi");
                        break;
                    }

                    Book updatedBook = new Book(newName, newAuthor, newParsedPrice);
                    Library updateLib = new Library();
                    updateLib.Update(bookId, updatedBook);

                    break;

                case "0":
                    status = false;
                    break;

            }


        } while (status);


    }
}
