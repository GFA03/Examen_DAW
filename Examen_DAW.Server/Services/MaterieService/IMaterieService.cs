using Examen_DAW.Server.Models;

namespace Examen_DAW.Server.Services.MaterieService
{
    public interface IMaterieService
    {
        Task<List<Materie>> GetAll();
        Task Create(Materie materie);
        void Delete(Guid id);
        Task Update(Materie materie);
    }
}
