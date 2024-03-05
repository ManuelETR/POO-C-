using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___009___DosNumerosCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaraciones de variables
            float num1, num2;
            string linea;

            //Asignacion de valores a Variables (Input)
            Console.Write("Introduzca el valor del primer numero: ");
            linea = Console.ReadLine();
            num1 = float.Parse(linea);

            //Asignacion de valores a Variables (Input)
            Console.Write("Introduzca el valor del segundo numero: ");
            linea = Console.ReadLine();
            num2 = float.Parse(linea);

            Console.Clear();
            if (num1 > num2)
            {

                Console.Write("El primer numero: " + num1 + 
                    "\nEs mayor al segundo numero: " + num2);

            }
            else
                Console.Write("El segundo numero: " + num2 
                    + "\nEs mayor al primer numero: " +num1);

            Console.ReadKey();
        }
    }
}
