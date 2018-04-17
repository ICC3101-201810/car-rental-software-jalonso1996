using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("HOLA! Bienvenido a CAR RENTAL");
                Console.WriteLine("que desea hacer?");
                Console.WriteLine("1) Arrendar vehiculo");
                Console.WriteLine("2) Recibir vehiculo");
                Console.WriteLine("3) Salir");
                int opcion;
                string linea;
                Console.Write("elija su opcion: ");
                linea = Console.ReadLine();
                opcion = int.Parse(linea);
                List<string> listavehiculos = new List<string>();
                listavehiculos.Add("moto");
                listavehiculos.Add("taxi");
                listavehiculos.Add("auto");
                listavehiculos.Add("bus");
                listavehiculos.Add("moto");
                if (opcion == 1)
                {
                    string nombre;
                    string rut;
                    string licencias;
                    Console.Write("escriba su nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("escriba su rut: ");
                    rut = Console.ReadLine();
                    Console.Write("licencias que tiene:");
                    licencias = Console.ReadLine();
                    string[] listalicencias = licencias.Split(',');
                    if (listalicencias.Contains("a"))
                    {
                        Console.WriteLine("puede manejar camiones, buses y taxi");
                    }
                    if (listalicencias.Contains("b"))
                    {
                        Console.WriteLine("automoviles normales");
                    }
                    if (listalicencias.Contains("c"))
                    {
                        Console.WriteLine("puede arrendar moto");
                    }
                    string vehiculo;
                    Console.Write("que tipo de vehiculo quiere arrendar: ");
                    vehiculo = Console.ReadLine();
                    if (listavehiculos.Contains(vehiculo))
                    {
                        string accesorios;
                        Console.Write("que accesorios desea agregar? (dejar en blanco si no quiere): ");
                        accesorios = Console.ReadLine();
                        string[] laccesorios = accesorios.Split(',');
                        listavehiculos.Remove(vehiculo);
                    }
                    else
                    {
                        Console.WriteLine("no quedan de vehiculos");
                    }
                }
                if (opcion == 2)
                {
                    string vehiculo1;
                    Console.Write("que vehiculo quiere devolver: ");
                    vehiculo1 = Console.ReadLine();
                    listavehiculos.Add(vehiculo1);
                    string rut1;
                    Console.Write("su rut: ");
                    rut1 = Console.ReadLine();
                    string nombre1;
                    Console.Write("su nombre: ");
                    nombre1 = Console.ReadLine();
                }
                else
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();
            }
            
        }
    }
}
