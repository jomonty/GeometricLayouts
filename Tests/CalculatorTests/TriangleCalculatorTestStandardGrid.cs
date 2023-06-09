using Calculator.Calculators;
using Calculator.Models;

namespace Tests.CalculatorTests
{
    public class TriangleCalculatorTestStandardGrid
    {
        Grid grid = new Grid(60, 60, 10);

        [Fact]
        public void CanGetTriangleFromGridRef1()
        {
            // Arrange
            GridRef gridRef = new GridRef("A1");

            // Act
            Triangle result = TriangleCalculator.FindVerticesByGridRef(grid, gridRef);

            // Assert
            Assert.Equal(0, result.vertex1.X);
            Assert.Equal(0, result.vertex1.Y);
            Assert.Equal(10, result.vertex2.X);
            Assert.Equal(10, result.vertex2.Y);
            Assert.Equal(0, result.vertex3.X);
            Assert.Equal(10, result.vertex3.Y);
        }

        [Fact]
        public void CanGetTriangleFromGridRef2()
        {
            // Arrange
            GridRef gridRef = new GridRef("B12");

            // Act
            Triangle result = TriangleCalculator.FindVerticesByGridRef(grid, gridRef);

            // Assert
            Assert.Equal(50, result.vertex1.X);
            Assert.Equal(10, result.vertex1.Y);
            Assert.Equal(60, result.vertex2.X);
            Assert.Equal(20, result.vertex2.Y);
            Assert.Equal(60, result.vertex3.X);
            Assert.Equal(10, result.vertex3.Y);
        }

        [Fact]
        public void CanGetTriangleFromGridRef3()
        {
            // Arrange
            GridRef gridRef = new GridRef("D4");

            // Act
            Triangle result = TriangleCalculator.FindVerticesByGridRef(grid, gridRef);

            // Assert
            Assert.Equal(10, result.vertex1.X);
            Assert.Equal(30, result.vertex1.Y);
            Assert.Equal(20, result.vertex2.X);
            Assert.Equal(40, result.vertex2.Y);
            Assert.Equal(20, result.vertex3.X);
            Assert.Equal(30, result.vertex3.Y);
        }

        [Fact]
        public void CanGetTriangleFromGridRef4()
        {
            // Arrange
            GridRef gridRef = new GridRef("F9");

            // Act
            Triangle result = TriangleCalculator.FindVerticesByGridRef(grid, gridRef);

            // Assert
            Assert.Equal(40, result.vertex1.X);
            Assert.Equal(50, result.vertex1.Y);
            Assert.Equal(50, result.vertex2.X);
            Assert.Equal(60, result.vertex2.Y);
            Assert.Equal(40, result.vertex3.X);
            Assert.Equal(60, result.vertex3.Y);
        }
    }
}