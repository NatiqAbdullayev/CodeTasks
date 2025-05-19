using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace LibraryConsoleApp.Models;

public class Library
{

    private static int _idCounter;
    public string Name { get; set; }

    private static Book[] Books = [];

    public void AddBook(Book book)
    {
        Array.Resize(ref Books, Books.Length+1);
        Books[Books.Length - 1] = book;

    }

    public Book? GetBookById(int id)
    {
        foreach (var book in Books)
        {
            if (book.Id == id)
            {
                return book;
            }

        }
        return null;
    }


    public void RemoveBook(int id)
    {
        Book[] newArray = new Book[Books.Length - 1];
        int i = 0;
        foreach (var book in Books)
        {
            if (book.Id == id)
            {
                continue;
            }

            newArray[i] = book;
            i++;
        }

        Books = newArray;
    }

    public Book? GetBookByName(string name)
    {

        foreach (var book in Books)
        {

            if (book.Name.Equals(name))
            {
                return book;
            }

        }
        return null;
    }

    public void GetAllBooks()
    {
        foreach (var book in Books)
        {
            Console.WriteLine($"{book}\n");
        }

    }

    public void Update(int id, Book newBook)
    {
        Book[] newArray = new Book[Books.Length];
        int i = 0;

        foreach (var book in Books)
        {
            if (book.Id == id)
            {
                newArray[i] = newBook;
            }
            else
            {
                newArray[i] = book;
            }
            i++;
        }
        
        Books = newArray;

    }
}
