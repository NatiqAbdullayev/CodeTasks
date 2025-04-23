using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models;

public class Doctor:Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age{ get; set; }
    public int ExpYear { get; set; }
    public DepartmentEnum DepartmentEnum { get; set; }

    public Doctor(string name,string surname,int age,int expYear,GenderEnum Gender,DepartmentEnum departmentEnum):base(name,surname,Gender)
    {
        Name = name;
        Age = age;
        ExpYear = expYear;
        DepartmentEnum = departmentEnum;
    }

    public override string ToString()
    {
        return $"Name:{Name}";
    }
}
