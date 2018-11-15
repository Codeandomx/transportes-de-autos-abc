using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autotransportes_ABC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddAuto()
        {
            ViewBag.Message = "Agregamos un dato a la base de datos";

            return View();
        }

        public ActionResult AddSolicitud()
        {
            ViewBag.Message = "Agregamos una solicitud a la base de datos";

            return View();
        }

        public ActionResult Autos()
        {
            ViewBag.Message = "Your auto page.";

            return View();
        }

        public ActionResult Solicitudes()
        {
            ViewBag.Message = "Your solicitud page.";

            return View();
        }
    }
}