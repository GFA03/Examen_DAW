using Examen_DAW.Server.Models.DTOs;
using Examen_DAW.Server.Services.ProfesorMaterieService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Examen_DAW.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]

    public class ProfesorMaterieController : ControllerBase
    {
        private readonly IProfesorMaterieService _profesorMaterieService;

        public ProfesorMaterieController(IProfesorMaterieService profesorMaterieService)
        {
            _profesorMaterieService = profesorMaterieService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetProfesorMaterie()
        {
            return Ok(await _profesorMaterieService.GetAll());
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateProfesorMaterie(ProfesorMaterieDTO profesorMaterie)
        {
            await _profesorMaterieService.Create(profesorMaterie);
            return Ok();
        }
    }
}
