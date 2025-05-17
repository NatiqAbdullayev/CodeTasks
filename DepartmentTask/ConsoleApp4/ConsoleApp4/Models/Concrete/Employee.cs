using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Models.Abstract;

namespace ConsoleApp4.Models.Concrete;

public class Employee : IPerson
{
    private static int _idCounter=0;
    public int Id { get; }
    public string Name { get ; set ; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee(string name,int age,double salary)
    {
        _idCounter++;
        Id= _idCounter;
        Name= name;
        Age= age;
        Salary= salary;
    }

    public string ShowInfo()
    {
        return ($"Id:{Id} Name:{Name} Age:{Age} Salary:{Salary}"); ;
    }

    public override string ToString()
    {
        return ShowInfo();
    }
}
