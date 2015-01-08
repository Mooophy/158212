using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculator
    {
        public double divide(string a, string b)
        {
            //return 0;
            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);

            if (y==0) {
                throw new Exception("Zero divisor");
            }
            return (double)x / (double)y;
        }
    }
}
