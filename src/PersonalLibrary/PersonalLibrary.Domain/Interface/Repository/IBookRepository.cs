using PersonalLibrary.Domain.Entities;

namespace PersonalLibrary.Domain.Interface.Repository
{
    public interface IItemRepository : IBaseRepository<Item>
    {
        Task<IEnumerable<Item>> GetItemByUser(Guid idUser);
    }
}
