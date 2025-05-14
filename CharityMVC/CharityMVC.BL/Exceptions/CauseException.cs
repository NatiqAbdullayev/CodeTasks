using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMVC.BL.Exceptions;

public class CauseException : Exception
{
    public CauseException(string msg):base(msg)
    {
        
    }
}
