using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ansver
{
    public class Class1
    {
        public int storona;
        public int ploshad;
        public int perimeter;
        
        public Class1(int storonaValue)
        {
            storona = storonaValue;
            ploshad = storona * 2;
            perimeter = storona * 4;
        }
    }
}
