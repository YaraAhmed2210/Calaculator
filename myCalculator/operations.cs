using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCalculator
{
    public class operations
    {
        public operations()
        {

        }
        public double add(double? x , double? y)
        {
            if (x == null)
            {
                throw new ArgumentNullException(nameof(x));

            }
            if (y == null)
            {
                throw new ArgumentNullException(nameof(y));

            }
            return x.Value + y.Value;
        }
        public double subtract(double x, double y)
        {
            return x-y;
        }
        public double divide(double x, double y)
        {
            if (y == 0) //throw exception if denominator =0
            {
                throw new DivideByZeroException(nameof(y));
            }
            return x/ y;
            
        }
        public double multiply(double x, double y)
        {
            return x*y;
        }
    }
}
