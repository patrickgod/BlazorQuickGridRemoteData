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

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            _context.Database.EnsureCreated();
            
            var products = await _context.Products!.ToListAsync();

            return Ok(products);
        }
    }
}
