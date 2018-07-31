using AdopteUneDev.API.Controllers;
using AdopteUneDev.DbTools;
using AdopteUneDev.Interface;
using AdopteUneDev.Models.Global;
using AdopteUneDev.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdopteUneDev.Web.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            APIController api = new APIController();
            ListDeveloppeurModelsClient client = new ListDeveloppeurModelsClient();
            client.Developpeurs = api.GetTop6Dev();

            return View(client);
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