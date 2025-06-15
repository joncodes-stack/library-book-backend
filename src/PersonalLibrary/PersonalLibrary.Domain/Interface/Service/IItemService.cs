using PersonalLibrary.Domain.Dtos;
using PersonalLibrary.Domain.Entities;

namespace PersonalLibrary.Domain.Interface.Service
{
    public interface IItemService : IDisposable
    {
        Task Add(ItemDto item);
        Task Update(ItemDto item);
        Task Delete(Guid id);
        Task<ItemDto> GetById(Guid id);
        Task<IEnumerable<ItemDto>> GetByUser(Guid idUser);
        Task<IEnumerable<ItemDto>> GetAll();
    }
}
