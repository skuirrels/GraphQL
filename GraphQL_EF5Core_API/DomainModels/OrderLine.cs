using System;
using System.ComponentModel.DataAnnotations;

namespace GraphQL_EF5Core_API.DomainModels
{
    public class OrderLine
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public int LineNumber { get; set; }
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public Int64? Quantity { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}