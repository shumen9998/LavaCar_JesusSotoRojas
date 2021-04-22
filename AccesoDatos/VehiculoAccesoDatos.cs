using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class VehiculoAccesoDatos
    {
        public void RegistrarVehiculo(Vehiculo vehiculo) {

            using (var db = new masterDBContext()) { //Registrar un Vehiculo
                db.Vehiculo.Add(vehiculo);
                db.SaveChanges();

                //Para guardar los servicios de cada vehiculo

                //int idGuardado = vehiculo.ID_Vehiculo;
                //  foreach (var x in ListaServiciosElegidos)
                //  {
                //      Vehiculo_Servicio datos =  new  Vehiculo_Servicio();
                //      datos.Id_Servicio = x.Id_Servicio;
                //      datos.Id_Vehiculo = idGuardado;
                //      db.Vehiculo_Servicio.add(datos)
                //  }

                //Termina de guardar los datos 
            }
        }
        public List<Vehiculo> ListarVehiculos(){ //consultar todos los vehiculos
            using (var db = new masterDBContext()) {
                return db.Vehiculo.ToList();
            }    
        }
        public List<Vehiculo> BuscarVehiculosPorServicio(int id){// Se buscan los vehiculos con un servicio de lavacar en especifico

            using (var db = new masterDBContext()) {
                var VehiculoConEseServicio = db.Vehiculo_Servicio.Where(d => d.ID_Servicio == id).ToList();
                List <Vehiculo> devolverVehiculo = new List<Vehiculo>();
                foreach (Vehiculo_Servicio x in VehiculoConEseServicio) {
                    var encontrado = db.Vehiculo.Where(j => j.ID_Vehiculo == x.ID_Vehiculo).FirstOrDefault();
                    if (encontrado != null) {
                        devolverVehiculo.Add(encontrado);
                    }
                }
                return devolverVehiculo;
            }
        }
    }
}
