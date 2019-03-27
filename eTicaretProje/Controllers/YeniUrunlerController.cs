using eTicaretProje.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTicaretProje.Controllers
{
    public class YeniUrunlerController : Controller
    {
        projectMVCDBEntities db = new projectMVCDBEntities();
        Homemodel model = new Homemodel();
        // GET: Urunler
        public ActionResult yeniurun()
        {

            //yeni.resimler = db.RESIMLER.Where(x => (x.BasTarihi <= DateTime.Now && x.BitisTarihi > DateTime.Now)).ToList();
            model.AnaKategori = db.ANAKATEGORİ.ToList();
            model.Kategori = db.KATEGORILER.ToList();
            model.Urunler = db.URUNLER.ToList();
            model.FirsatUrunler = db.URUNLER.OrderBy(x => x.urunFiyat).Take(5).ToList();

            return View(model);
        }
        public ActionResult kategoriListele(int id)
        {
            model.AnaKategori = db.ANAKATEGORİ.ToList();
            model.Kategori = db.KATEGORILER.ToList();
            model.FirsatUrunler = db.URUNLER.OrderBy(x => x.urunFiyat).Take(5).ToList();

            model.kategoriUrunler = db.URUNLER.Where(x => x.KATEGORILER.kategoriID == id).ToList();

            return View(model);


        }
        //public ActionResult kategoriListele(string id)
        //{
        //    bool durum = false; bool state = false;
        //    model.Kategori = db.KATEGORILER.ToList();
        //    model.AnaKategori = db.ANAKATEGORİ.ToList();
        //    model.Marka = db.MARKALAR.ToList();
        //    model.Sepet = db.ALISVERISSEPETI.ToList();
        //    foreach (var item in db.MARKALAR)
        //    {
        //        if (id == item.markaAdi)
        //        {
        //            state = true;
        //        }
        //    }
        //    if (state == true)
        //    {
        //        model.Urunler = db.URUNLER.Where(x => x.MARKALAR.markaAdi == id).ToList();
        //    }
        //    else
        //    {
        //        if (id == null)
        //        {
        //            model.Urunler = db.URUNLER.ToList();
        //        }
        //        else
        //        {
        //            foreach (var item in db.URUNLER)
        //            {
        //                if (id == item.KATEGORILER.ANAKATEGORİ.anakategoriAdi)
        //                {
        //                    durum = true;
        //                }
        //            }
        //            if (durum == true)
        //                model.Urunler = db.URUNLER.Where(x => x.KATEGORILER.ANAKATEGORİ.anakategoriAdi == id).ToList();
        //            else
        //                model.Urunler = db.URUNLER.Where(x => x.KATEGORILER.kategoriAdi == id).ToList();

        //        }
        //    }


        //    return View(model);
        //}
        public ActionResult SepeteEkle(int ID)
        {
            if (ModelState.IsValid)
            {
                var result = db.URUNLER.Find(ID);
                ALISVERISSEPETI a1 = new ALISVERISSEPETI();
                a1.urunID = ID;
                //var son= db.AspNetUsers.Find(Kayit.mail);
                a1.kullaniciID = User.Identity.GetUserId();
                //a1.userID = User.Identity.Name;
                db.ALISVERISSEPETI.Add(a1);
                db.SaveChanges();
            }
            return RedirectToAction("sepetim", "Sepetim");
        }
        public ActionResult firsaturun()
        {
            model.AnaKategori = db.ANAKATEGORİ.ToList();
            model.Kategori = db.KATEGORILER.ToList();
            model.YeniUrunler = db.URUNLER.ToList();
            model.Urunler = db.URUNLER.ToList();
            model.Marka = db.MARKALAR.ToList();
            model.FirsatUrunler = db.URUNLER.OrderBy(x => x.urunFiyat).Take(3).ToList();
            model.OneCikanUrunler = db.URUNLER.OrderByDescending(x => x.BitisTarihi).ToList();

            return View(model);
        }
        public ActionResult urunList()
        {
            model.AnaKategori = db.ANAKATEGORİ.ToList();
            model.Kategori = db.KATEGORILER.ToList();
            model.YeniUrunler = db.URUNLER.ToList();
            model.Urunler = db.URUNLER.ToList();
            model.Marka = db.MARKALAR.ToList();
            model.FirsatUrunler = db.URUNLER.OrderBy(x => x.urunFiyat).Take(3).ToList();
            model.OneCikanUrunler = db.URUNLER.OrderByDescending(x => x.BitisTarihi).ToList();

            return View(model);
        }

    }
}