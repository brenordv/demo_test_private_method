using Xunit;

namespace demo_test_private_method.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestDoMultiply()
        {
            var testClass = new ClassWithPrivateMethods();
            Assert.Equal(50, testClass._doMultiply(5, 10));
        }
        
        [Fact]
        public void TestDoSum()
        {
            var testClass = new ClassWithPrivateMethods();
            Assert.Equal(15, testClass._doSum(5, 10));
        }
    }
}