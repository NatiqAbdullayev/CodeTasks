namespace ConsoleApp1;

public class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }

    private byte _age;

    public byte Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public Human()
    {

    }

    public Human(string name)
    {
        
    }

    public Human(string name,string surname)
    {
        
    }

    public void ShowFullData()
    {
        if (!(Name.Length==0 || Surname.Length==0))
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}");
        }
        else
        {
            Console.WriteLine("Please enter valid name or surname");            
        }
    }
    
    public string GetFullName(){ return Name+""+Surname;}
}