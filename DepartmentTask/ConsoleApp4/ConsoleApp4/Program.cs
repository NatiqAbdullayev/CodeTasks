using ConsoleApp4.Models.Concrete;

namespace ConsoleApp4;

public class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee("Natiq",12,2500);
        Employee emp2 = new Employee("Natiq",12,2500);
        Employee emp3 = new Employee("Natiq",12,2500);
        Department dep = new Department("IT",3);

        dep.AddEmployee(emp);
        Console.WriteLine(dep[0]);


    }
}
