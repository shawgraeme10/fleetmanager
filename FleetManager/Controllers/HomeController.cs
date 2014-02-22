using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FleetManager.Models;
using FleetManager.Databases;

namespace FleetManager.Controllers
{
    public class HomeController : Controller
    {
        private FleetContext db = new FleetContext();

        public ActionResult Index()
        {
            ViewBag.Message = "Fleet Manager";

            return View(db.vehicles.ToList());
        }

        
    }
}
