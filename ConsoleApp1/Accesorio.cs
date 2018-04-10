using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Accesorio
    {
        string tipo;

        public Accesorio(string miTipo)
        {
            tipo = miTipo;
        }
        public void AgregarAccsesorio()
        {
            Console.Write("tipo de accesorio: ");
            tipo = Console.ReadLine();
        }
    }
}
