using HelloMVC4.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace HelloMVC4.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}