//// PurchasesController.cs
//using Microsoft.AspNetCore.Mvc;
//using ThetaShop.Models;

//public class PurchasesController : Controller
//{
//    private readonly theta2023dbContext _context;

//    public PurchasesController(theta2023dbContext context)
//    {
//        _context = context;
//    }

//    [HttpPost]
//    public IActionResult Create(Purchase purchase)
//    {
//        // Update stock logic
//        _context.Stock.FirstOrDefault(s => s.ProductId == purchase.Id).Quantity += purchase.Quantity;
//        _context.SaveChanges();

//        // Send email notification logic
//        EmailService.SendEmail("admin@example.com", "New Purchase Made", $"New purchase of  {purchase.ProductName}.");

//        return RedirectToAction("Index");
//    }
//}


