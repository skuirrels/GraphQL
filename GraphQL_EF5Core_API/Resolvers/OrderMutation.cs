using System.Threading.Tasks;
using GraphQL_EF5Core_API.DataLayer;
using GraphQL_EF5Core_API.DomainModels;
using HotChocolate;

namespace GraphQL_EF5Core_API.Resolvers
{
    public class OrderMutation
    {
        public async Task<AddOrderPayload> AddOrderAsync(AddOrderInput input, [Service] OrderContext context)
        {
            var order = new Order
            {
                OrderNumber = input.OrderNumber,
                Buyer = input.Buyer,
                Supplier = input.Supplier
            };

            await context.Orders.AddAsync(order);
            await context.SaveChangesAsync();

            return new AddOrderPayload(order);
        }
    }
}