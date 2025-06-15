using Microsoft.EntityFrameworkCore;
using PersonalLibrary.Domain.Entities;
using PersonalLibrary.Domain.Interface.Repository;
using PersonalLibrary.EF.Context;
namespace PersonalLibrary.EF.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly PersonalLibraryContext _personalLibraryContext;
        protected readonly DbSet<TEntity> DbSet;

        protected BaseRepository(PersonalLibraryContext personalLibraryContext)
        {
            _personalLibraryContext = personalLibraryContext;
            DbSet = personalLibraryContext.Set<TEntity>();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task Add(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Update(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public virtual async Task Delete(Guid id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await _personalLibraryContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _personalLibraryContext?.Dispose();
        }
    }
}
