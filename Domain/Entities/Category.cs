namespace ECommerce.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Наприклад: "Протеїни"
        public string? Description { get; set; } 
        
        // Зв'язок один-до-багатьох: одна категорія має багато продуктів
        public List<Product> Products { get; set; } = new List<Product>();
    }
}