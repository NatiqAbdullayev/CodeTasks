using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;
namespace LibraryConsoleApp.Models;

public class Book
{
    //    Id-Unique ve oz ozune artan Id olacaq
    //Name
    //AuthorName
    //Price
    //ShowInfo()
    //ToString()

    private static int _idCounter;
    public int Id { get; set; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public double Price { get; set; }

    public Book(string name,string authorName,double price)
    {
        _idCounter++;
        Id= _idCounter;
        Name = name;
        AuthorName = authorName;
        Price = price;
    }

    public void ShowInfo() {
        Console.WriteLine($"Id:{Id} Name:{Name} Author Name:{AuthorName} Price:{Price}");
    }

    public override string ToString()
    {
        return $"Id:{Id} Name:{Name} Author Name:{AuthorName} Price:{Price}";
    }

}
