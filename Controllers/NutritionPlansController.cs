using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionPlansController : ControllerBase
    {
        private readonly AppDbContext _context;

        public NutritionPlansController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NutritionPlan>>> GetNutritionPlans()
        {
            return await _context.NutritionPlans.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<NutritionPlan>> PostNutritionPlan(NutritionPlan plan)
        {
            _context.NutritionPlans.Add(plan);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetNutritionPlans), new { id = plan.Id }, plan);
        }
    }
}