using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona[] personas = new Persona[2]; => para usar el metodo de saludar.
            IPersona[] personas = new IPersona[2]; //=> para usar el metodo de despedirse.
            personas[0] = new Alumno("Pancracio UwU, ");
            personas[1] = new Empleado("Mariasauria Cuarentona, ");

            for (int i = 0; i < personas.Length; i++)
            {
                //Console.WriteLine(personas[i].Saludar()); => llamarla por la clase abstracta
                Console.WriteLine(personas[i].Despedirse()); //=> llamarla por la interface
                Console.ReadLine();
            }
        }
    }
}

public abstract class Persona
{
    public  string Nombre { get; set; }
    public abstract string Saludar();

}

public interface IPersona
{
    string Despedirse();
}

public class Alumno : Persona, IPersona
{
    public Alumno(string nombre) 
    { 
        this.Nombre = nombre;
    }

    public override string Saludar()
    {
        string saludo = "Hola mi nombre es: " + this.Nombre + "Y soy un Alumno UwU";
        return saludo;
    }
    public string Despedirse()
    {
        string despedirse = "El alumno: " + this.Nombre + "se despide cordialmente";
        return despedirse;
    }
}

public class Empleado : Persona, IPersona
{
    public Empleado(string Nombre)
    {
        this.Nombre = Nombre;
    }

    public override string Saludar()
    {
        string saluda = "Hola mi nombre es: " + this.Nombre + "Y soy un Empleado UwU";
        return saluda;
    }
     public string Despedirse()
    {
        string despedirse = "El empleado: " + this.Nombre + "se despide cordialmente";
        return despedirse;
    }
}
