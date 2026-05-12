// File: Tests/Controllers/ProductsControllerTests.cs
// NUnit alternative: xUnit is used here.

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using ClaudPointsAPI_2.Controllers;

namespace ClaudPointsAPI_2.Tests.Controllers
{
    public class ProductsControllerTests
    {
        [Fact]
        public void GetProducts_ReturnsOkResult_WithExpectedProductList()
        {
            // Arrange
            var controller = new ProductsController(); // System Under Test

            // Act
            var result = controller.GetProducts();

            // Assert
            // Verify the result is an OkObjectResult
            var okResult = Assert.IsType<OkObjectResult>(result);

            // Verify the payload is a List<string> with the expected items
            var products = Assert.IsAssignableFrom<IEnumerable<string>>(okResult.Value);
            var productList = new List<string>(products);
            Assert.Equal(3, productList.Count);
            Assert.Collection(productList,
                p => Assert.Equal("Product 1", p),
                p => Assert.Equal("Product 2", p),
                p => Assert.Equal("Product 3", p)
            );
        }
    }
}
