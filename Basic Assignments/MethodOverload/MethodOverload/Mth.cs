using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    public class Mth
    {
        //  Takes an integer and returns an integer
        public int add (int num)
        {
            num = 2 + num;
            return num;
        }


        // Takes a decimal and returns an integer
        public int add (decimal num)
        {
            num = 3 + num;
            return Convert.ToInt32(num);
        }

        // Takes a string and returns an integer
        public int add (string num)
        {
            int number = Convert.ToInt32(num);

            return 4 + number;

        }

    }
}
