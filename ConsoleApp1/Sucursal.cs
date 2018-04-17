using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sucursal
    {
        string nombre;
        string direccion;
        List<Vehiculo> listavehiculos;

        public Sucursal(string miNombre, string miDireccion,List<Vehiculo> miListavehiculos)
        {
            nombre = miNombre;
            direccion = miDireccion;
            listavehiculos = miListavehiculos;
        }
    }
}
