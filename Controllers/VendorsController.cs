// VendorsController.cs
using Microsoft.AspNetCore.Mvc;
using ThetaShop.Models;

public class VendorsController : Controller
{
    private readonly theta2023dbContext _context;

    public VendorsController(theta2023dbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var vendors = _context.Purchase.ToList();
        return View(vendors);
    }

    // Implement Create, Read, Update, and Delete actions here
}
