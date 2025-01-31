using FinanceFlowAPI.Models;
using FinanceFlowAPI.Repositories;
using System.Threading.Tasks;

namespace FinanceFlowAPI.Services
{
    public class BudgetService : IBudgetService
    {
        private readonly IBudgetRepository _budgetRepository;

        // Constructor for injecting the BudgetRepository dependency
        public BudgetService(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        // Creates a new budget for the user if it doesn't already exist
        public async Task<bool> CreateBudgetAsync(int userId, decimal amount)
        {
            // Check if the user already has a budget
            var existingBudget = await _budgetRepository.GetBudgetForUserAsync(userId);
            if (existingBudget is not null)
            {
                return false; // Budget already exists for the user, cannot create a new one
            }

            // Create a new budget for the user
            var newBudget = new Budget { UserId = userId, Amount = amount };
            await _budgetRepository.AddAsync(newBudget);
            return true; // Successfully created the budget
        }

        // Retrieves the remaining budget for the user
        public async Task<decimal> GetRemainingBudget(int userId)
        {
            // Get the budget for the user
            var budget = await _budgetRepository.GetBudgetForUserAsync(userId);

            // If the budget does not exist, return 0
            return budget?.Amount ?? 0;
        }

        // Updates the budget amount for the user
        public async Task<bool> UpdateBudgetAsync(int userId, decimal amount)
        {
            // Get the existing budget for the user
            var budget = await _budgetRepository.GetBudgetForUserAsync(userId);
            if (budget is null)
            {
                return false; // No budget found, cannot update
            }

            // Update the budget amount
            budget.Amount = amount;
            await _budgetRepository.UpdateAsync(budget);
            return true; // Successfully updated the budget
        }

        // Deletes the budget for the user
        public async Task<bool> DeleteBudgetAsync(int userId)
        {
            // Get the budget for the user
            var budget = await _budgetRepository.GetBudgetForUserAsync(userId);
            if (budget is null) // If no budget exists, it cannot be deleted
            {
                return false;
            }

            // Delete the budget
            await _budgetRepository.DeleteAsync(budget);
            return true; // Successfully deleted the budget
        }
    }
}
