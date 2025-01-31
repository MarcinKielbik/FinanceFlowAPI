using FinanceFlowAPI.Models;

namespace FinanceFlowAPI.Repositories
{
    public interface IBudgetRepository
    {
        Task<Budget> GetBudgetForUserAsync(int userId);
        Task AddAsync(Budget budget);
        Task UpdateAsync(Budget budget);
        Task DeleteAsync(Budget budget);
    }
}