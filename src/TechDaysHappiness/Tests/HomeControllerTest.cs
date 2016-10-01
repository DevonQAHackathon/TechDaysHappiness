using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechDaysHappiness.Controllers;
using Xunit;

namespace TechDaysHappiness.Tests
{
    public class HomeControllerTest
    {

        [Fact]
        public void HomeControllerIndexViewTest()
        {
            var controller = new HomeController();

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void HomeControllerAboutViewTest()
        {
            var controller = new HomeController();

            var result = controller.About();

            var viewResult = Assert.IsType<ViewResult>(result);

            ViewDataDictionary viewData = viewResult.ViewData;
            Assert.Equal("Your application description page bla.", viewData["Message"]);

        }
    }
}
