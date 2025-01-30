

namespace FinanceFlowAPI.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }  
        public DateTime Month { get; set; } 
        public int UserId { get; set; }
    }
}