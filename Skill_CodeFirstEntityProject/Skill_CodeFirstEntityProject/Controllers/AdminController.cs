using Skill_CodeFirstEntityProject.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skill_CodeFirstEntityProject.Controllers
{
    public class AdminController : Controller
    {
        CONTEXT c = new CONTEXT();
        public ActionResult Index()
        {
            var degerler = c.YETENEKLERS.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {

            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(YETENEKLER y)
        {
            c.YETENEKLERS.Add(y);
            c.SaveChanges();
            return View();
        }

        public ActionResult YetenekSil(int id)
        {
            var deger = c.YETENEKLERS.Find(id);
            c.YETENEKLERS.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGuncelle(int id)
        {
            var deger = c.YETENEKLERS.Find(id);
            return View("YetenekGuncelle",deger);
        }

        [HttpPost]
        public ActionResult YetenekGuncelle(YETENEKLER y)
        {
            var x = c.YETENEKLERS.Find(y.ID);
            x.YetenekAciklama = y.YetenekAciklama;
            x.YetenekYüzdeDeger = y.YetenekYüzdeDeger;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}