using eTicaretProje.Areas.Admin.Models;
using eTicaretProje;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectMVC.Areas.Admin.Controllers
{ /*[Authorize(Roles ="yonetici")]*/
    public class SliderController : Controller
    {
        // GET: Admin/Slider
        projectMVCDBEntities Db = new projectMVCDBEntities();
        public string home() { return "m"; }
        public ActionResult Index()
        {
            var model = Db.SLIDER.OrderBy(x => x.SliderID).ToList();
            return View(model);
        }
        public ActionResult Ekle()
        {
            return View();
        }
        const string imageFolderPath = "/Content/img/slider";
        public ActionResult EkleSlider(SliderModel model)
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
                SLIDER slider = new SLIDER();
                slider.BaslangicTarihi = model.BaslangicTarihi;
                slider.BitisTarihi = model.BitisTarihi;
                slider.SliderText = model.SliderText;
                slider.ResimYolu = imageFolderPath + fileName;
                Db.SLIDER.Add(slider);
                Db.SaveChanges();
            }

            return RedirectToAction("slider");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = Db.SLIDER.Find(id);

            return View(model);
        }
        [HttpGet]
        public ActionResult DeleteConfirm(int id)
        {
            var model = Db.SLIDER.Find(id);
            Db.SLIDER.Remove(model);
            Db.SaveChanges();
            return RedirectToAction("Slider");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = Db.SLIDER.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(SLIDER model)
        {

            if (ModelState.IsValid)
            {
                var bulunan = Db.SLIDER.Find(model.SliderID);
                TryUpdateModel(bulunan);

                Db.SaveChanges();
            }
            else
            {
                return View(model);
            }
            return RedirectToAction("Slider");

        }
    }
}