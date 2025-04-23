
using ConsoleApp5.Enums;
using ConsoleApp5.Models;

namespace ConsoleApp5;


public class Program
{
    static void Main(string[] args)
    {
        Services service = new Services();

        Employee e1 = new Employee("test", "test", 12, 12, Position.Developer,200);
        Employee e2 = new Employee("test", "test", 14, 12, Position.CMO, 200);
        Employee e3 = new Employee("test", "test", 11, 11, Position.CEO, 200);

        service.AddEmployee(e1);
        service.AddEmployee(e2);
        service.AddEmployee(e3);

        foreach (var item in service.GetAllEmployeesByDepartmentNo(12))
        {
            Console.WriteLine(item);
        }
    }
}
