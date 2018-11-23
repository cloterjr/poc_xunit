using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Moq
{
    public class AutoFixtureMoqAutoDataAttribute: AutoDataAttribute
    {
        public AutoFixtureMoqAutoDataAttribute():
            base(() => new Fixture()
                .Customize(new AutoMoqCustomization() { ConfigureMembers = true }))
        {

        }
    }
}
