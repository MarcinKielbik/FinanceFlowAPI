using FinanceFlowAPI.Models;

namespace FinanceFlowAPI.Services
{
    public interface IUserService
    {
        Task<User> AuthenticateAsync(string email, string password);
        Task RegisterAsync(User user);

    }
}
