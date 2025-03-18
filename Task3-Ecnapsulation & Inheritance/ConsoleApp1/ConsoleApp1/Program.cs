using System.Runtime.InteropServices.JavaScript;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter surname: ");
        string surname = Console.ReadLine();

        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        
        Console.Write("Enter age: ");
        string age = Console.ReadLine();
       

        User user = new User(name, surname, username, password);
        try
        {
         user.Age = Byte.Parse(age);   
        }
        catch (Exception e)
        {
            Console.WriteLine("Please enter a valid age");
        }
        Console.WriteLine("------------------------");
        user.PrintUserDetails();
        Console.WriteLine("------------------------");
        user.ShowFullData();
    }
}