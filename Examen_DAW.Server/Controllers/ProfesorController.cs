using Examen_DAW.Server.Models;
using Examen_DAW.Server.Services.ProfesorService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Examen_DAW.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class ProfesorController : ControllerBase
    {
        
            private readonly IProfesorService _profesorService;

            public ProfesorController(IProfesorService profesorService)
            {
                _profesorService = profesorService;
            }

            [HttpGet("all")]
            public async Task<IActionResult> GetProfesori()
            {
                return Ok(await _profesorService.GetAll());
            }

            [HttpPost("create")]
            public async Task<IActionResult> CreateProfesor(Profesor profesor)
            {
                await _profesorService.Create(profesor);
                return Ok();
            }

            [HttpPatch("update")]
            public async Task<IActionResult> UpdateProfesor(Profesor profesor)
            {
                await _profesorService.Update(profesor);
                return Ok();
            }

            [HttpDelete("delete/{id}")]
            public IActionResult DeleteProfesor(Guid id)
            {
                _profesorService.Delete(id);
                return Ok();
            }
        }
}
