using Calculator.Models;
using System.Collections.Immutable;

namespace Calculator.Calculators
{
    public class GridRefCalculator
    {
        public static GridRef FindGridRefByTriange(Grid grid, Triangle triangle)
        {
            /*  Assumption - vertex coordinates may be passed in any order to the triangle constructor.
             *  Given that, this method seeks to derive grid reference based on vertex coords alone,
             *  without context on where each is positioned on the triangle.
             */

            /* Letter part of grid reference (row), determined by 
             *  1. Finding average y coordinate over the 3 vertices.
             *  2. Dividing by length of a grid square side and flooring the result.
             *  3. Translating integer row value to char (row number + 65 as ).
             */
            double avgYCoord = (triangle.vertex1.Y + triangle.vertex2.Y + triangle.vertex3.Y) / 3;
            int intRow = (int)(avgYCoord / grid.gridSquareSideLength);
            char rowRef = Convert.ToChar(intRow + 65);

            /*  Number part of grid reference (col), determined by
             *  (sum(x coordinates) - min(x coordinate)) / length of a grid side square
             */
            int sumXCoords = triangle.vertex1.X + triangle.vertex2.X + triangle.vertex3.X;
            int minXCoord = Math.Min(triangle.vertex1.X, Math.Min(triangle.vertex2.X, triangle.vertex3.X));
            int colRef = (sumXCoords - minXCoord) / grid.gridSquareSideLength;

            // Create and return GridRef
            return new GridRef(rowRef, colRef);
        }
    }
}
