using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public  class ServicioLogicaNegocio
    {
        private static ServicioAccesoDatos obj = new ServicioAccesoDatos();

        public static void RegistrarServicio(Servicios servicio)// se registra un nuevo servicio en el Lava Car
        {
            obj.RegistrarServicio(servicio);
        }

        public static List<Servicios> ListarServicios()// se enlistan todos los servicios en el LavaCar
        {
            return obj.ListarServicios();
        }

    }
}
