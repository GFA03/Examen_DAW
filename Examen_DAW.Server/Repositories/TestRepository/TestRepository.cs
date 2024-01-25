using Examen_DAW.Server.Data;
using Examen_DAW.Server.Models;
using Examen_DAW.Server.Repositories.GenericRepository;

namespace Examen_DAW.Server.Repositories.TestRepository
{
    public class TestRepository : GenericRepository<Test>, ITestRepository
    {
        public TestRepository(DatabaseContext dbContext) : base(dbContext) { }
    }
}
