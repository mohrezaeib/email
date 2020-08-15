using MyApp;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        Email email;
        [SetUp]
        public void Setup()
        {
             this.email = new Email();

        }

        [Test]
        public void Test1()
        {
            Assert.False(this.email.validate("FF@"));
            Assert.False(this.email.validate("FF."));
            Assert.True(this.email.validate("FF@cc.cc"));

        }
    }
}