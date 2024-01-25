using Examen_DAW.Server.Data;
using Examen_DAW.Server.Models;
using Examen_DAW.Server.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Examen_DAW.Server.Services.ProfesorMaterieService
{
    public class ProfesorMaterieService : IProfesorMaterieService
    {
        private readonly DatabaseContext _dbContext;
        private readonly DbSet<ProfesorMaterie> _table;

        public ProfesorMaterieService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<ProfesorMaterie>();
        }

        public async Task<List<ProfesorMaterie>> GetAll()
        {
            return await _table.AsNoTracking().ToListAsync();
        }
        public async Task Create(ProfesorMaterieDTO profesorMaterieDto)
        {
            ProfesorMaterie profesorMaterie = new ProfesorMaterie
            {
                MaterieId = profesorMaterieDto.MaterieId,
                ProfesorId = profesorMaterieDto.ProfesorId
            };

            await _table.AddAsync(profesorMaterie);
            await _dbContext.SaveChangesAsync();
        }
    }
}
