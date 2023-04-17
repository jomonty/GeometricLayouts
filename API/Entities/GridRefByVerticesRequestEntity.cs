using Calculator.Models;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class GridRefByVerticesRequestEntity
    {
        [Required]
        public VertexCoord? vertex1 { get; set; }

        [Required]
        public VertexCoord? vertex2 { get; set;}

        [Required]
        public VertexCoord? vertex3 { get; set;}

        [Required]
        public int? gridHeight { get; set; }

        [Required]
        public int? gridWidth { get; set; }

        [Required]
        public int? gridSquareSideLength { get; set; }
    }
}
