using eTicaretProje.Areas.Admin.Models;
using eTicaretProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTicaretProje.Areas.Admin.Controllers
{
    //[Authorize(Users = "sokezoglugozde@gmail.com")]
    public class AdminHomeController : Controller
    {
        // GET: Admin/Home
        ApplicationDbContext context = new ApplicationDbContext();
        projectMVCDBEntities db = new projectMVCDBEntities();
        AdminModel model = new AdminModel();
        // GET: Admin/Home
        public ActionResult Index()
        {
            model.Kategori = db.KATEGORILER.ToList();
            model.AnaKategori = db.ANAKATEGORİ.ToList();
            model.Urunler = db.URUNLER.ToList();
            model.sepet = db.ALISVERISSEPETI.ToList();
            model.FırsatUrunler = db.URUNLER.OrderBy(x => x.urunFiyat).Take(3).ToList();
            model.Users = db.AspNetUsers.ToList();
            //var rolStore = new RoleStore<IdentityRole>(context);
            //var roleManager = new RoleManager<IdentityRole>(rolStore);
            //_db.Kullanıcı = roleManager.Roles.ToList();
            return View(model);
        }
    }
}