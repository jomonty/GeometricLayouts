using Calculator.Calculators;
using Calculator.Models;

namespace Tests.CalculatorTests
{
    public class GridRefCalculatorTestSmallGrid
    {
        Grid grid = new Grid(8, 8, 2);

        [Fact]
        public void CanGetGridRefFromTriangle1()
        {
            // Arrange
            Triangle triangle = new Triangle
            (
                new VertexCoord(0, 0),
                new VertexCoord(2, 2),
                new VertexCoord(0, 2)
            );

            // Act
            GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);

            // Assert
            Assert.Equal("A1", result.StrRef);
        }

        [Fact]
        public void CanGetGridRefFromTriangle2()
        {
            // Arrange
            Triangle triangle = new Triangle
            (
                new VertexCoord(4, 2),
                new VertexCoord(6, 4),
                new VertexCoord(4, 4)
            );

            // Act
            GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);

            // Assert
            Assert.Equal("B5", result.StrRef);
        }

        [Fact]
        public void CanGetGridRefFromTriangle3()
        {
            // Arrange
            Triangle triangle = new Triangle
            (
                new VertexCoord(2, 4),
                new VertexCoord(4, 6),
                new VertexCoord(4, 4)
            );

            // Act
            GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);

            // Assert
            Assert.Equal("C4", result.StrRef);
        }

        [Fact]
        public void CanGetGridRefFromTriangle4()
        {
            // Arrange
            Triangle triangle = new Triangle
            (
                new VertexCoord(6, 6),
                new VertexCoord(8, 8),
                new VertexCoord(6, 8)
            );

            // Act
            GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);

            // Assert
            Assert.Equal("D7", result.StrRef);
        }

    }
}
