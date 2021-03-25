using System.Linq;
using GraphQL_EF5Core_API.DataLayer;
using GraphQL_EF5Core_API.DomainModels;
using GraphQL_EF5Core_API.Resources;
using HotChocolate;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_EF5Core_API.Resolvers
{
    public class OrderQuery
    {
        [UseDbContext(typeof(OrderContext))]
        public IQueryable<Order> GetOrders([ScopedService] OrderContext context) =>
            context.Orders.Include(o=>o.OrderLines);
    }
}