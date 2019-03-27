using eTicaretProje.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTicaretProje.Areas.Admin.Controllers
{
    public class KategoriController : Controller
    {
        projectMVCDBEntities Db = new projectMVCDBEntities();

        // GET: Admin/Kategori
        public ActionResult kategoriListele()
        {
            return View(Db.KATEGORILER.ToList());
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {

            var model = Db.KATEGORILER.Find(id);

            return View(model);
        }
        [HttpGet]
        public ActionResult DeleteConfirm(int id)
        {
            var model = Db.KATEGORILER.Find(id);
            Db.KATEGORILER.Remove(model);
            Db.SaveChanges();
            return RedirectToAction("kategoriListele");
        }


        public ActionResult Edit(KATEGORILER model)
        {

            if (ModelState.IsValid)
            {
                Db.KATEGORILER.Attach(model);
                Db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                Db.SaveChanges();
            }
            else
            {
                return View(model);
            }
            return RedirectToAction("kategoriListele");
        }
        public ActionResult kategoriEkle()
        {
            return View();
        }
        public ActionResult EkleKategori(KategoriModel model)
        {
            if (ModelState.IsValid)
            {

                //Entity F. nesnesi oluşturma
                KATEGORILER kategori = new KATEGORILER();
                kategori.kategoriAdi = model.kategoriAdi;
                kategori.anaKategoriID = model.anaKategoriID;
                Db.KATEGORILER.Add(kategori);
                Db.SaveChanges();
            }

            return RedirectToAction("kategoriListele");
        }
    
}
}