using PersonalLibrary.Domain.Entities;

namespace PersonalLibrary.Domain.Interface.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserByCode(int code);
    }
}
