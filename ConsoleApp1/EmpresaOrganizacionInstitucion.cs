using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmpresaOrganizacionInstitucion : Cliente
    {
        string autorizacion;
        public EmpresaOrganizacionInstitucion(string miRut, string miNombre, string miAutorizacion) : base(miRut, miNombre)
        {
            autorizacion = miAutorizacion;
        }
        public abstract class Empresa
        {
            string autorizacionEspecial;
            public Empresa(string miAutorizacionEsp)
            {
                autorizacionEspecial = miAutorizacionEsp;
            }
            public bool AutorizacionEspecial(Empresa empresa1)
            {
                if (autorizacionEspecial == "si")
                {
                    Console.WriteLine("tiene autorizacion especial para arrendar maquinaria pesada");
                    return true;
                }
                else
                {
                    Console.WriteLine("no tiene autorizacion para arrendar maquinaria pesada");
                    return false;
                }
            }
        }

        public bool TieneAutorizacion(EmpresaOrganizacionInstitucion empresa)
        {
            if (autorizacion == "si")
            {
                Console.WriteLine("tiene autorizacion, puede arrendar vehiculo");
                return true;
            }
            else
            {
                Console.WriteLine("no tiene autorizacion, no puede arrendar");
                return false;
            }
        }
        
        
    }
}
