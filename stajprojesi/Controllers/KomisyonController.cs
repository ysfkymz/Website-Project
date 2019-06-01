using stajprojesi.Models.EntitiyFramework;
using stajprojesi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace stajprojesi.Controllers
{
    public class KomisyonController : Controller
    {
        stajProjesiEntities2 db = new stajProjesiEntities2();
        // GET: Komisyon
        public ActionResult Index()
        {
            ViewBag.Title = "Komisyon";
            var model = db.komisyon.ToList();
            var asd= db.komisyon.ToList();

            return View(model);
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            

            return View("KomisyonForm", new komisyon());
        }
        [HttpPost]
        public ActionResult Kaydet(komisyon kom)
        {
         
            if (kom.id == 0)
            {

                db.komisyon.Add(kom);
            }
            else
            {
                var yeniKom = db.komisyon.Find(kom.id);
                if (yeniKom == null)
                {
                    return HttpNotFound();
                }
                yeniKom.unvan = kom.unvan;
                yeniKom.ad= kom.ad;
                yeniKom.soyad = kom.soyad;


            }


            db.SaveChanges();


            return RedirectToAction("Index", "Komisyon");
        }
        public ActionResult Guncelle(int id)
        {

            var model = db.komisyon.Find(id);
            if (model == null)
                return HttpNotFound();



            return View("KomisyonForm", model);

            
        }
        public ActionResult Sil(int id)
        {
            var silkonu = db.komisyon.Find(id);
            if (silkonu == null)
                return HttpNotFound();
            db.komisyon.Remove(silkonu);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Yenikomisyon()
        {
            var model = db.komisyon.ToList();

            return View(model);
        }
    }
}