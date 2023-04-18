using API.Controllers;
using API.Entities;
using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Tests.ControllerTests
{
    public class VerticesByGridRefTest
    {
        GeometryController _controller = new GeometryController();

        [Fact]
        public void CanGetVerticesByGridRefA1()
        {
            // Arrange
            VerticesByGridRefRequestEntity request = new VerticesByGridRefRequestEntity()
            {
                gridRef = "A1",
                gridHeight = 60,
                gridWidth = 60,
                gridSquareSideLength = 10,
            };

            // Act
            var okResult = _controller.VerticesByGridRef(request);

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);

            var item = okResult.Result as OkObjectResult;

            Assert.IsType<Triangle>(item.Value);

            var triangleResult = item.Value as Triangle;

            Assert.Equal(0, triangleResult.vertex1.X);
            Assert.Equal(0, triangleResult.vertex1.Y);
            Assert.Equal(10, triangleResult.vertex2.X);
            Assert.Equal(10, triangleResult.vertex2.Y);
            Assert.Equal(0, triangleResult.vertex3.X);
            Assert.Equal(10, triangleResult.vertex3.Y);
        }

        [Fact]
        public void CanGetVerticesByGridRefF10()
        {
            // Arrange
            VerticesByGridRefRequestEntity request = new VerticesByGridRefRequestEntity()
            {
                gridRef = "F10",
                gridHeight = 60,
                gridWidth = 60,
                gridSquareSideLength = 10,
            };

            // Act
            var okResult = _controller.VerticesByGridRef(request);

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);

            var item = okResult.Result as OkObjectResult;

            Assert.IsType<Triangle>(item.Value);

            var triangleResult = item.Value as Triangle;

            Assert.Equal(40, triangleResult.vertex1.X);
            Assert.Equal(50, triangleResult.vertex1.Y);
            Assert.Equal(50, triangleResult.vertex2.X);
            Assert.Equal(60, triangleResult.vertex2.Y);
            Assert.Equal(50, triangleResult.vertex3.X);
            Assert.Equal(50, triangleResult.vertex3.Y);
        }
    }
}
