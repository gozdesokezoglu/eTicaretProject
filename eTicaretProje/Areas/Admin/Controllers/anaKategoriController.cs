using eTicaretProje.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTicaretProje.Areas.Admin.Controllers
{
    public class anaKategoriController : Controller
    {
        

        projectMVCDBEntities Db = new projectMVCDBEntities();
        // GET: Admin/anaKategori
        public ActionResult AnaKategoriListele()
        {
            return View(Db.ANAKATEGORİ.ToList());
        }
        public ActionResult AnaKategoriEkle()
        {
            return View();
        }

        public ActionResult EkleAnaKategori(AnaKategoriModel model)
        {
            if (ModelState.IsValid)
            {
                //Entity F. nesnesi oluşturma
                ANAKATEGORİ akategori = new ANAKATEGORİ();
                akategori.anakategoriID = model.anakategoriID;
                akategori.anakategoriAdi = model.anakategoriAdi;
                Db.ANAKATEGORİ.Add(akategori);
                Db.SaveChanges();
            }

            return RedirectToAction("AnaKategoriListele");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = Db.ANAKATEGORİ.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditAnaKategori(ANAKATEGORİ model)
        {

            if (ModelState.IsValid)
            {
                var bulunan = Db.ANAKATEGORİ.Find(model.anakategoriID);
                TryUpdateModel(bulunan);
                Db.SaveChanges();
            }
            else
            {
                return View(model);
            }
            return RedirectToAction("AnaKategoriListele");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {

            var model = Db.ANAKATEGORİ.Find(id);

            return View(model);
        }
        [HttpGet]
        public ActionResult DeleteConfirm(int id)
        {
            var model = Db.ANAKATEGORİ.Find(id);
            Db.ANAKATEGORİ.Remove(model);
            Db.SaveChanges();
            return RedirectToAction("AnaKategoriListele");
        }
    }
}