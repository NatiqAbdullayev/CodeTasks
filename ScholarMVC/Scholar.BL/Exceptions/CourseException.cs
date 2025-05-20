using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.BL.Exceptions;

public class CourseException:Exception
{
    public CourseException(string msg) : base(msg)
    {
        
    }
}
