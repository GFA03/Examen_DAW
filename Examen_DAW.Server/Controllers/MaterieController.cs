using Examen_DAW.Server.Models;
using Examen_DAW.Server.Models.DTOs;
using Examen_DAW.Server.Services.MaterieService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Examen_DAW.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class MaterieController : ControllerBase
    {
        private readonly IMaterieService _materieService;

        public MaterieController(IMaterieService materieService)
        {
            _materieService = materieService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetMaterii()
        {
            return Ok(await _materieService.GetAll());
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateMaterie(MaterieDTO materie)
        {
            await _materieService.Create(materie);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> UpdateMaterie(Materie materie)
        {
            await _materieService.Update(materie);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteMaterie(Guid id)
        {
            _materieService.Delete(id);
            return Ok();
        }
    } 
}
