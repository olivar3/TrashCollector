using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class MyCollectionsController : Controller
    {
        // GET: MyCollections
        public ActionResult Account()
        {
            var collection = new Collection() { NumberThisMonth = 1 };
            return View();
        }
    }
}