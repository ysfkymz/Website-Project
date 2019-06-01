using stajprojesi.Models.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stajprojesi.Controllers
{
    public class StajController : Controller
    {
        stajProjesiEntities2 db = new stajProjesiEntities2();
        // GET: Staj
        public ActionResult Index()
        {
            ViewBag.Title = "Staj";
            var model = db.staj.ToList();

            return View(model);
        }
    }
}