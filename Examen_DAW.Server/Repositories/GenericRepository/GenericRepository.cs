using Examen_DAW.Server.Data;
using Examen_DAW.Server.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace Examen_DAW.Server.Repositories.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly DatabaseContext _dbContext;
        protected readonly DbSet<T> _table;

        public GenericRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<T>();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _table.AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _table.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task CreateAsync(T entity)
        {
            entity.Id = Guid.NewGuid();
            await _table.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _table.Update(entity);
        }

        public void Delete(T entity)
        {
            _table.Remove(entity);
        }

        public bool DeleteById(Guid id)
        {
            var entity = _table.Find(id);
            if (entity == null) return false;
            _table.Remove(entity);
            _dbContext.SaveChanges();
            return true;
        }

        public async Task<bool> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
