using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class VehiculosController : Controller
    {
        // GET: Vehiculos
        public ActionResult Index()
        {
            var vehiculos = VehiculoLogicaNegocio.ListarVehiculos();
            return View(vehiculos);
        }

        public ActionResult BuscarVehiculosPorServicio(int id, string name)
        {
            var devolverVehiculo = VehiculoLogicaNegocio.BuscarVehiculosPorServicio(id);
            ViewBag.Nombre = name;
            return View(devolverVehiculo);
        }

        
        public ActionResult RegistrarVehiculo() {
            List<Servicios> serviciosLista = new List<Servicios>();
            ServiciosController serviciosListaData = new ServiciosController();
            serviciosLista = serviciosListaData.ListaServiciosExistentes();
            ViewBag.Servicios = serviciosLista;
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                VehiculoLogicaNegocio.RegistrarVehiculo(vehiculo);
                return RedirectToAction("Index");
            }
            catch (Exception x)
            {

                ModelState.AddModelError("", "Se ha producido un error para registrar un vehículo");
                return View(vehiculo);
            }
          
        }

       
    }
}