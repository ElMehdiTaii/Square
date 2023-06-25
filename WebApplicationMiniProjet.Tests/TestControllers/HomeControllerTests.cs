using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationMiniProjet.Controllers;
using WebApplicationMiniProjet.Services.Services;

namespace WebApplicationMiniProjet.Tests.TestControllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ReturnsViewResultWithCorrectModel()
        {
            // Arrange
            var squareColorService = new SquareColorService();
            var controller = new HomeController(squareColorService);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<Microsoft.AspNetCore.Mvc.ViewResult>(result);
            Assert.Null(viewResult.ViewName);

            var viewData = Assert.IsAssignableFrom<ViewDataDictionary>(viewResult.ViewData);
            var squares = Assert.IsAssignableFrom<List<string>>(viewData["Squares"]);
            var expectedCount = 50;
            Assert.Equal(expectedCount, squares.Count);
        }
    }
}
