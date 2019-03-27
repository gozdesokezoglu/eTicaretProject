using eTicaretProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace  eTicaretProje.Controllers
{
    public class UrunDetayController : Controller
    {
        projectMVCDBEntities db = new projectMVCDBEntities();
        Homemodel model = new Homemodel();
        // GET: UrunDetay
        public ActionResult urunDetay(int id)
        {
            model.AnaKategori = db.ANAKATEGORİ.ToList();
            model.Kategori = db.KATEGORILER.ToList();
            model.YeniUrunler = db.URUNLER.ToList();
            model.Sepet = db.ALISVERISSEPETI.ToList();
            model.Marka = db.MARKALAR.ToList();
            model.FirsatUrunler = db.URUNLER.OrderBy(x => x.urunFiyat).Take(3).ToList();
            model.OneCikanUrunler = db.URUNLER.OrderByDescending(x => x.BitisTarihi).ToList();
            model.Urunler = db.URUNLER.Where(x => x.urunID == id).ToList();
            return View(model);
           
        }
    }
}