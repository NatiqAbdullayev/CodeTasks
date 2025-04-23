using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Expcetions;

public class HotelException:Exception
{
    public HotelException(string msg):base(msg)
    {
        
    }
}
