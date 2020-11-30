using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_EF5Core_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SkuirrelController : ControllerBase
    {
        private readonly Context _context;

        public SkuirrelController(Context context)
        {
            _context = context;
        }
        public async Task<ActionResult<Skuirrel>> GetAll()
        {
            var skuirrels = await _context.Skuirrel.ToListAsync();
            return Ok(skuirrels);
        }
    }
}