using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        // Підключаємо нашу базу даних до контролера
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // 1. Отримати список усіх товарів (GET)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        // 2. Додати новий товар у базу (POST)
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            // Повертаємо повідомлення, що товар успішно створено
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }
    }
}