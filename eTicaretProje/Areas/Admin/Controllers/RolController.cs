using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using eTicaretProje.Areas.Admin.Models;
using eTicaretProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eTicaretProje;

namespace projectMVC.Areas.Admin.Controllers
{
    public class RolController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Admin/Rol
        projectMVCDBEntities Db = new projectMVCDBEntities();
        public ActionResult RolEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RolEkle(RolEkleModel rol)
        {
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            if (roleManager.RoleExists(rol.RolAd) == false)
            {
                roleManager.Create(new IdentityRole(rol.RolAd));
            }

            return RedirectToAction("RolListele");
        }
        public ActionResult RolKullaniciEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RolKullaniciEkle(RolKullaniciEkleModel model)
        {
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            var kullanici = userManager.FindByName(model.KullaniciAdi);

            if (!userManager.IsInRole(kullanici.Id, model.RolAdi))
            {
                userManager.AddToRole(kullanici.Id, model.RolAdi);
            }

            return RedirectToAction("RolListele");
        }
        public ActionResult RolListele()
        {
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            var model = roleManager.Roles.ToList();
            //Yeni Rol Oluşturma => roleManager.Create(new IdentityRole("yonetici"));

            return View(model);
        }
        [HttpGet]
        public ActionResult Delete(String id)
        {
            var model = Db.AspNetRoles.Find(id);

            return View(model);
        }
        [HttpGet]
        public ActionResult DeleteConfirm(String id)
        {
            var model = Db.AspNetRoles.Find(id);
            Db.AspNetRoles.Remove(model);
            Db.SaveChanges();
            return RedirectToAction("RolListele");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = Db.AspNetRoles.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditRol(Rol model)
        {

            if (ModelState.IsValid)
            {
                var bulunan = Db.AspNetRoles.Find(model.Id);
                TryUpdateModel(bulunan);

                Db.SaveChanges();
            }
            else
            {
                return View(model);
            }
            return RedirectToAction("RolListele");

        }
    }

}