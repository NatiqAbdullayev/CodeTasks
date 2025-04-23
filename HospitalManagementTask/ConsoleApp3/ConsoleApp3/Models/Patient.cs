using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models;

class Patient:Person
{
    public string Name { get; set; }
    public string Surname{ get; set; }
    public GenderEnum Gender { get; set; }

    public Patient(string name,string surname,GenderEnum genderEnum):base(name,surname,genderEnum)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"Name:{Name}";
    }
}
