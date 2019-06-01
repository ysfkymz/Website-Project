using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using stajprojesi.Models.EntitiyFramework;

namespace stajprojesi.Controllers
{
    public class KonuController : Controller
    {
        // GET: Konu

        stajProjesiEntities2 db = new stajProjesiEntities2();

        public ActionResult Index(string konuadi)
        {
            ViewBag.Title = "Konu";
            var model = db.konular.ToList();

            return View(model);
        }
        [HttpGet]
        public ActionResult Ekle()
        {

            return View("Konuduzen",new konular());
        }
        [HttpPost]
        public ActionResult Kaydet(konular konad)
        {
            if(!ModelState.IsValid)
            {
                return View("Konuduzen");
            }
            if(konad.id==0)
            {
               
                db.konular.Add(konad);
            }
            else
            {
                var yeniKonu = db.konular.Find(konad.id);
                if(yeniKonu==null)
                {
                    return HttpNotFound();
                }
                yeniKonu.konuad = konad.konuad;


            }
            
            
            db.SaveChanges();


            return RedirectToAction("Index", "Konu");
        }
        public ActionResult Guncelle(int id)
        {
            
            var model = db.konular.Find(id);
            if (model == null)
                return HttpNotFound();
           
          

            return View("Konuduzen",model);
        }
        public ActionResult Sil(int id)
        {
            var silkonu = db.konular.Find(id);
            if (silkonu == null)
                return HttpNotFound();
            db.konular.Remove(silkonu);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}