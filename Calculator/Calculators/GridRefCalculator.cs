using Calculator.Models;
using System.Collections.Immutable;

namespace Calculator.Calculators
{
    public class GridRefCalculator
    {
        public static GridRef FindGridRefByTriange(Grid grid, Triangle triangle)
        {
            // Find average y coord
            double avgYCoord = (triangle.vertex1.Y + triangle.vertex2.Y + triangle.vertex3.Y) / 3;
            // Divide by side length of a grid square and floor to find integer row reference
            int intRow = (int)(avgYCoord / grid.gridSquareSideLength);
            // Translate to char 1 = A, 2 = B, 3 = C etc
            char row = Convert.ToChar(intRow + 65);


            //// Find average x coord
            int sumXCoords = triangle.vertex1.X + triangle.vertex2.X + triangle.vertex3.X;
            int dividedByGridSize = sumXCoords / grid.gridSquareSideLength;
            int minXCoord = Math.Min(triangle.vertex1.X, Math.Min(triangle.vertex2.X, triangle.vertex3.X));
            int minXCoordDividedByGridSize = minXCoord / grid.gridSquareSideLength;
            int answer = dividedByGridSize - minXCoordDividedByGridSize;

            return new GridRef(row, answer);
        }
    }
}
