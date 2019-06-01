using stajprojesi.Models.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stajprojesi.Controllers
{
    
    public class MulakatController : Controller
    {
        stajProjesiEntities2 db = new stajProjesiEntities2();
        // GET: Mulakat
        public ActionResult Index()
        {
            ViewBag.Title = "Mülakat";
            var model = db.staj.ToList();

            return View(model);

        }
        [HttpGet]
        public ActionResult Yeni()
        {
            

            return View("Mülakat",new mulakat());

        }
        [HttpPost]
        public ActionResult Kaydet(mulakat mul)
        {

            if (mul.ogr_no == 0)
            {

                db.mulakat.Add(mul);
            }
            else
            {
                var yeniKom = db.mulakat.Find(mul.ogr_no);
                if (yeniKom == null)
                {
                    return HttpNotFound();
                }
                yeniKom.amire_davranis = mul.amire_davranis;
                yeniKom.devam= mul.devam;
                yeniKom.duzen = mul.duzen;
                yeniKom.caba = mul.caba;
                yeniKom.ekibe_davranis = mul.ekibe_davranis;
                yeniKom.icerik = mul.icerik;
                yeniKom.is_vaktinde_yapma = mul.is_vaktinde_yapma;
                yeniKom.mulakat1 = mul.mulakat1;
                yeniKom.proje = mul.proje;
                yeniKom.sunum = mul.sunum;


            }


            db.SaveChanges();


            return RedirectToAction("Mülakat");
        }
        public ActionResult Yeni(mulakat mulakat)
        {
            db.mulakat.Add(mulakat);
            db.SaveChanges();


            return View();

        }
        
        public ActionResult Mulak()
        {
            
           
           
          
           
            


            return View("Mülakat");

        }


    }
}