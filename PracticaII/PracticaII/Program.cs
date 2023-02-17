using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaII
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Pancracio";
            Console.WriteLine(persona1.Nombre);

            Estudiante estudiantes = new Estudiante();
            estudiantes.Nombre= persona1.Nombre + "Pepito"; 
        }

        class Persona 
        {
            private string nombre;
            public string Nombre 
            {
                get { return nombre; }
                set { nombre = value; }
            }
            public int edad; 
            public double peso; 
            public double altura; 


            public void comer()
            {
                Console.WriteLine("Estoy comiendo");
                Console.ReadLine();
            }

            public void caminar() 
            {
                Console.WriteLine("Estoy caminando");
                Console.ReadLine();
            }

        }
        class Estudiante : Persona
        {
            public void aprendiendo() 
            {
                Console.WriteLine("No aprendo rapido y Toy chikito  ");
            }

        }

    }
}
