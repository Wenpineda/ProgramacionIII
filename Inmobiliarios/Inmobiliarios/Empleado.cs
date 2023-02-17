using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inmobiliarios
{
    internal class Empleado : Persona
    {
        private String tipoContrato;
        private int tiempoDelContrato;
        private decimal salario;

        public string TipoContrato { get => tipoContrato; set => tipoContrato = value; }
        public int TiempoDelContrato { get => tiempoDelContrato; set => tiempoDelContrato = value; }
        public decimal Salario { get => salario; set => salario = value; }

        public void empleadito(string _TipoContrato, int _tiempoContrato, decimal _salario)
        {
            this.TipoContrato = _TipoContrato;
            this.TiempoDelContrato = _tiempoContrato;
            this.Salario = _salario;
  

            Console.WriteLine("\nNombre del empleado: ");
            NombreCompleto = Console.ReadLine();
            Console.WriteLine("\nDUI del empleado: ");
            Dui = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDuración del contrato: ");
            WriteLine(" 1 Año \n 2 Años \n 3 Años \n 4 Años");
            int Opcion = int.Parse(Console.ReadLine());
            decimal Meses = 0;
            if (Opcion == 1)
            {
                TiempoDelContrato = 1;
                Meses = 12; 
            }
            if (Opcion == 2)
            {
                TiempoDelContrato = 2;
                Meses = 24;
            }
            if (Opcion == 3)
            {
                TiempoDelContrato = 3;
                Meses = 36;
            }
            if (Opcion == 4)
            {
                TiempoDelContrato = 4;
                Meses = 48;
            }
            ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¿DESEAS EDITAR ESTA INFORMACIÓN? (Y= YES) (N= NO)");
            ResetColor();
            string OpcionElegida = Console.ReadLine();
            while (OpcionElegida == "Y")
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("ESTAS EDITANDO LA INFORMACIÓN DEL EMPLEADO\n");
                ResetColor();
                Console.WriteLine("\nNombre del empleado: ");
                NombreCompleto = Console.ReadLine();
                Console.WriteLine("\nDUI del empleado: ");
                Dui = int.Parse(Console.ReadLine());

                Console.WriteLine($"El nombre del empleado es {NombreCompleto} con la edad de {Edad} y con el DUI {Dui}\n");

                ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¿DESEAS EDITAR ESTA INFORMACIÓN? (Y= YES) (N= NO)");
                ResetColor();
                OpcionElegida = Console.ReadLine();
            }
     
            Console.WriteLine("\nEscoje el tipo de contrato que deseas\n" +
                " 1- Inmueble urbano \n" +
                " 2- Rustico \n 3- Por naturaleza \n 4- Por incorporación");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion >=5 || opcion <=0)
            {
                ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("\nEse tipo de contrato no existe en la lista, por favor verifica bien las opciones\n");
                ResetColor();

                Console.WriteLine("Vuelve a escojer el tipo de contrato por favor \n" +
                    " 1- Inmueble urbano \n 2- Rustico \n 3- Por naturaleza \n" +
                    " 4- Por incorporación\n");
                opcion = int.Parse(Console.ReadLine());
            }

            switch (opcion)
            {
                case 1:
                    TipoContrato =("Inmueble urbano");
                    Salario = 365 * Meses ;
                    break;

                case 2:

                    TipoContrato = ("Rustico");
                    Salario = 400 * Meses;
                    break;

                case 3:
                    TipoContrato=("Por naturaleza");
                    Salario = 300 * Meses;
                    break;


                case 4:
                    TipoContrato= ("Por incorporacion");
                    Salario = 500 * Meses;
                    break;

            }
        }


        public String GetEmpleado()
        {
           
            return "DATOS DEL EMPLEADO:\nNombre: " 
                + NombreCompleto + "\nDUI:" 
                + Dui + "\nTipo de contrato: "+TipoContrato+ "\nDuración del contrato: "+ TiempoDelContrato + " Años\n"
                + "Salario: $" + Salario;
        }
    }
}
