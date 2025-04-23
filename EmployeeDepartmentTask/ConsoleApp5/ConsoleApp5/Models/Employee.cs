using ConsoleApp5.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models;

public class Employee
{
    public static int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public int DepartmentNo { get; set; }
    public Position Position { get; set; }
    public int Salary { get; set; }


    public Employee(string name, string surname, int age, int departmentNo, Position position, int salary)
    {
        Id++;
        Name = name;
        Surname = surname;
        Age = age;
        DepartmentNo = departmentNo;
        Position = position;
        Salary = salary;

    }


    public override string ToString()
    {
        return $"-------\nId:{Id}\nName:{Name}\nSurname:{Surname}\nAge:{Age}\nDepartment No:{DepartmentNo}\nPosition:{Position}\nSalary:{Salary}\n-------------";
        ;
    }

}
