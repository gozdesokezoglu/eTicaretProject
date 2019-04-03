using eTicaretProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTicaretProje.Controllers
{
    public class FavorilerController : Controller
    {
        // GET: Favoriler
       
            projectMVCDBEntities db = new projectMVCDBEntities();
            Homemodel model = new Homemodel();
  
        public ActionResult favoriler()
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