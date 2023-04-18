using Calculator.Models;

namespace Calculator.Utilities
{
    public static class CheckCalculatorValidity
    {
        public static bool CheckTriangle(Grid grid, Triangle triangle)
        {
            bool isValid = true;
            // Check all vertices are contained within grid
            if (!(triangle.vertex1.X <= grid.Width)) { isValid = false; };
            if (!(triangle.vertex1.Y <= grid.Height)) { isValid = false; };
            if (!(triangle.vertex2.X <= grid.Width)) { isValid = false; };
            if (!(triangle.vertex2.Y <= grid.Height)) { isValid = false; };
            if (!(triangle.vertex3.X <= grid.Width)) { isValid = false; };
            if (!(triangle.vertex3.Y <= grid.Height)) { isValid = false; };

            // Check each vertex has coordinates divisible by the grid square side length
            if (!(triangle.vertex1.X % grid.gridSquareSideLength == 0)) { isValid = false; };
            if (!(triangle.vertex1.Y % grid.gridSquareSideLength == 0)) { isValid = false; };
            if (!(triangle.vertex2.X % grid.gridSquareSideLength == 0)) { isValid = false; };
            if (!(triangle.vertex2.Y % grid.gridSquareSideLength == 0)) { isValid = false; };
            if (!(triangle.vertex3.X % grid.gridSquareSideLength == 0)) { isValid = false; };
            if (!(triangle.vertex3.Y % grid.gridSquareSideLength == 0)) { isValid = false; };

            // Check triangle is the correct size
            int minXCoord = Math.Min(triangle.vertex1.X, Math.Min(triangle.vertex2.X, triangle.vertex3.X));
            int maxXCoord = Math.Max(triangle.vertex1.X, Math.Max(triangle.vertex2.X, triangle.vertex3.X));
            int minYCoord = Math.Min(triangle.vertex1.Y, Math.Min(triangle.vertex2.Y, triangle.vertex3.Y));
            int maxYCoord = Math.Max(triangle.vertex1.Y, Math.Max(triangle.vertex2.Y, triangle.vertex3.Y));
            int triangleBase = maxXCoord - minXCoord;
            int triangleHeight = maxYCoord - minYCoord;
            double Area = (0.5 * triangleBase * triangleHeight);
            double checkArea = (0.5 * grid.gridSquareSideLength * grid.gridSquareSideLength);
            if (Area != checkArea) { isValid = false; };

            // Check triangle hypotenuse is in correct direction
            float gradient1 = (triangle.vertex1.X - triangle.vertex2.X) != 0 ?
                (triangle.vertex1.Y - triangle.vertex2.Y) / (triangle.vertex1.X - triangle.vertex2.X) : 0;
            float gradient2 = (triangle.vertex1.X - triangle.vertex2.X) != 0 ? 
                (triangle.vertex1.Y - triangle.vertex3.Y) / (triangle.vertex1.X - triangle.vertex2.X) : 0;
            float gradient3 = (triangle.vertex2.X - triangle.vertex3.X) != 0 ? 
                (triangle.vertex2.Y - triangle.vertex3.Y) / (triangle.vertex2.X - triangle.vertex3.X) : 0;

            if (gradient1 == -1 ||  gradient2 == -1 || gradient3 == -1) { isValid = false; }

 

            return isValid;
        }
    }
}
