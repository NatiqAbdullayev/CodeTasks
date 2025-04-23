using ConsoleApp5.Enums;
using ConsoleApp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5;

class Services
{
    private static int empCounter = 0;
    private static List<Employee> employees { get; } = [];

    public void AddEmployee(Employee emp)
    {
        if (emp is null)
        {
            throw new Exception("Employee object cannot be null ");
        }

        employees.Add(emp);
    }

    public Employee GetEmployeeById(int id)
    {
        foreach (Employee emp in employees)
        {
            if (Employee.Id == id)
            {
                return emp;
            }
        }
        throw new Exception("Not found any object with this id");
    }

    public List<Employee> GetAllEmployees() { return employees; }

    public List<Employee> GetAllEmployeesBySalary(int minSalary, int maxSalary)
    {
        List<Employee> newList = new List<Employee>();
        foreach (var item in employees)
        {
            if (item.Salary >= minSalary && item.Salary <= maxSalary)
            {
                newList.Add(item);
            }
        }

        if (newList.Count == 0)
        {
            throw new Exception("Not found any object with this salary value");

        }

        return newList;

    }

    public List<Employee> GetAllEmployeesByDepartmentNo(int no)
    {
        List<Employee> newList = new List<Employee>();

        foreach (var item in employees)
        {
            if (item.DepartmentNo == no)
            {
                newList.Add(item);
            }
        }

        if (newList.Count == 0)
        {
            throw new Exception("Not found any object with this salary value");

        }

        return newList;

    }

    public List<Employee> GetAllEmployeesByPosition(Position p)
    {
        List<Employee> newList = new List<Employee>();

        foreach (var item in employees)
        {
            if (item.Position == p)
            {
                newList.Add(item);
            }
        }

        if (newList.Count == 0)
        {
            throw new Exception("Not found any object with this salary value");

        }

        return newList;
    }
}
