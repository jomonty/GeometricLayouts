using Calculator.Calculators;
using Calculator.Models;

namespace Tests.CalculatorTests
{
    public class TriangleCalculatorTestSmallGrid
    {
        Grid grid = new Grid(8, 8, 2);

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
            Assert.Equal(2, result.vertex2.X);
            Assert.Equal(2, result.vertex2.Y);
            Assert.Equal(0, result.vertex3.X);
            Assert.Equal(2, result.vertex3.Y);
        }

        [Fact]
        public void CanGetTriangleFromGridRef2()
        {
            // Arrange
            GridRef gridRef = new GridRef("B5");

            // Act
            Triangle result = TriangleCalculator.FindVerticesByGridRef(grid, gridRef);

            // Assert
            Assert.Equal(4, result.vertex1.X);
            Assert.Equal(2, result.vertex1.Y);
            Assert.Equal(6, result.vertex2.X);
            Assert.Equal(4, result.vertex2.Y);
            Assert.Equal(4, result.vertex3.X);
            Assert.Equal(4, result.vertex3.Y);
        }

        [Fact]
        public void CanGetTriangleFromGridRef3()
        {
            // Arrange
            GridRef gridRef = new GridRef("C4");

            // Act
            Triangle result = TriangleCalculator.FindVerticesByGridRef(grid, gridRef);

            // Assert
            Assert.Equal(2, result.vertex1.X);
            Assert.Equal(4, result.vertex1.Y);
            Assert.Equal(4, result.vertex2.X);
            Assert.Equal(6, result.vertex2.Y);
            Assert.Equal(4, result.vertex3.X);
            Assert.Equal(4, result.vertex3.Y);
        }

        [Fact]
        public void CanGetTriangleFromGridRef4()
        {
            // Arrange
            GridRef gridRef = new GridRef("D7");

            // Act
            Triangle result = TriangleCalculator.FindVerticesByGridRef(grid, gridRef);

            // Assert
            Assert.Equal(6, result.vertex1.X);
            Assert.Equal(6, result.vertex1.Y);
            Assert.Equal(8, result.vertex2.X);
            Assert.Equal(8, result.vertex2.Y);
            Assert.Equal(6, result.vertex3.X);
            Assert.Equal(8, result.vertex3.Y);
        }
    }
}