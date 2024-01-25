using Examen_DAW.Server.Models;
using Examen_DAW.Server.Models.DTOs;

namespace Examen_DAW.Server.Services.MaterieService
{
    public interface IMaterieService
    {
        Task<List<Materie>> GetAll();
        Task Create(MaterieDTO materieDto);
        void Delete(Guid id);
        Task Update(Materie materie);
    }
}
