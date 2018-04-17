using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arriendo
    {
        Cliente cliente;
        Sucursal sucursal;
        Vehiculo vehiculo;
        List<Accesorio> accsesorios;

        public Arriendo(Cliente miClientes, Sucursal miSucursales, Vehiculo miVehiculos, List<Accesorio> miAccesorios)
        {
            cliente = miClientes;
            sucursal = miSucursales;
            vehiculo = miVehiculos;
            accsesorios = miAccesorios;
            
        }


    }
}
