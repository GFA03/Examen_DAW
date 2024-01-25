using Examen_DAW.Server.Models.DTOs;
using Examen_DAW.Server.Models;

namespace Examen_DAW.Server.Services.ProfesorMaterieService
{
    public interface IProfesorMaterieService
    {
        Task<List<ProfesorMaterie>> GetAll();
        Task Create(ProfesorMaterieDTO profesorMaterieDto);
    }
}
