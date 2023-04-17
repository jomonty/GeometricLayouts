using API.Entities;
using Calculator.Calculators;
using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeometryController : Controller
    {
        [HttpPost("verticesbygridref")]
        [Produces("application/json")]
        public ActionResult VerticesByGridRef([FromBody] VerticesByGridRefRequestEntity request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                GridRef gridRef = new GridRef(request.gridRef);
                Grid grid = new Grid((int)request.gridHeight, (int)request.gridWidth, (int)request.gridSquareSideLength);
                Triangle result = TriangleCalculator.FindVerticesByGridRef(grid, gridRef);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            

            
        }

        [HttpPost("gridrefbyvertices")]
        [Produces("application/json")]
        public ActionResult GridRefByVertices([FromBody] GridRefByVerticesRequestEntity request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Grid grid = new Grid((int)request.gridHeight, (int)request.gridWidth, (int)request.gridSquareSideLength);
                Triangle triangle = new Triangle(request.vertex1, request.vertex2, request.vertex3);
                GridRef result = GridRefCalculator.FindGridRefByTriange(grid, triangle);
                return Ok(result);
            }
            catch (Exception e) 
            {
                return BadRequest(e.Message);
            }
        }
    }
}
