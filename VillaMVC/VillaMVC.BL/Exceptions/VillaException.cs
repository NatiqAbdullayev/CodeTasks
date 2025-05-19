using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillaMVC.BL.Exceptions
{
    public class VillaException : Exception
    {
        public VillaException(string msg) : base(msg)
        {
        }
    }
}
