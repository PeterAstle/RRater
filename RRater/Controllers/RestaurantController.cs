using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RRater.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}