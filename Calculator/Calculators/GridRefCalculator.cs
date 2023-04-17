using Calculator.Models;

namespace Calculator.Calculators
{
    public static class GridRefCalculator
    {
        public static Triangle FindVerticesByGridRef(Grid grid, GridRef gridRef)
        {
            // Get top left coord of grid ref

            // X coord

            // ASCII value of Row reference, and reduce so A=0, B=1 etc
            int intRow = (int)gridRef.Row - 65;
            // Multiply by grid square side length
            int yCoord = intRow * grid.gridSquareSideLength;

            // y coord - col number starting at 0
            double unFlooredCol = (gridRef.Col - 1) / 2;
            int intCol = (int)Math.Floor(unFlooredCol);
            // Multiply by grid square side length
            int xCoord = intCol * grid.gridSquareSideLength;

            VertexCoord topLeftCoord = new VertexCoord(xCoord, yCoord);


            // "Walk" down hypotenuse
            VertexCoord bottomRightCoord = new VertexCoord(xCoord + grid.gridSquareSideLength, yCoord + grid.gridSquareSideLength);


            // Decision on where final coord is
            VertexCoord rightAngleCoord;
            if (gridRef.Col % 2 == 0)
            {
                int rightAngleX = bottomRightCoord.X;
                int rightAngleY = bottomRightCoord.Y - grid.gridSquareSideLength;
                rightAngleCoord = new VertexCoord(rightAngleX, rightAngleY);
            } else
            {
                int rightAngleX = bottomRightCoord.X - grid.gridSquareSideLength;
                int rightAngleY = bottomRightCoord.Y;
                rightAngleCoord = new VertexCoord(rightAngleX, rightAngleY);
            }

            Triangle result = new Triangle(topLeftCoord, bottomRightCoord, rightAngleCoord);

            return result;
        }
    }
}
