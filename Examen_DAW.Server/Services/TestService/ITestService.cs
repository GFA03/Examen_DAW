using Examen_DAW.Server.Models;

namespace Examen_DAW.Server.Services.TestService
{
    public interface ITestService
    {
        Task<List<Test>> GetAll();
        Task Create(Test test);
        void Delete(Guid id);
        Task Update(Test test);
    }
}
