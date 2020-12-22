using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsMath
{
    public class MathClass
    {
        // three math methods, each of which will take one integer parameter in and return an integer
        public int sum(int num)
        {
            num = num + 33;
            return num;
        }

        public int quotient(int num)
        {
            num = num / 2;
            return num;
        }

        public int product(int num)
        {
            num = num * 3;
            return num;
        }

        
    }
}
