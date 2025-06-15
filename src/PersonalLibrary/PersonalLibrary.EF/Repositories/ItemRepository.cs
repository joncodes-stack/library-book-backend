using Microsoft.EntityFrameworkCore;
using PersonalLibrary.Domain.Entities;
using PersonalLibrary.Domain.Interface.Repository;
using PersonalLibrary.EF.Context;

namespace PersonalLibrary.EF.Repositories
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        public ItemRepository(PersonalLibraryContext personalLibraryContext) : base(personalLibraryContext) { }

        public async Task<IEnumerable<Item>> GetItemByUser(Guid idUser)
        {
            return await _personalLibraryContext.Item
                   .Where(x => x.User.Id == idUser).ToListAsync();
        }
    }
}
