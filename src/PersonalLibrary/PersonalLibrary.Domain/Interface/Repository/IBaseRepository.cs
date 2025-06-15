using PersonalLibrary.Domain.Entities;

namespace PersonalLibrary.Domain.Interface.Repository
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        Task Add(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task Delete(Guid id);
        Task<int> SaveChanges();
    }
}
