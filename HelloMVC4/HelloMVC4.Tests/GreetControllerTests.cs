using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloMVC4.Controllers;
using HelloMVC4.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC4.Tests
{
    public class GreetControllerTests
    {
        [Fact]
        void Index_Returns_ViewResult()
        {
            var controller = new GreetController();

            var result = controller.Index("ThisIsAString");

            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Index_Passes_GreetModel_To_View()
        {
            var controller = new GreetController();

            var result = controller.Index("ThisIsAString");

            Assert.IsType<GreetModel>(result.Model);
        }
        [Fact]
        public void Index_Sets_Name_On_Model()
        {
            var expectedName = "ExampleString";
            var controller = new GreetController();

            var result = controller.Index(expectedName);

            var model = (GreetModel)result.Model;
            Assert.Equal(expectedName, model.Name);
        }
    }
}