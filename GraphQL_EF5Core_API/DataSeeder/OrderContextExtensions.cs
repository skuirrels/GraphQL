using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL_EF5Core_API.DomainModels;

namespace GraphQL_EF5Core_API.DataSeeder
{
    public static class SeedOrders
    {
        public static void Seed(this OrderContext context)
        {
            if (!context.Orders.Any())
            {
                // Seed Orders 
                context.Orders.Add(new Order
                {
                    Id = System.Guid.NewGuid(),
                    OrderNumber = "PO111",
                    Buyer = "Skuirrels Inc",
                    Supplier = "Tails Corp",
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine
                        {
                            Id = System.Guid.NewGuid(),
                            LineNumber = 1,
                            Quantity = 10,
                            ProductCode = "SLIP1",
                            ProductDescription = "Slippers"
                        },
                        new OrderLine
                        {
                            Id = System.Guid.NewGuid(),
                            LineNumber = 2,
                            Quantity = 20,
                            ProductCode = "GLOV1",
                            ProductDescription = "Tail Glove"
                        }
                    }
                });

                context.Orders.Add(new Order
                {
                    Id = System.Guid.NewGuid(),
                    OrderNumber = "PO112",
                    Buyer = "Skuirrels Inc",
                    Supplier = "Tails Corp",
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine
                        {
                            Id = System.Guid.NewGuid(),
                            LineNumber = 1,
                            Quantity = 5,
                            ProductCode = "SLIP1",
                            ProductDescription = "Slippers"
                        },
                        new OrderLine
                        {
                            Id = System.Guid.NewGuid(),
                            LineNumber = 2,
                            Quantity = 100,
                            ProductCode = "GLOV1",
                            ProductDescription = "Tail Glove"
                        }
                    }
                });

                context.Orders.Add(new Order
                {
                    Id = System.Guid.NewGuid(),
                    OrderNumber = "PO113",
                    Buyer = "Skuirrels Inc",
                    Supplier = "Tails Corp",
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine
                        {
                            Id = System.Guid.NewGuid(),
                            LineNumber = 1,
                            Quantity = 220,
                            ProductCode = "SLIP1",
                            ProductDescription = "Slippers"
                        },
                        new OrderLine
                        {
                            Id = System.Guid.NewGuid(),
                            LineNumber = 2,
                            Quantity = 55,
                            ProductCode = "GLOV1",
                            ProductDescription = "Tail Glove"
                        }
                    }
                });

                context.Orders.Add(new Order
                {
                    Id = System.Guid.NewGuid(),
                    OrderNumber = "PO114",
                    Buyer = "Skuirrels Inc",
                    Supplier = "Tails Corp",
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine
                        {
                            Id = System.Guid.NewGuid(),
                            LineNumber = 1,
                            Quantity = 5,
                            ProductCode = "SLIP1",
                            ProductDescription = "Slippers"
                        },
                        new OrderLine
                        {
                            Id = System.Guid.NewGuid(),
                            LineNumber = 2,
                            Quantity = 70,
                            ProductCode = "GLOV1",
                            ProductDescription = "Tail Glove"
                        }
                    }
                });
            }

            context.SaveChanges();
        }
    }
}
