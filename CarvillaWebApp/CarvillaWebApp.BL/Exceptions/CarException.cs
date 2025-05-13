using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvillaWebApp.BL.Exceptions;

public class CarException:Exception
{

    public CarException(string msg):base(msg)
    {
        
    }

}
