using NUnit.Framework;
using HelloWorld.Models;
using HelloWorld.Controllers;
using Microsoft.Extensions.Options;
using System.Linq;

namespace HelloWorld.Test
{
    public class ProductTests
    {
        [Test]
        public void TestMethodWithFakeClass()
        {
            // Arrange - setting up the enviornment
            var optionsMyJsonSettings = Options.Create(new MyJsonSettings()
            { SiteTitle = "Hello test", SiteCopyRightYear = 2019});
            

            var controller = new HomeController(new FakeProductRepository(), optionsMyJsonSettings);

            // Act - do action on the enviornment
            var result = controller.Products();

            var viewresult = (Microsoft.AspNetCore.Mvc.ViewResult)(result);

            // Assert
            var products = (Product[])viewresult.Model;

            Assert.AreEqual(5, products.Length, "Length is invalid");
           
        }
        [Test]
        public void Test2Method()
        {
            // Arrange - setting up the enviornment
            var optionsMyJsonSettings = Options.Create(new MyJsonSettings()
            { SiteTitle = "Hello test", SiteCopyRightYear = 2019 });


            var controller = new HomeController(new FakeProductRepository(), optionsMyJsonSettings);

            // Act - do action on the enviornment
            var result = controller.Products();

            var viewresult = (Microsoft.AspNetCore.Mvc.ViewResult)(result);

            // Assert
            var products = (Product[])viewresult.Model;

            Assert.AreEqual(5, products.Length, "Length is invalid");

            Assert.GreaterOrEqual( products.Where(t => t.Price > 10).Count(), 3 , "Less than expected were found");

            Assert.GreaterOrEqual(products.Where(t => t.Price < 10).Count(), 2 , "More than expected were found");


        }
    }
}
