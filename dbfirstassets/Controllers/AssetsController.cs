using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dbfirstassets.Models;

namespace dbfirstassets.Controllers
{
    public class AssetsController : Controller
    {
        // GET: Assets
        dbnitEntities _dbnitEntities = new dbnitEntities(); // bad practice
        public ActionResult Index()
        {
            var x = from data in _dbnitEntities.Assets
                    select data; // LINQ
            return View(x.ToList());
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Asset asset)
        {
            _dbnitEntities.Assets.Add(asset);
            _dbnitEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}