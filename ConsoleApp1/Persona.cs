using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona : Cliente
    {
        List<string> licencia;
        public Persona(string miRut, string miNombre, List<string> miLicencia) : base(miRut, miNombre)
        {
            licencia = miLicencia;
        }
        public bool TieneLicencia(Persona persona)
        {
            if (licencia.Count > 0)
            {
                Console.WriteLine("tiene licencia, puede arrendar vehiculo");
                if (licencia.Contains("a"))
                {
                    Console.WriteLine("puede manejar camiones, buses y taxi");
                }
                if (licencia.Contains("b"))
                {
                    Console.WriteLine("automoviles normales");
                }
                if (licencia.Contains("c"))
                {
                    Console.WriteLine("puede arrendar moto");
                }
               
                return true;
            }
            else
            {
                Console.WriteLine("no tiene licencia, no puede arrendar vehiculo");
                return false;
            }
        }
        string l;
        public void AgregarLicencia()
        {
            licencia.Add(l);
        }
    }
}
