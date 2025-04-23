using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models;

public abstract class Person
{
    public static int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public GenderEnum Gender { get; set; }

    public Person(string name,string surname,GenderEnum Gender)
    {
        Id++;
        Name = name;
        Surname = surname;
        this.Gender = Gender;
    }

}
