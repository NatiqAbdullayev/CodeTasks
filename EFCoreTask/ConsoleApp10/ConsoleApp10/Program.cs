using ConsoleApp10.Models;
using ConsoleApp10.Services;

namespace ConsoleApp10;

public class Program
{

    private readonly UserService service = new UserService();
    static void Main(string[] args)
    {
        bool status = true;
        Program p = new Program();
        do
        {
            Console.WriteLine("Xosgeldiniz.\nRegister ucun:1\nLogin ucun:2\ncixis ucun:0");
            string? command = Console.ReadLine();
            switch (command)
            {
                case "1":
                    p.Register();
                    break;
                case "2":
                    p.Login();
                    break;
                case "0":
                    status = false;
                    break;
                default:
                    Console.WriteLine("Yalnis secim");
                    break;
            }
        } while (status);
    }

    public void Register() {
        Console.Write("Enter username:");
        string? name = Console.ReadLine();
        Console.Write("Enter password:");
        string? pass = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(pass))
        {
            throw new Exception("Username and password cannot be empty");
        }
        User user = new User()
        {
            Username = name,
            Password = pass
        };

        service.AddUser(user);

    }

    public void Login()
    {
        Console.Write("Enter username:");
        string? name = Console.ReadLine();
        Console.Write("Enter password:");
        string? pass = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(pass))
        {
            throw new Exception("Username and password cannot be empty");
        }
        foreach (var user in service.GetAllUsers())
        {
            if (user.Username.Equals(name) && user.Password.Equals(pass))
            {
                Console.WriteLine("Login is successfull");
                Console.WriteLine($"Id:{user.Id} Username:{user.Username} Password:{user.Password}");
                return;
            }
        }
        throw new Exception("Username or password is incorrect");
    }
}
