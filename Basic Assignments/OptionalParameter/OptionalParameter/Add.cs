using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    public class Add
    {
        // mehod with two parameters, one parameter optional
        public int Sum (int num1, int num2 = 0)
        {
            int sum = num1 + num2 + 5;
            return sum;
        }
    }
}
