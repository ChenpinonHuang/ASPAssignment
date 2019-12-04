using System;
using Xunit;
using ASPAssignment.Controllers;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var home = new HomeController();
            var output = home.Index();
            Assert.NotNull(output);
        }
    }
}
