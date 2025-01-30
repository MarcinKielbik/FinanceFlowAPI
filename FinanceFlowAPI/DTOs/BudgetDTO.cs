namespace FinanceFlowAPI.DTOs
{
    public class BudgetDTO
    {
        public decimal Amount { get; set; } // Amount of the expense
        public DateTime Date { get; set; }   // Date of the expense
        public string Description { get; set; } // Description of the expense
        public int CategoryId { get; set; }  // ID of the category to which the expense belongs
    }
}