using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Moq
{
    public interface IEmailServer
    {
        void Submit(string message);
    }
}
