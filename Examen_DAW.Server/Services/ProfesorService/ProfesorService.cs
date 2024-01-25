using Examen_DAW.Server.Models;
using Examen_DAW.Server.Models.DTOs;
using Examen_DAW.Server.Repositories.ProfesorRepository;

namespace Examen_DAW.Server.Services.ProfesorService
{
    public class ProfesorService : IProfesorService
    {
        private readonly IProfesorRepository _profesorRepository;

        public ProfesorService(IProfesorRepository profesorRepository)
        {
            _profesorRepository = profesorRepository;
        }

        public async Task<List<Profesor>> GetAll()
        {
            return await _profesorRepository.GetAllAsync();
        }
        public async Task Create(ProfesorDTO profesorDto)
        {
            Profesor profesor = new Profesor{ Name = profesorDto.Name,
                                              Type = profesorDto.Type};
            await _profesorRepository.CreateAsync(profesor);
            await _profesorRepository.SaveAsync();
        }
        public async void Delete(Guid id)
        {
            _profesorRepository.DeleteById(id);
            await _profesorRepository.SaveAsync();
        }
        public async Task Update(Profesor profesor)
        {
            _profesorRepository.Update(profesor);
            await _profesorRepository.SaveAsync();
        }
    }
}
