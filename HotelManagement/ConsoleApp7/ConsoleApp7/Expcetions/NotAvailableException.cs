﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Expcetions;

public class NotAvailableException:Exception
{
    public NotAvailableException(string msg):base(msg)
    {
        
    }
}
