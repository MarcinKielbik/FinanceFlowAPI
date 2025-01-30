namespace FinanceFlowAPI.Models
{ 
    public class Expense
    {
        public int Id { get; set; }
        public decimal Amount { get; set; } // Amount of the expense (e.g. 50.00 for a meal)
        public DateTime Date { get; set; } // Date when the expense was made
        public string Description { get; set; } // A brief description of the expense (e.g. "Lunch at a restaurant")
        public int CategoryId { get; set; } // Foreign key to the category this expense belongs to
        public Category Category { get; set; } // The category object related to the expense (e.g. "Food", "Entertainment")
    }


}