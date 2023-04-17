using Calculator.Calculators;
using Calculator.Models;

namespace Tests.CalculatorTests
{
    public class GridRefCalculatorTestLargeGrid
    {
        Grid grid = new Grid(120, 120, 6);

        [Fact]
        public void CanGetGridRefFromTriangle1()
        {
            // Arrange
            Triangle triangle = new Triangle
            (
                new VertexCoord(66, 60),
                new VertexCoord(72, 66),
                new VertexCoord(72, 60)
            );

            // Act
            GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);

            // Assert
            Assert.Equal("K24", result.StrRef);
        }

        [Fact]
        public void CanGetGridRefFromTriangle2()
        {
            // Arrange
            Triangle triangle = new Triangle
            (
                new VertexCoord(30, 48),
                new VertexCoord(36, 54),
                new VertexCoord(30, 54)
            );

            // Act
            GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);

            // Assert
            Assert.Equal("I11", result.StrRef);
        }

        [Fact]
        public void CanGetGridRefFromTriangle3()
        {
            // Arrange
            Triangle triangle = new Triangle
            (
                new VertexCoord(114, 108),
                new VertexCoord(120, 114),
                new VertexCoord(114, 114)
            );

            // Act
            GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);

            // Assert
            Assert.Equal("S39", result.StrRef);
        }

        [Fact]
        public void CanGetGridRefFromTriangle4()
        {
            // Arrange
            Triangle triangle = new Triangle
            (
                new VertexCoord(36, 24),
                new VertexCoord(42, 30),
                new VertexCoord(36, 30)
            );

            // Act
            GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);

            // Assert
            Assert.Equal("E13", result.StrRef);
        }

    }
}
