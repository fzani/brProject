using brProject.Infraestructure;
using brProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace brProjectMVC.Controllers
{
    public class StoreController : Controller
    {
        protected readonly StoreRepository<Product> repositoryProduct;
        protected readonly StoreRepository<Category> repositoryCategory;
                
        public StoreController()
        {
            repositoryProduct = new StoreRepository<Product>();
            repositoryCategory = new StoreRepository<Category>();
        }

        //
        // GET: /Store/
        public ActionResult Index()
        {
            ViewBag.categories = repositoryCategory.CategoryGetAll();
            return View();
        }

        public ActionResult GetProduct(int id)
        {
            var products = repositoryProduct.ProductGetByCategory(id);
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveCategory(Category item)
        {
            bool saved = false;
            saved = repositoryCategory.SaveOrUpdate(item) == 1 ? true : false;
            return Json(saved, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveProduct(Product item)
        {
            bool saved = false;
            saved = repositoryProduct.SaveOrUpdate(item) == 1 ? true : false;
            return Json(saved, JsonRequestBehavior.AllowGet);
        }
    }
}