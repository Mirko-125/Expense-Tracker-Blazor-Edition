namespace ExpenseTracker
{
    public class Expense
    {
        public int ID { get; set; }
        public string? Description { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"ID: {ID}, Description: {Description}, Amount: {Amount}, Spent on {Date} (UTC)";
        }
    }
}