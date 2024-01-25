using Examen_DAW.Server.Models;
using Examen_DAW.Server.Repositories.MaterieRepository;

namespace Examen_DAW.Server.Services.MaterieService
{
    public class MaterieService : IMaterieService
    {
        private readonly IMaterieRepository _materieRepository;

        public MaterieService(IMaterieRepository materieRepository)
        {
            _materieRepository = materieRepository;
        }

        public async Task<List<Materie>> GetAll()
        {
            return await _materieRepository.GetAllAsync();
        }

        public async Task Create(Materie materie)
        {
            await _materieRepository.CreateAsync(materie);
            await _materieRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _materieRepository.DeleteById(id);
            _materieRepository.SaveAsync();
        }

        public async Task Update(Materie materie)
        {
            _materieRepository.Update(materie);
            await _materieRepository.SaveAsync();
        }
    }
}
