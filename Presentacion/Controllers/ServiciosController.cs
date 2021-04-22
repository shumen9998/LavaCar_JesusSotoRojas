using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class ServiciosController : Controller
    {
        // GET: Servicios
        public ActionResult Index()
        {
            var servicios = ServicioLogicaNegocio.ListarServicios();
            return View(servicios);
        }

        public List<Servicios> ListaServiciosExistentes()
        {
            var servicios = ServicioLogicaNegocio.ListarServicios();
            return servicios;
        }

        public ActionResult RegistrarServicio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarServicio(Servicios servicio)
        {
            try
            {
                ServicioLogicaNegocio.RegistrarServicio(servicio);
                return RedirectToAction("Index");
            }
            catch (Exception x)
            {
                ModelState.AddModelError("", "Se ha producido un error para registrar un vehículo");
                return View(servicio);
            }

        }
    }
}