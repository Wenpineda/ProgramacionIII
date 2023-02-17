using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inmobiliarios
{
    internal class Program: Persona
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******TIENDA EL PEPITO*********\n\n\n HECHO POR: JORDY & WENDY");

            Console.WriteLine("\nELIGE LA OPCION:\n 1- Hacer el tramite " +
                "\n 2- Salir del programa");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion <=0 || opcion>=3)
            {
                Clear();
                Console.WriteLine("*******TIENDA EL PEPITO*********\n\n\n HECHO POR: JORDY & WENDY\n");
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡¡Por favor asegurate que la opción se encuentre en el menu!!");
                ResetColor();
                Console.WriteLine("\nELIGE LA OPCIÓN:" +
                    "\n 1- Hacer el tramite " +
                    "\n 2- Salir del programa");
                opcion = int.Parse(Console.ReadLine());
            }

            switch (opcion)
            {

                case 1:
                    Clear();
                    Console.WriteLine($"Elegiste la opcion {opcion}\n");
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("**********TRAMITE**********\n");
                    ResetColor();
                    Persona persona = new Persona();
                    Empleado empleado = new Empleado();
                    Inmueble inmueble = new Inmueble();


                    persona.RegistrarCliente(persona.NombreCompleto, persona.Dui, persona.Edad);
                    empleado.empleadito(empleado.NombreCompleto, empleado.TiempoDelContrato, empleado.Salario);
                    inmueble.Inmobiliario(inmueble.TipoInmueble);



                    ///////////////////////////////////////////////////////////
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(persona.GetNombrePersona());
                    Console.WriteLine(empleado.GetEmpleado());
                    Console.WriteLine(inmueble.GetInmueble());
                    Console.ReadKey();

                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Lo siento muchacho esa opcion no esta disponible papu");
                    Console.ReadLine();

                    break;
            }

        }
    }
}
