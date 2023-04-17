namespace Calculator.Models
{
    public class Grid
    {
        public int Height { get; }
        public int Width { get; }
        public int SquareSize { get; }




        public Grid(int height, int width, int gridSquareWidth)
        {
            this.Height = height;
            this.Width = width;
            this.SquareSize = gridSquareWidth;
        }
    }
}
