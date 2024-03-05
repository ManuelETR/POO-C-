using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___033___BobElConstructor2
{
    class Alumno
    {
        private string nombre;
        private int edad;

        //Constructor
        public Alumno()
        {
            Console.Write("Ingrese el nombre del alumno: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese la edad del alumno: ");
            edad = int.Parse(Console.ReadLine());

        }

        public void Imprimir()
        {
            Console.Clear();    
            Console.WriteLine("El nombre del alumno es: " + nombre + " \nY tiene una edad de: "+ edad + " años");
            

        }

        public void Mayor()
        {
            Console.WriteLine();
            if (edad > 18)
            {
                Console.WriteLine("El alumno " + nombre + " es mayor de edad");
            }
            else 
            {
                if (edad<18) { Console.WriteLine("El alumno " + nombre + " es menor de edad"); }
            
            }
        }

        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            alumno.Imprimir();
            alumno.Mayor();
            Console.ReadKey();
        }
    }
}
