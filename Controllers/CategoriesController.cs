using Microsoft.AspNetCore.Mvc;
using ThetaShop.Models;

namespace ThetaShop.Controllers
{
    public class CategoriesController : Controller
    {
        theta2023dbContext EF = null;
        IWebHostEnvironment Env = null;
        public CategoriesController(theta2023dbContext _EF, IWebHostEnvironment _Env)
        {
            EF = _EF;
            Env = _Env;

        }


        [HttpGet]
        public IActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category C, IFormFile CPicture) /*IFormFile CCatalogue, IFormFile EduDegree*/
        {
            try
            {
                string FinalFileName = "";
                if (CPicture != null)
                {
                    string UniqueName = Guid.NewGuid().ToString();
                    string FileName = CPicture.FileName;
                    //System.IO.File.
                    string Ext = Path.GetExtension(CPicture.FileName);
                    FinalFileName = UniqueName + Ext;
                    string wwwRootPath = Env.WebRootPath;
                    FileStream fs = new FileStream(wwwRootPath + "/data/categories/" + FinalFileName, FileMode.Create);
                    CPicture.CopyTo(fs);
                    fs.Close();


                    //using (FileStream fs1 = new FileStream(wwwRootPath + "/data/categories/" + FinalFileName, FileMode.Create))
                    //{
                    //    CImage.CopyTo(fs1);
                    //    fs.Close();
                    //}


                }

                C.Picture = "/data/categories/" + FinalFileName;
                ViewBag.Message = "Category is saved successfully";
                
                EF.Categories.Add(C);
                EF.SaveChanges();



                return RedirectToAction("Index");



            }
            catch
            {
                ViewBag.Message = "Error in saving category";
            }



            return View();
        }



        //public IActionResult DC(string P)
        //{
        //    //if (System.IO.File.Exists(Env.WebRootPath+ P))
        //    //{
        //    return File(P, "application/pdf");
        //    //}
        //    //return null;
        //}

        //public IActionResult Delete(int id)
        //{
        //    Category C = EF.Categories.Find(id);

        //    if (C != null)
        //    {
        //        using (var T = EF.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                EF.Categories.Remove(C);
        //                EF.SaveChanges();
        //                //send email

        //                Category C2 = new Category();
        //                C2.CategoryId = 3;
        //                C2.CategoryName = "adf";                      
        //                EF.Categories.Add(C2);
        //                EF.SaveChanges();




        //                T.Commit();
        //                ViewBag.Message = "Operation completed.";
        //            }
        //            catch
        //            {
        //                T.Rollback();
        //                ViewBag.Message = "Error occured.";
        //            }



        //        }
        //    }








        //    return RedirectToAction("Index");
        //}


        [HttpGet]
        public IActionResult Edit(int id)
        {
            Category C = EF.Categories.Find(id);
            return View(C);
        }


        [HttpPost]
        public IActionResult Edit(Category C)
        {
            EF.Categories.Update(C);
            EF.SaveChanges();
            return RedirectToAction("Index");
        }



        public IActionResult Detail(int id)
        {
            Category C = EF.Categories.Find(id);
            return View(C);
        }



        public IActionResult Index()
        {

            IList<Category> AllCategories = EF.Categories.ToList<Category>();
           

            return View(AllCategories);
        }





        public string DeleteAjax(int id)
        {
            try
            {
                EF.Categories.Remove(EF.Categories.Find(id));
                EF.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return "0";
            }


        }

        public string GetCategoriesCount()
        {
            
            return EF.Categories.Count().ToString();
        }



        public string GetTable()
        {
            return "<table class='table table-bordered'><tr><td>Test1</td><td>Test1</td><td>Test1</td></tr></table>";
        }



    }
}