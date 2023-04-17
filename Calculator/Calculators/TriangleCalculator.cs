using Calculator.Models;
using Calculator.Utilities;

namespace Calculator.Calculators
{
    public static class TriangleCalculator
    {
        public static Triangle FindVerticesByGridRef(Grid grid, GridRef gridRef)
        {
            /*  Approach to find triangle vertices by grid reference is as follows:
             *  1. Find the top left vertex coordinates of a triangle by it's grid ref
             *  2. Navigate down the hypotenuse to find the bottom right vertex coordinates
             *  3. Decide if it's a 'top' or 'bottom' triangle to find the vertex coords of the right angle
             */
            VertexCoord topLeftCoord = CalculateTopLeftCoord(gridRef, grid.gridSquareSideLength);
            VertexCoord bottomRightCoord = CalculateBottomRightCoord(topLeftCoord, grid.gridSquareSideLength);
            VertexCoord rightAngleCoord = CalculateRightAngleCoord(gridRef, bottomRightCoord, grid.gridSquareSideLength);

            Triangle result = new Triangle(topLeftCoord, bottomRightCoord, rightAngleCoord);

            if (!CheckCalculatorValidity.CheckTriangle(grid, result))
            {
                throw new Exception("Grid Ref invalid for supplied grid.");
            }

            return result;
        }

        private static VertexCoord CalculateTopLeftCoord(GridRef gridRef, int gridSquareSideLength)
        {
            // Find integer grid column, starting at 0 from left
            // ColNumber = Floor((gridRefCol - 1)/2), declaring as int floors the sum result
            int intCol = (gridRef.Col - 1) / 2;

            // Find integer grid row, starting at 0 from top
            // ASCII value of row reference, subtract 65 so A=0, B=1, C=2 etc
            int intRow = (int)gridRef.Row - 65;

            // Multiply integer row and col by side length of a grid square to find coords
            int xCoord = intCol * gridSquareSideLength;
            int yCoord = intRow * gridSquareSideLength;

            // Return top left Vertex Coordinate
            return new VertexCoord(xCoord, yCoord);
        }

        private static VertexCoord CalculateBottomRightCoord(VertexCoord topLeftCoord, int gridSquareSideLength)
        {
            // Navigate along hypotenuse, adding side length of a grid square to x and y coord of vertex
            int xCoord = topLeftCoord.X + gridSquareSideLength;
            int yCoord = topLeftCoord.Y + gridSquareSideLength;

            // Return bottom right Vertex Coordinate
            return new VertexCoord(xCoord, yCoord);
        }

        private static VertexCoord CalculateRightAngleCoord(GridRef gridRef, VertexCoord bottomRightCoord, int gridSquareSideLength)
        {
            /*  If gridRef.Col is even, the triangle is in the 'top' part of a grid square.
             *      The new vertex coords will be found by subtracting one grid square side length
             *      from the y coordinate of the bottom right vertex.
             *  If gridRef.Col is odd, the triangle is in the 'bottom' part of a grid square.
             *      The new vertex coords will be found by subtracting one grid square side length
             *      from the x coordinate of the bottom right vertex.
             */
            VertexCoord rightAngleCoord;
            if (gridRef.Col % 2 == 0)
            {
                int rightAngleX = bottomRightCoord.X;
                int rightAngleY = bottomRightCoord.Y - gridSquareSideLength;
                rightAngleCoord = new VertexCoord(rightAngleX, rightAngleY);
            }
            else
            {
                int rightAngleX = bottomRightCoord.X - gridSquareSideLength;
                int rightAngleY = bottomRightCoord.Y;
                rightAngleCoord = new VertexCoord(rightAngleX, rightAngleY);
            }

            // Return Vertex Coordinate for the right angle of the triangle
            return rightAngleCoord;
        }
    }
}
