using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arriendo
    {
        List<Cliente> clientes;
        List<Sucursal> sucursales;
        List<Vehiculo> vehiculos;
        List<Accesorio> accsesorios;
        List<List<Accesorio>> listaaccesorio;

        public Arriendo(List<Cliente> miClientes, List<Sucursal> miSucursales, List<Vehiculo> miVehiculos, List<Accesorio> miAccesorios, List<List<Accesorio>> miListaDA)
        {
            clientes = miClientes;
            sucursales = miSucursales;
            vehiculos = miVehiculos;
            accsesorios = miAccesorios;
            listaaccesorio = miListaDA;
        }

        public void AgregarCliente(Cliente cliente1)
        {
            clientes.Add(cliente1);
        }
        public void AgregarSucursal(Sucursal sucursal1)
        {
            sucursales.Add(sucursal1);
        }
        public void AgregarVehiculo(Vehiculo vehiculo1)
        {
            vehiculos.Add(vehiculo1);
        }
        public void AgregarAccesorio(Accesorio accesorio1)
        {
            accsesorios.Add(accesorio1);
        }
        public void AgregarAccesorios(List<Accesorio> accesorios)
        {
            listaaccesorio.Add(accsesorios);
        }

    }
}
