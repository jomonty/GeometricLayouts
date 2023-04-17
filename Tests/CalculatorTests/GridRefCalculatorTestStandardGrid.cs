using Calculator.Calculators;
using Calculator.Models;

namespace Tests.CalculatorTests
{
    public class GridRefCalculatorTestStandardGrid
    {
        Grid grid = new Grid(60, 60, 10);

        [Fact]
        public void CanGetGridRefFromTriangle1()
        {
            // Arrange
            Triangle triangle = new Triangle
            (
                new VertexCoord(0, 0),
                new VertexCoord(10, 10),
                new VertexCoord(10, 0)
            );

            // Act
            GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);

            // Assert
            Assert.Equal("A2", result.StrRef);
        }

        [Fact]
        public void CanGetGridRefFromTriangle2()
        {
            // Arrange
            Triangle triangle = new Triangle
            (
                new VertexCoord(50, 10),
                new VertexCoord(60, 20),
                new VertexCoord(50, 20)
            );

            // Act
            GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);

            // Assert
            Assert.Equal("B11", result.StrRef);
        }

        [Fact]
        public void CanGetGridRefFromTriangle3()
        {
            // Arrange
            Triangle triangle = new Triangle
            (
                new VertexCoord(10, 30),
                new VertexCoord(20, 40),
                new VertexCoord(10, 40)
            );

            // Act
            GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);

            // Assert
            Assert.Equal("D3", result.StrRef);
        }

        [Fact]
        public void CanGetGridRefFromTriangle4()
        {
            // Arrange
            Triangle triangle = new Triangle
            (
                new VertexCoord(40, 50),
                new VertexCoord(50, 60),
                new VertexCoord(50, 50)
            );

            // Act
            GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);

            // Assert
            Assert.Equal("F10", result.StrRef);
        }

    }
}
