using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using CalculatorTest.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class AutoMockingExample
    {
        [Fact]
        public void WithoutAutoMocking()
        {
            var mockEmailServer = new Mock<IEmailServer>();

            var sut = new PromoEmailSender(mockEmailServer.Object);

            sut.Send("Hi");

            mockEmailServer.Verify(x => x.Submit("Hil"), Times.Once());
        }

        [Fact]
        public void WithAutoMocking()
        {
            // This version not needs to be modified if more dependencies are added
            // to the PromoEmailSender, the auto mocking enabled in the
            // fixture will automatically provide the news dependecies to
            // us

            // Create a new AutoFixture fixture and enable Moq auto mocking
            var fixture = new Fixture().Customize(new AutoMoqCustomization());

            // Get a reference to the mock server that will be auto-supplied
            // so verifications can be made on it
            var mockEmailServer = fixture.Freeze<Mock<IEmailServer>>();

            // Now using AutoFixture to create or SUT
            var sut = fixture.Create<PromoEmailSender>();

            sut.Send("Hi");

            mockEmailServer.Verify(x => x.Submit("Hi"), Times.Once());
        }

        [Theory]
        [AutoFixtureMoqAutoData]
        public void WithAutoMockingAttribute(
            [Frozen] Mock<IEmailServer> mockEmailServer,
            PromoEmailSender sut
            )
        {
            // No longer need to write and maintain "arrange" phase of test
            sut.Send("Hi");

            mockEmailServer.Verify(x => x.Submit("Hi"), Times.Once());
        }
    }
}
