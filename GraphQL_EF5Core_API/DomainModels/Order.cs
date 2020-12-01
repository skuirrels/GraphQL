using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphQL_EF5Core_API.DomainModels
{
    public class Order
    {
        [Required]
        public Guid Id { get; init; }
        
        [Required, StringLength(50)]
        public string OrderNumber { get; set; }

        public OrderStatus Status { get; set; }
        
        [StringLength(50)]
        public string Buyer { get; set; }
        [StringLength(50)]
        public string Supplier { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; } = new HashSet<OrderLine>();
    }

    public enum OrderStatus
    {
        Cancelled =0,
        Provisional = 1,
        Confirmed = 10,
        Shipped = 20,
        Delivered = 30
    }
}