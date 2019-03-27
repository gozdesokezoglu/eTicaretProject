using eTicaretProje.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTicaretProje.Controllers
{
    public class SepetimController : Controller
    {
        // GET: Sepetim
        projectMVCDBEntities db = new projectMVCDBEntities();
        Homemodel model = new Homemodel();
        public ActionResult sepetim()
        {
            model.Sepet = db.ALISVERISSEPETI.ToList();
            return View(model);
        }

        [HttpGet]
        public ActionResult sil(int id)
        {
            var snc = db.ALISVERISSEPETI.Find(id);
            db.ALISVERISSEPETI.Remove(snc);
            db.SaveChanges();
            return RedirectToAction("sepetim");
        }
      
    }
}