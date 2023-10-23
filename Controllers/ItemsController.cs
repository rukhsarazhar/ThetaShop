using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using ThetaShop.Models;

namespace ThetaShop.Controllers
{
    public class ItemsController : Controller
    {
        private theta2023dbContext EF = null;
        private IWebHostEnvironment Env = null;
        public ItemsController(theta2023dbContext _EF, IWebHostEnvironment _Env)
        {
            EF = _EF;
            Env = _Env;
        }
        

    //private Item _item; // Assume you have an instance of the Item model.

    //    [HttpPost]
    //    public ActionResult SellItem(int quantitySold)
    //    {
    //        _item.Sell(quantitySold);
    //        // Save changes to the database if necessary.

    //        // Return updated item data to the AJAX success callback
    //        return Json(new { QuantityInStock = _item.Quantity });
    //    }
    
    public IActionResult Index()
        {
            return View(EF.Items.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Item I, IList<IFormFile> IImages)
        {
            string PathForDatabase = "";
            if (IImages.Count != 0)
            {

                foreach (IFormFile IImage in IImages)
                {

                    string UniqueFileName = "/data/items/" + Guid.NewGuid().ToString() + Path.GetExtension(IImage.FileName);
                    string FinalAbsolutePath = Env.WebRootPath + UniqueFileName;
                    FileStream FS = new FileStream(FinalAbsolutePath, FileMode.Create);
                    IImage.CopyTo(FS);
                    FS.Close();

                    PathForDatabase += (UniqueFileName + ",");
                }
            }
           


            if (PathForDatabase.Contains(","))
            {
                int index = PathForDatabase.LastIndexOf(",");
                PathForDatabase = PathForDatabase.Remove(index, 1);


                I.Images = PathForDatabase;
            }

            EF.Items.Add(I);
            EF.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Detail(int id)
        {
            Item I = EF.Items.Find(id);
            return View(I);
        }

    }
}