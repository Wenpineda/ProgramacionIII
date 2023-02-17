using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inmobiliarios
{
    internal class Inmueble
    {
        private String tipoInmueble;

        public string TipoInmueble { get => tipoInmueble; set => tipoInmueble = value; }


        public void Inmobiliario(string inmobiliario)
        {
            this.TipoInmueble = inmobiliario;

            Console.WriteLine("\nEscoje el tipo de inmueble que deseas" +
                "\n" +
                " 1- Inmuebles residenciales " +
                "\n 2- Inmuebles comerciales " +
                "\n 3- Inmuebles industriales " +
                "\n 4- Inmuebles de uso mixto");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion >= 5 || opcion <= 0)
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEste tipo de inmobiliario no se encuentra en la lista, por favor verifica bien las opciones\n");
                ResetColor();

                Console.WriteLine("Vuelve a escojer el tipo de inmobiliario " +
                    "\n 1- Inmuebles residenciales " +
                    "\n 2- Inmuebles comerciales " +
                    "\n 3- Inmuebles industriales " +
                    "\n 4- Inmuebles de uso mixto");
                opcion = int.Parse(Console.ReadLine());
            }
            switch (opcion)
            {
                case 1:
                    TipoInmueble = ("Inmuebles residenciales");
                    break;

                case 2:

                    TipoInmueble = ("Inmuebles comerciales");
                    break;

                case 3:
                    TipoInmueble = ("Inmuebles industriales");
                    break;


                case 4:
                    TipoInmueble = ("Inmuebles de uso mixto");
                    break;

            }
        }

        public String GetInmueble()
        {
            return "\nINMOBILIARIO A CONTRATAR: \n"+TipoInmueble;
        }
    }
}
