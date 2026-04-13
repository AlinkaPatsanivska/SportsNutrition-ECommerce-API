namespace ECommerce.Domain.Entities
{
    public class NutritionPlan
    {
        public int Id { get; set; }
        public int DailyCalories { get; set; }
        public string Description { get; set; } = string.Empty;
        
        // План належить конкретному клієнту
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}