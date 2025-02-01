using FinanceFlowAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceFlowAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        private readonly IBudgetService _budgetService;

        public BudgetController(IBudgetService budgetService)
        {
            _budgetService = budgetService;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetRemainingBudget(int userId)
        {
            var remainingBudget = await _budgetService.GetRemainingBudget(userId);

            if (remainingBudget == 0)
                return NotFound("No budget found for this user.");

            return Ok(remainingBudget);
        }

        [HttpPost("{userId}")]
        public async Task<IActionResult> CreateBudget(int userId, [FromBody] decimal amount)
        {
            var success = await _budgetService.CreateBudgetAsync(userId, amount);

            if(!success)
            {
                return BadRequest("Budget already exists for this user.");
            }

            return CreatedAtAction(nameof(CreateBudget), userId, amount);
        }

        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateBudget(int userId, [FromBody] decimal amount)
        {
            var success = await _budgetService.UpdateBudgetAsync(userId, amount);

            if (!success)
            {
                return NotFound("Budget not found for this user.");
            }

            return NoContent(); // No content, successful update
        }


        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteBudget(int userId)
        {
            var success = await _budgetService.DeleteBudgetAsync(userId);

            if (!success)
            {
                return NotFound("Budget not found for this user.");
            }

            return NoContent(); // No content, successful delete
        }
    }
}
