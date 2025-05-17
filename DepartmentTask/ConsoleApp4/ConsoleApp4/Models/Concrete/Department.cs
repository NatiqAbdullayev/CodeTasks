using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Exceptions;

namespace ConsoleApp4.Models.Concrete;

public class Department
{
    private static int _counter = 0;
    public int Id { get; set; }
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    private Employee[] Employees;

    public Department(string Name, int EmployeeLimit)
    {
        _counter++;
        Id = _counter;
        this.Name = Name;
        this.EmployeeLimit = EmployeeLimit;
        Employees = [];
    }

    public void AddEmployee(Employee emp)
    {
        Array.Resize(ref Employees, 1);
        Employees[Employees.Length-1]= emp;


        if (Employees.Length >= EmployeeLimit)
        {
            throw new CapacityLimitException("Capacity limit is full");
        }
    }

    public Employee this[int index]
    {
        get { return Employees[index]; }

        set { Employees[index] = value; }
    }

}
