using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Moq
{
    public class PromoEmailSender
    {
        private readonly IEmailServer _emailServer;
        public PromoEmailSender(IEmailServer emailServer)
        {
            _emailServer = emailServer;
        }

        public void Send(string message)
        {
            _emailServer.Submit(message);
        }
    }
}
