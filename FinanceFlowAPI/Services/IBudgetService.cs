namespace FinanceFlowAPI.Services
{
    public interface IBudgetService
    {
        Task<decimal> GetRemainingBudget(int userId);
        Task<bool> CreateBudgetAsync(int userId, decimal amount);
        Task<bool> UpdateBudgetAsync(int userId, decimal amount);
        Task<bool> DeleteBudgetAsync(int userId);
    }
}
