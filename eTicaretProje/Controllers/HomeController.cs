using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eTicaretProje.Models;


namespace eTicaretProje.Controllers
{
    [Language]
    public class HomeController : Controller
    {

        projectMVCDBEntities db = new projectMVCDBEntities();
        Homemodel model = new Homemodel();
        public ActionResult Index()
        {
            ViewBag.ANAKATEGORİ = new SelectList(db.ANAKATEGORİ.ToList(), "anakategoriID", "anakategoriAdi");
            model.AnaKategori = db.ANAKATEGORİ.ToList();
            model.Kategori = db.KATEGORILER.ToList();
            model.OneCikanUrunler = db.URUNLER.OrderByDescending(x => x.BitisTarihi).ToList();
            model.YeniUrunler = db.URUNLER.ToList();
            return View(model);
        }


        [ChildActionOnly]
        public ActionResult _slider()
        {
            // AnaSayfaDTO obj = new AnaSayfaDTO();
            //obj.resimler = db.RESIMLER.Where(x => (x.BasTarihi <= DateTime.Now && x.BitisTarihi > DateTime.Now)).ToList();
            //obj.resimler= db.RESIMLER.ToList();
            return View(db.SLIDER.ToList());
        }
        public ActionResult _slider2()
        {
            // AnaSayfaDTO obj = new AnaSayfaDTO();
            //obj.resimler = db.RESIMLER.Where(x => (x.BasTarihi <= DateTime.Now && x.BitisTarihi > DateTime.Now)).ToList();
            //obj.resimler= db.RESIMLER.ToList();
            return View(db.SLIDER.ToList());
        }

        [ChildActionOnly]
        public ActionResult banner()
        {

            return View(db.MARKALAR.ToList());
        }
        [HttpPost]
        public ActionResult Index(KategoriAramaModel arama)
        {
            var sorgu = db.ANAKATEGORİ.AsQueryable();
            if (!string.IsNullOrEmpty(arama.anakategoriAdi))
            {
                sorgu = sorgu.Where(x => x.anakategoriAdi.Contains(arama.anakategoriAdi));

            }
            if (arama.anakategori > 0)
            {
                sorgu = sorgu.Where(x => x.anakategoriID == arama.anakategori);

            }

            ViewBag.ANAKATEGORİ = new SelectList(db.ANAKATEGORİ.ToList(), "anakategoriID", "anakategoriAdi");
            var model = sorgu.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }



        public ActionResult Contact()
        {


            return View();
        }
    
        public ActionResult iletisim()
        {


            return View();
        }

        public ActionResult kayitol()
        {


            return View();
        }




    }
}