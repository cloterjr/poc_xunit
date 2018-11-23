using Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Type.GetType("Calculator");
            Console.WriteLine(type);
            Console.ReadKey();
        }
    }
}
