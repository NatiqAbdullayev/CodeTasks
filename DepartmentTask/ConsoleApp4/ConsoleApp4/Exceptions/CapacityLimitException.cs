using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Exceptions;

public class CapacityLimitException:Exception
{
    public CapacityLimitException(string msg):base(msg)
    {
        
    }
}
