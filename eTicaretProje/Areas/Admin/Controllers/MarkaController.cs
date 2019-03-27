using eTicaretProje;
using eTicaretProje.Areas.Admin.Models;
using projectMVC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectMVC.Areas.Admin.Controllers
{
    public class MarkaController : Controller
    {
        projectMVCDBEntities Db = new projectMVCDBEntities();
        // GET: Admin/Marka
        public ActionResult markaListele()
        {
            return View(Db.MARKALAR.ToList());
        }
        public ActionResult markaEkle()
        {
            return View();
        }
        const string imageFolderPath = "/Areas/Admin/Content/images/";
        public ActionResult EkleMarka(MarkaModel model)
        {
            string fileName = string.Empty;
            if (ModelState.IsValid)
            {
                //Dosya Kaydetme
                if (model.Resim.ContentLength > 0)
                {
                    fileName = model.Resim.FileName;
                    var path = Path.Combine(Server.MapPath("~" + imageFolderPath), fileName);
                    model.Resim.SaveAs(path);
                }
                //Entity F. nesnesi oluşturma
                MARKALAR marka = new MARKALAR();
                marka.markaAdi = model.markaAdi;
                marka.MarkaResimYol = imageFolderPath + fileName;
                Db.MARKALAR.Add(marka);
                Db.SaveChanges();
            }

            return RedirectToAction("markaListele");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = Db.MARKALAR.Find(id);

            return View(model);
        }
        [HttpGet]
        public ActionResult DeleteConfirm(int id)
        {
            var model = Db.MARKALAR.Find(id);
            Db.MARKALAR.Remove(model);
            Db.SaveChanges();
            return RedirectToAction("markaListele");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = Db.MARKALAR.Find(id);

            return View(model);
        }
        [HttpPost]
        public ActionResult markaEdit(MARKALAR model)
        {

            if (ModelState.IsValid)
            {
                var bulunan = Db.MARKALAR.Find(model.markaID);
                TryUpdateModel(bulunan);

                Db.SaveChanges();
            }
            else
            {
                return View(model);
            }
            return RedirectToAction("markaListele");
        }
    }



}