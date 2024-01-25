using Examen_DAW.Server.Models;

namespace Examen_DAW.Server.Services.ProfesorService
{
    public interface IProfesorService
    {
        Task<List<Profesor>> GetAll();
        Task Create(Profesor profesor);
        void Delete(Guid id);
        Task Update(Profesor profesor);
    }
}
