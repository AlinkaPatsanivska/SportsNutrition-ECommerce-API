namespace ECommerce.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Наприклад: "100% Whey Gold"
        public decimal Price { get; set; }
        public string? Flavor { get; set; } // Смак: Шоколад, Ваніль
        public int WeightInGrams { get; set; }
        
        // Зовнішній ключ для зв'язку з категорією
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}