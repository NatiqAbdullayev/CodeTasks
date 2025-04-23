using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models;

public class Department
{

    public static int No { get; set; }

    private int _empLimit;
    public int EmployeeLimit
    {
        get { return _empLimit; }
        set
        {
            if (value > 0 && value < 21)
            {
                _empLimit = value;
            }
            else
            {
                throw new Exception("Value must be between 0 and 20");
            }
        }
    }


    public Department(int limit)
    {
        No++;
    }

}
