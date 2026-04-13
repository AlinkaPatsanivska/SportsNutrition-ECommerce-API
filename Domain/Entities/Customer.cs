namespace ECommerce.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? FitnessGoal { get; set; } // Ціль: "Набір маси", "Схуднення"
        
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}