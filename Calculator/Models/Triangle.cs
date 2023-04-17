namespace Calculator.Models
{
    public class Triangle
    {
        public VertexCoord? vertex1 { get; set; }
        public VertexCoord? vertex2 { get; set;}
        public VertexCoord? vertex3 { get; set;}

        public Triangle() { }

        public Triangle(VertexCoord vertex1, VertexCoord vertex2, VertexCoord vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }
    }
}
