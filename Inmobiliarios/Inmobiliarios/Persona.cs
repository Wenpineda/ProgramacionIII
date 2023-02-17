using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Inmobiliarios
{
    internal class Persona
    {
        private String nombreCompleto;
        private int dui;
        private int edad;

        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int Dui { get => dui; set => dui = value; }
        public int Edad { get => edad; set => edad = value; }

        public void RegistrarCliente(String _NombreCompleto, int _dui, int _edad)
        { 
            this.NombreCompleto = _NombreCompleto;
            this.Dui = _dui;
            this.Edad = _edad;  
        

            Console.WriteLine("Su nombre completo por favor: ");
            NombreCompleto = Console.ReadLine();

            Console.WriteLine("\nEscriba su número de DUI: ");
            Dui = int.Parse(Console.ReadLine());

            Console.WriteLine("\n¿Cuál es tú edad?: ");
            Edad = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tu nombre es {NombreCompleto} con la edad de {edad} y con el DUI {dui}\n");

            ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¿DESEAS EDITAR ESTA INFORMACIÓN? (Y= YES) (N= NO)");
            ResetColor();
            string OpcionElegida = Console.ReadLine();  
            while (OpcionElegida == "Y")
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("ESTAS EDITANDO LA INFORMACIÓN DEL CLIENTE\n");
                ResetColor();
                Console.WriteLine("Su nombre completo por favor: ");
                NombreCompleto = Console.ReadLine();

                Console.WriteLine("\nEscriba su número de DUI: ");
                Dui = int.Parse(Console.ReadLine());

                Console.WriteLine("\n¿Cuál es tú edad?: ");
                Edad = int.Parse(Console.ReadLine());

                Console.WriteLine($"Tu nombre es {NombreCompleto} con la edad de {Edad} y con el DUI {Dui}\n");

                ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("¿DESEAS EDITAR ESTA INFORMACIÓN? (Y= YES) (N= NO)");
                ResetColor();
                OpcionElegida = Console.ReadLine();
            }
            return;

        }

        public String GetNombrePersona()
        {

            return "-------------------------------------------\nDATOS DEL CLIENTE:\nNombre: " + NombreCompleto + "\nNúmero de DUI: " + Dui + "\nEdad: " + Edad + "\n";
            
        }
    }
}
