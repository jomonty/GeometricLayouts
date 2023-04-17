namespace Calculator.Models
{
    public class Grid
    {
        public int Height { get; }
        public int Width { get; }
        public int gridSquareSideLength { get; }

        public Grid(int height, int width, int gridSquareSideLength)
        {
            if (height % gridSquareSideLength != 0 || width % gridSquareSideLength != 0)
            {
                throw new Exception("Grid Square Side Length must be divisible into both height and width.");
            }
            this.Height = height;
            this.Width = width;
            this.gridSquareSideLength = gridSquareSideLength;
        }
    }
}
