using eTicaretProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTicaretProje.Controllers
{
    public class BegendiklerimController : Controller
    {
        // GET: Begendiklerim
       
            projectMVCDBEntities db = new projectMVCDBEntities();
            Homemodel model = new Homemodel();
        // GET: begendiklerim
        //public ActionResult Begendiklerim(int id)
        //{
        //    model.AnaKategori = db.ANAKATEGORİ.ToList();
        //    model.Kategori = db.KATEGORILER.ToList();
        //    model.YeniUrunler = db.URUNLER.ToList();
        //    model.Marka = db.MARKALAR.ToList();
        //    model.FirsatUrunler = db.URUNLER.Where(x => x.urunID == id).ToList();
        //    model.OneCikanUrunler = db.URUNLER.OrderByDescending(x => x.BitisTarihi).ToList();
        //    model.Urunler = db.URUNLER.Where(x => x.urunID == id).ToList();
        //    return View(model);
        //}
        public ActionResult Begendiklerim()
        {
            model.Sepet = db.ALISVERISSEPETI.ToList();
            return View(model);
        }

        public ActionResult sil(int id)
        {
            var result = db.ALISVERISSEPETI.Find(id);
            db.ALISVERISSEPETI.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Sepet");
        }

    }
}