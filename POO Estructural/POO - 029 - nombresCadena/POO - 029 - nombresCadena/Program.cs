using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___029___nombresCadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre1,nombre2;
            int edad1, edad2;

            Console.Write("Introduce el nombre de la primer persona: ");
            nombre1 = Console.ReadLine();
            Console.Write("Introduce la edad de la primer persona: ");
            edad1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el nombre de la primer persona: ");
            nombre2 = Console.ReadLine();
            Console.Write("Introduce la edad de la primer persona: ");
            edad2 = int.Parse(Console.ReadLine());

            if (edad1 > edad2) 
            {
                Console.WriteLine("La edad del primero es mayor: " + nombre1 + " - " + edad1);
            }
            else
                Console.WriteLine("La edad del segundo es mayor: " + nombre2 + " - " + edad2);

            Console.ReadKey();
        }
    }
}
