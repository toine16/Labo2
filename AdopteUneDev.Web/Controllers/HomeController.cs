using AdopteUneDev.DbTools;
using AdopteUneDev.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdopteUneDev.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public void GetTop6Dev()
        {
            UnitOfWork unit = new UnitOfWork();
            unit.DeveloppeurRepository.GetAll(new Models.Global.Developpeur());
           // unit.DeveloppeurRepository.MapTtoDico

        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}