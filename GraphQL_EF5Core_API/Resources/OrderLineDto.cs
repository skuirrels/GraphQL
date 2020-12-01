using System;
using System.ComponentModel.DataAnnotations;

namespace GraphQL_EF5Core_API.Resources
{
    public class OrderLineDto
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
    }
}