using FinanceFlowAPI.Data;
using FinanceFlowAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceFlowAPI.Repositories
{
    public class BudgetRepository : IBudgetRepository
    {
        private readonly AppDbContext _budgetContext;

        public BudgetRepository(AppDbContext budgetContext)
        {
            _budgetContext = budgetContext;
        }

        public async Task<Budget> GetBudgetForUserAsync(int userId)
        {
            return await _budgetContext.Budgets.FirstOrDefaultAsync(b => b.UserId == userId);
        }

        public async Task AddAsync(Budget budget)
        {
            await _budgetContext.Budgets.AddAsync(budget);
            await _budgetContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Budget budget)
        {
            _budgetContext.Update(budget);
            await _budgetContext.SaveChangesAsync();
        }


        public async Task DeleteAsync(Budget budget)
        {
            _budgetContext.Remove(budget);
            await _budgetContext.SaveChangesAsync();
        }
    }
}