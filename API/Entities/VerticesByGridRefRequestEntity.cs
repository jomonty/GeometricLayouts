using Calculator.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Entities
{
    public class VerticesByGridRefRequestEntity
    {
        [Required]
        public string? gridRef { get; set; }

        [Required]
        public int? gridHeight { get; set; }

        [Required]
        public int? gridWidth { get; set; }

        [Required]
        public int? gridSquareSideLength { get; set; }
    }
}
