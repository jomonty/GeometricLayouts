namespace Calculator.Models
{
    public class Grid
    {
        public int Height { get; }
        public int Width { get; }
        public int gridSquareSideLength { get; }

        public Grid(int height, int width, int gridSquareSideLength)
        {
            this.Height = height;
            this.Width = width;
            this.gridSquareSideLength = gridSquareSideLength;
        }
    }
}
