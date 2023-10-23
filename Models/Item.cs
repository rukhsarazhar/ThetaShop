using System;
using System.Collections.Generic;

namespace ThetaShop.Models
{
    public partial class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string? Images { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; } 
        public decimal? DiscountAmount { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
