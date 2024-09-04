using Entities;

namespace AppBackendAPI.Bussiness
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
    }
}
