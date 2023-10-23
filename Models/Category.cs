using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThetaShop.Models
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        [StringLength(10)]
        public string? Description { get; set; }
        
        public string? Picture { get; set; }
        public string? CategoryCode { get; set; }
        public string? DisplayOrder { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string? IsActive { get; set; }
        public int? AttachmentId { get; set; }
        public string? IsDeleted { get; set; }
    }
}
