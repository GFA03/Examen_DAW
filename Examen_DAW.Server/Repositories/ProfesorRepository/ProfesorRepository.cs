using Examen_DAW.Server.Data;
using Examen_DAW.Server.Models;
using Examen_DAW.Server.Repositories.GenericRepository;

namespace Examen_DAW.Server.Repositories.ProfesorRepository
{
    public class ProfesorRepository : GenericRepository<Profesor>, IProfesorRepository
    {
        public ProfesorRepository(DatabaseContext databaseContext) : base(databaseContext) { }
    }
}
