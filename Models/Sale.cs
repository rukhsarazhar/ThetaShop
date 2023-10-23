using System;
using System.ComponentModel.DataAnnotations;

public class SalesFlow
{
    public int Id { get; set; }

    // Customer properties
    [Required]
    [MaxLength(50)]
    public string CustomerName { get; set; }

    [MaxLength(100)]
    public string CustomerEmail { get; set; }

    // Sale properties
    [Required]
    public int ItemId
    { // You need an Item model for this
        get;
        set;
    }

    public DateTime SaleDate { get; set; }

    // SaleHistory properties
    public DateTime SaleHistoryDate { get; set; }

    // Other properties as needed
}
