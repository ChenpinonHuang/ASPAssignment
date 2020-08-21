using ASPAssignment.Controllers;
using Xunit;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var home = new HomeController();
            var result = home.Index();
            Assert.NotNull(result);
        }

        [Fact]
        public void Test2()
        {
            var home = new HomeController();
            var result = home.About();
            Assert.NotNull(result);
        }

        [Fact]
        public void Test3()
        {
            var home = new HomeController();
            var result = home.Contact();
            Assert.NotNull(result);
        }

        [Fact]
        public void Test4()
        {
            var home = new HomeController();
            var result = home.Privacy();
            Assert.NotNull(result);
        }
    }


}
