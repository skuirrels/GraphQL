using GraphQL_EF5Core_API.DomainModels;

namespace GraphQL_EF5Core_API.Resolvers
{
    public class AddOrderPayload
    {
        public AddOrderPayload(Order order)
        {
            Order = order;
        }

        public Order Order { get; }    
    }

    public record AddOrderInput (
      string OrderNumber,
      string Buyer,
      string Supplier
    );
    
    public record AddOrderLineInput (
        string LineNumber,
        string ProductCode,
        string ProductDescription,
        int? Quantity
    );
}
