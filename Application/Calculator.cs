using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Calculator
    {
        public static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        public static int Sub(int v1, int v2)
        {
            return v1 - v2;
            //throw new NotImplementedException();
        }

        private double Multiply(int v1, int v2)
        {
            return v1 * v2;
        }
    }
}
