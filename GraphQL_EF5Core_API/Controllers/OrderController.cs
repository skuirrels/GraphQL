using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GraphQL_EF5Core_API.DomainModels;
using GraphQL_EF5Core_API.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_EF5Core_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext _orderContext;
        private readonly IMapper _mapper;

        public OrderController(OrderContext orderContext, IMapper mapper)
        {
            _orderContext = orderContext;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<ActionResult<Order>> GetAll()
        {
            var orders = await _orderContext.Orders
                .Include(o => o.OrderLines)
                .ToListAsync();

            var result = _mapper.Map<IEnumerable<Order>, IEnumerable<OrderDto>>(orders);
            
            return Ok(result);
        }
    }
}