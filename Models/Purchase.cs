// Purchase.cs (Model)
using System.ComponentModel.DataAnnotations;

public class Purchase
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Vendor is required.")]
    public string Vendor { get; set; }

    [Required(ErrorMessage = "Product name is required.")]
    [StringLength(50, ErrorMessage = "Product name cannot exceed 50 characters.")]
    public string ProductName { get; set; }

    // Other properties
}
