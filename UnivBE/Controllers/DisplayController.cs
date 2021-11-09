using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivBE.Filters;

namespace UnivBE.Controllers
{
    [MyLogFilter]
    public class DisplayController : Controller
    {
        // GET: Display
        public ActionResult Index()
        { // display students data from api
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}