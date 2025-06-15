using Microsoft.EntityFrameworkCore;
using PersonalLibrary.Domain.Entities;
using PersonalLibrary.Domain.Interface.Repository;
using PersonalLibrary.EF.Context;

namespace PersonalLibrary.EF.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(PersonalLibraryContext personalLibraryContext) : base(personalLibraryContext) {}

        public async Task<User> GetUserByEmail(string email)
        {
            return await _personalLibraryContext.User.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<User> GetUserByCode(int code)
        {
            return await _personalLibraryContext.User.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Code == code);
        }
    }
}
