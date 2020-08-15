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
            Assert.False(this.email.validate("FrF@"));
            Assert.False(this.email.validate("rFF."));
            Assert.False(this.email.validate("r@."));
            Assert.True(this.email.validate("FF@cc.cc"));

        }
    }
}