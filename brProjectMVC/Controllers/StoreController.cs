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
            return Json(products.Select(s => new { s.Id, s.Name, s.Price }), JsonRequestBehavior.AllowGet);
        }
        public ViewResult SaveCategory()
        {
            ViewBag.categories = repositoryCategory.CategoryGetAll();

            return View();
        }
        [HttpPost]
        public JsonResult SaveCategory(Category item)
        {
            bool saved = false;
            saved = repositoryCategory.SaveOrUpdate(item) == 1 ? true : false;
            return Json(saved, JsonRequestBehavior.AllowGet);
        }
        public ViewResult SaveProduct()
        {
            ViewBag.categories = repositoryCategory.CategoryGetAll();

            return View();
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