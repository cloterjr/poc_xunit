using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Moq
{
    public class EmailServer : IEmailServer
    {
        public void Submit(string message)
        {
            Console.WriteLine("Message Sended: " + message);
        }
    }
}
