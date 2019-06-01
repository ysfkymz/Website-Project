using stajprojesi.Models.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stajprojesi.Models;
using System.Web.UI;

namespace stajprojesi.Controllers
{
    public class OgrenciController : Controller
    {
        stajProjesiEntities2 db = new stajProjesiEntities2();
        // GET: Ogrenci
        public ActionResult Index()
        {
            ViewBag.Title = "Öğrenci";
            var model = db.staj.ToList();

            return View(model);
            
            
        }
        [HttpGet]
        public ActionResult Yeni()
        {




            return View();


        }
        [HttpPost]
        public ActionResult Yeni(staj ogr)
        {
            if(ogr.ogr_no==0 || ogr.ogr_no>=999999 || ogr.ogr_no<=100000)
            {
                
                TempData["msg"] = "<script>alert('Öğrenci numarasını doğru giriniz');</script>";
                return RedirectToAction("Yeni");

            }
            if(ogr.ogr_sinif==2 && ogr.gun>=25)
            {
                TempData["msg"] = "<script>alert('2.Sınıf bir öğrenci 25 günden fazla staj yapamaz!!! ');</script>";
                return RedirectToAction("Yeni");

            }
            if(ogr.staj_konu!="Arge" && ogr.gun>40)
            {
                TempData["msg"] = "<script>alert('Sadece Arge bölümünde olanlar, 40 günden fazla staj yapabilir!!!');</script>";
                return RedirectToAction("Yeni");

            }
            if(ogr.gun<15)
            {
                TempData["msg"] = "<script>alert('Staj 15 günden az olamaz!!!');</script>";
                return RedirectToAction("Yeni");
            }

            
            db.staj.Add(ogr);
            db.SaveChanges();


            return RedirectToAction("Yeni");


        }
        
        
       
        //public ActionResult Kaydet(staj ogr)
        //{

        //    if (ogr.ogr_no == 0)
        //    {

        //        db.staj.Add(ogr);
        //    }
        //    else
        //    {
        //        var yeniKom = db.staj.Find(ogr.ogr_no);
        //        if (yeniKom == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        yeniKom.ogr_no = ogr.ogr_no;
        //        yeniKom.bas_tarihi = ogr.bas_tarihi;
        //        yeniKom.ad = ogr.ad;
        //        yeniKom.soyad = ogr.soyad;


        //    }


        //    db.SaveChanges();


        //    return RedirectToAction("Index", "Ogrenci");
        //}
    }
}