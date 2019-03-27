using eTicaretProje.Areas.Admin.Models;
using eTicaretProje;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectMVC.Areas.Admin.Controllers
{
    public class UrunlerController : Controller
    {
        projectMVCDBEntities Db = new projectMVCDBEntities();
        // GET: Admin/Urunler
        public ActionResult urunListele()
        {
            var model = Db.URUNLER.OrderByDescending(x => x.urunID).ToList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = Db.URUNLER.Find(id);

            return View(model);
        }
        [HttpGet]
        public ActionResult DeleteConfirm(int id)
        {
            var model = Db.URUNLER.Find(id);
            Db.URUNLER.Remove(model);
            Db.SaveChanges();
            return RedirectToAction("urunListele");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = Db.URUNLER.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditUrunler(URUNLER model)
        {
            if (ModelState.IsValid)
            {
                var bulunan = Db.URUNLER.Find(model.urunID);
                TryUpdateModel(bulunan);

                Db.SaveChanges();
            }
            else
            {
                return View(model);
            }

            return RedirectToAction("urunListele");
        }
        public ActionResult urunEkle()
        {
            return View();
        }
        const string imageFolderPath = "/Content/img/product";
        public ActionResult EkleUrun(UrunModel model)
        {
            //    string fileName = string.Empty;
            if (ModelState.IsValid)
            {
                //        //Dosya Kaydetme
                //        if (model.Resim1.ContentLength > 0)
                //        {
                //            fileName = model.Resim1.FileName;
                //            var path = Path.Combine(Server.MapPath("~" + imageFolderPath), fileName);
                //            model.Resim1.SaveAs(path);
                //        }
                //Entity F. nesnesi oluşturma
                URUNLER urun = new URUNLER();
                urun.urunID = model.urunID;
                urun.UrunAdi = model.urunAdi;
                urun.urunAciklama = model.urunAciklama;
                urun.urunAlisFiyati = model.urunAlisFiyati;
                urun.urunFiyat = model.urunFiyat;
                urun.BaslangicTarihi = model.BaslangicTarihi;
                urun.BitisTarihi = model.BitisTarihi;
                urun.urunResimYol = model.urunResimYol;
                Db.URUNLER.Add(urun);
                Db.SaveChanges();
            }

            return RedirectToAction("urunListele");
        }


    }
}