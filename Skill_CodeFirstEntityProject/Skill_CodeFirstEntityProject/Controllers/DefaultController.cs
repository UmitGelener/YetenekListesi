using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skill_CodeFirstEntityProject.Models.Siniflar;

namespace Skill_CodeFirstEntityProject.Controllers
{
    public class DefaultController : Controller
    {
        
        public ActionResult Index()
        {
            CONTEXT c = new CONTEXT();
            var degerler = c.YETENEKLERS.ToList();
            return View(degerler);
        }
    }
}