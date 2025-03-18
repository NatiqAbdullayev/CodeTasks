namespace ConsoleApp1;

public class User : Human
{
    private string _username;

    public string Username
    {
        get { return _username; }
        set
        {
            if (value.Length < 6 || value.Length > 25)
            {
                Console.WriteLine("Username must be between 6 and 25 characters.");
            }
            else
            {
                _username = value;
            }
        }
    }

    private string _password;

    public string Password
    {
        get { return _password; }
        set
        {
            if (value.Length < 8 || value.Length > 25)
            {
                Console.WriteLine("Password must be between 8 and 25 characters.");
            }
            else
            {
                _password = value;
            }
        }
    }


    public User(string name, string surname, string username, string password) : base(name, surname)
    {
        Name = name;
        Surname = surname;
        Username = username;
        Password = password;
    }

    public void PrintUserDetails()
    {
        if (!(_username == null || _password == null))
        {
            Console.WriteLine($"Username: {Username}\nName: {Name}\nSurname: {Surname}\nPassword:Private");
        }
        else
        {
            Console.WriteLine("Please enter valid username or password");            
        }
    }
}