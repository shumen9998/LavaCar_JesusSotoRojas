using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class VehiculoLogicaNegocio
    {
        private static VehiculoAccesoDatos obj = new VehiculoAccesoDatos();

        public static void RegistrarVehiculo(Vehiculo vehiculo)
        {
            obj.RegistrarVehiculo(vehiculo);
        }

        public static List<Vehiculo> BuscarVehiculosPorServicio(int id){
            var devolverVehiculo = obj.BuscarVehiculosPorServicio(id);
            return devolverVehiculo;
        }
        public static List<Vehiculo> ListarVehiculos() {
            return obj.ListarVehiculos();
        }
    }
}
