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
        
        public ActionResult Guardar()
        {
            ViewBag.mensaje = "";
            return View();
        }

        public ActionResult Nuevo(equipo modelo)
        {
            admin.Guardar(modelo);
            ViewBag.mensaje = "Nuevo equipo agregado.";
            return View("Guardar", modelo);
        }

        public ActionResult Detalles(int id=0)
        {
            equipo modelo = admin.Consultar(id);
            ViewBag.mensaje = "";
            return View(modelo);
        }

        public ActionResult Modificar(int id = 0)
        {
            equipo modelo = admin.Consultar(id);
            return View(modelo);
        }

        public ActionResult Actualizar(equipo modelo)
        {
            admin.Modificar(modelo);
            ViewBag.mensaje = "Se ha modificado correctamente.";
            return View("Modificar", modelo);
        }

        public ActionResult Eliminar(int id = 0)
        {
            equipo modelo = new equipo()
            {
                idEquipo = id
            };
            admin.Eliminar(modelo);
            IEnumerable<equipo> lista = admin.Consultar();
            ViewBag.mensaje = "Se ha eliminado una casa";
            return View("Index", lista);
        }

        public ActionResult Disponibles()
        {
            IEnumerable<equipo> lista = admin.Consultar();
            ViewBag.mensaje = "";
            return View(lista);
        }

        public ActionResult DetallesDisponibles(int id = 0)
        {
            equipo modelo = admin.Consultar(id);
            ViewBag.mensaje = "";
            return View(modelo);
        }
    }
}