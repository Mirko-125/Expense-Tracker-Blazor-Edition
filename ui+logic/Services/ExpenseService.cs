using System.Text.Json;

namespace ExpenseTracker
{
    public class ExpenseService
    {
        private const string path = "Data/data.json";

        public List<Expense> LoadData()
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "[]");
                return new List<Expense>();
            }
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Expense>>(json) ?? new List<Expense>();
        }

        public void SaveData(List<Expense> expenses)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(expenses, options);
            File.WriteAllText(path, json);
        }

        // public void AddExpense(List<Expense> expenses, string description, string amount)
        // public void UpdateExpense(List<Expense> expenses, int id, string newDescription, int? newAmount)
        // public void DeleteExpense(List<Expense> expenses, int id)
        // public void ExportToCSV(List<Expense> expenses)
        // public List<Expense> FilterByMonth(List<Expense> expenses, int monthValue)
    }
}
