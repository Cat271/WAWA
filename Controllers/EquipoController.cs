using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAWA.Dato;
using WAWA.Models;

namespace WAWA.Controllers
{
    public class EquipoController : Controller
    {
        EquipoAdmin admin = new EquipoAdmin();
        // GET: Equipo
        public ActionResult Index()
        {
            IEnumerable<equipo> lista = admin.Consultar();
            ViewBag.mensaje = "";
            return View(lista);
        }
    }
}