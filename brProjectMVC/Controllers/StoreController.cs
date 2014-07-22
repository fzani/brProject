using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace brProjectMVC.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Product()
        {
            throw new NotImplementedException();
        }

        public ViewResult Categories()
        {
            throw new NotImplementedException();
        }
    }
}