using Calculator.Models;
using Calculator.Utilities;

namespace Calculator.Calculators
{
    public class GridRefCalculator
    {
        public static GridRef FindGridRefByTriange(Grid grid, Triangle triangle)
        {
            if (!CheckCalculatorValidity.CheckTriangle(grid, triangle))
            {
                throw new Exception("Triangle vertices invalid for supplied grid.");
            }
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
             *      There are 2x as many column references as 'columns' of squares
             *      So this is a method of identifying which sub-column we need by the number of x coords
             *      on either side of the main column.
             *      eg. 
             *          For triangle D7 in a grid 60 x 60 with grid square length of 10,
             *          we have x coords of 30, 40, 30.
             *          (100 - 30) = 70, dividing by the grid square length of 10 gives 7.
             *          
             *          For triangle S39 in a grid 120 x 120 with grid square length of 6
             *          we have x coords of 114, 120, 114.
             *          (348 - 114) = 234, so dividing by the grid square length of 6 gives 39.
             */
            int sumXCoords = triangle.vertex1.X + triangle.vertex2.X + triangle.vertex3.X;
            int minXCoord = Math.Min(triangle.vertex1.X, Math.Min(triangle.vertex2.X, triangle.vertex3.X));
            int colRef = (sumXCoords - minXCoord) / grid.gridSquareSideLength;

            // Create and return GridRef
            return new GridRef(rowRef, colRef);
        }

        
    }
}
