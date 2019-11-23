using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    public class SpecialException:ApplicationException
    {
        public SpecialException()
        {

        }

        public SpecialException(string msg):base(msg)
        {
            
        }
    }
}
