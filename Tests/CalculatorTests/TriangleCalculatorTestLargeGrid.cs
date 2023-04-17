using Calculator.Calculators;
using Calculator.Models;

namespace Tests.CalculatorTests
{
    public class TriangleCalculatorTestLargeGrid
    {
        Grid grid = new Grid(120, 120, 6);

        [Fact]
        public void CanGetTriangleFromGridRef1()
        {
            // Arrange
            GridRef gridRef = new GridRef("K24");

            // Act
            Triangle result = TriangleCalculator.FindVerticesByGridRef(grid, gridRef);

            // Assert
            Assert.Equal(66, result.vertex1.X);
            Assert.Equal(60, result.vertex1.Y);
            Assert.Equal(72, result.vertex2.X);
            Assert.Equal(66, result.vertex2.Y);
            Assert.Equal(72, result.vertex3.X);
            Assert.Equal(60, result.vertex3.Y);
        }

        [Fact]
        public void CanGetTriangleFromGridRef2()
        {
            // Arrange
            GridRef gridRef = new GridRef("I11");

            // Act
            Triangle result = TriangleCalculator.FindVerticesByGridRef(grid, gridRef);

            // Assert
            Assert.Equal(30, result.vertex1.X);
            Assert.Equal(48, result.vertex1.Y);
            Assert.Equal(36, result.vertex2.X);
            Assert.Equal(54, result.vertex2.Y);
            Assert.Equal(30, result.vertex3.X);
            Assert.Equal(54, result.vertex3.Y);
        }

        [Fact]
        public void CanGetTriangleFromGridRef3()
        {
            // Arrange
            GridRef gridRef = new GridRef("S39");

            // Act
            Triangle result = TriangleCalculator.FindVerticesByGridRef(grid, gridRef);

            // Assert
            Assert.Equal(114, result.vertex1.X);
            Assert.Equal(108, result.vertex1.Y);
            Assert.Equal(120, result.vertex2.X);
            Assert.Equal(114, result.vertex2.Y);
            Assert.Equal(114, result.vertex3.X);
            Assert.Equal(114, result.vertex3.Y);
        }

        [Fact]
        public void CanGetTriangleFromGridRef4()
        {
            // Arrange
            GridRef gridRef = new GridRef("E13");

            // Act
            Triangle result = TriangleCalculator.FindVerticesByGridRef(grid, gridRef);

            // Assert
            Assert.Equal(36, result.vertex1.X);
            Assert.Equal(24, result.vertex1.Y);
            Assert.Equal(42, result.vertex2.X);
            Assert.Equal(30, result.vertex2.Y);
            Assert.Equal(36, result.vertex3.X);
            Assert.Equal(30, result.vertex3.Y);
        }
    }
}