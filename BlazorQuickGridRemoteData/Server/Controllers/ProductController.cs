using BlazorQuickGridRemoteData.Server.Data;
using BlazorQuickGridRemoteData.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorQuickGridRemoteData.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{skip}/{take}")]
        public async Task<ActionResult<ProductResponse>> GetProducts(int skip, int take)
        {
            _context.Database.EnsureCreated();
            
            var count = await _context.Products.CountAsync();
            var products = await _context.Products!.Skip(skip).Take(take).ToListAsync();

            return Ok(new ProductResponse(products, count));
        }
    }
}
