using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ServicioAccesoDatos
    {
        public void RegistrarServicio(Servicios servicio)
        {

            using (var db = new masterDBContext())
            { //Registrar un Vehiculo
                db.Servicios.Add(servicio);
                db.SaveChanges();
            }
        }
        public List<Servicios> ListarServicios()
        { //consultar todos los 
            using (var db = new masterDBContext())
            {
                return db.Servicios.ToList();
            }
        }
    }
}
