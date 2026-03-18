using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] 
    public class RendersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var misRenders = new[]
            {
                new { Id = 101, Proyecto = "Casa Luna - Exterior", Estado = "Finalizado" },
                new { Id = 102, Proyecto = "Oficina Central - Interior", Estado = "En Proceso" }
            };

            return Ok(misRenders);
        }
    }
}