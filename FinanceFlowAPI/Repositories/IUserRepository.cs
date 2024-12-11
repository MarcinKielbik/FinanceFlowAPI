using FinanceFlowAPI.Models;

namespace FinanceFlowAPI.Repositories
{
    public class IUserRepository
    {
        Task<User> GetByEmailAsync(string email);
        Task AddAsync(User user);
    }
}
