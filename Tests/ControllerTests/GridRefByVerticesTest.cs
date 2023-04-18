using API.Controllers;
using API.Entities;
using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Tests.ControllerTests
{
    public class GridRefByVerticesTest
    {
        GeometryController _controller = new GeometryController();

        [Fact]
        public void CanGetGridRefByVerticesA1()
        {
            // Arrange
            GridRefByVerticesRequestEntity request = new GridRefByVerticesRequestEntity()
            {
                vertex1 = new VertexCoord(0, 0),
                vertex2 = new VertexCoord(10, 10),
                vertex3 = new VertexCoord(0, 10),
                gridHeight = 60,
                gridWidth = 60,
                gridSquareSideLength = 10,
            };
            // Act
            var okResult = _controller.GridRefByVertices(request);

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);

            var item = okResult.Result as OkObjectResult;

            Assert.IsType<GridRef>(item.Value);

            var gridRefResult = item.Value as GridRef;

            Assert.Equal("A1", gridRefResult.StrRef);
        }

        [Fact]
        public void CanGetGridRefByVerticesF9()
        {
            // Arrange
            GridRefByVerticesRequestEntity request = new GridRefByVerticesRequestEntity()
            {
                vertex1 = new VertexCoord(40, 50),
                vertex2 = new VertexCoord(50, 60),
                vertex3 = new VertexCoord(40, 60),
                gridHeight = 60,
                gridWidth = 60,
                gridSquareSideLength = 10,
            };
            // Act
            var okResult = _controller.GridRefByVertices(request);

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);

            var item = okResult.Result as OkObjectResult;

            Assert.IsType<GridRef>(item.Value);

            var gridRefResult = item.Value as GridRef;

            Assert.Equal("F9", gridRefResult.StrRef);
        }
    }
}
