using Examen_DAW.Server.Data;
using Examen_DAW.Server.Models;
using Examen_DAW.Server.Repositories.GenericRepository;

namespace Examen_DAW.Server.Repositories.MaterieRepository
{
    public class MaterieRepository : GenericRepository<Materie>, IMaterieRepository
    {
        public MaterieRepository(DatabaseContext databaseContext) : base(databaseContext) { }
    }
}
