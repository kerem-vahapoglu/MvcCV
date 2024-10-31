using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCV.Models.Entitiy;

namespace MvcCV.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        DB_CVEntities db = new DB_CVEntities();
        public ActionResult Index()
        {
            var degerler = db.tblHakkında.ToList();
            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = db.tblDeneyimler.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.tblEgitimler.ToList();
            return PartialView(egitimler);
        }

        public PartialViewResult Yetenkelerim()
        {
            var yetenekler = db.tblYetenekler.ToList();
            return PartialView(yetenekler);
        }

        public PartialViewResult Hobilerim()
        {
            var hobiler = db.tblHobiler.ToList();
            return PartialView(hobiler);
        }

        public PartialViewResult Sertifikalar()
        {
            var sertifikalar =db.tblSertifikalar.ToList();
            return PartialView(sertifikalar);   
        }
        [HttpGet]
        public PartialViewResult İletişim()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult İletişim(tblIletisim t)
        {
            t.Tarih=DateTime.Parse(DateTime.Now.ToShortDateString());
            db.tblIletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}