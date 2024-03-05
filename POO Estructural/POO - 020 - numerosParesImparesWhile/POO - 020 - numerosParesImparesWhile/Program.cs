using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___020___numerosParesImparesWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            int x=1, cantidad, numeros, pares=0, impares=0;
            string linea;

            Console.Write("Escriba la cantidad de numeros a tratar: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            //Condicional While
            while (x<cantidad) 
            {
                Console.Write("Escriba el numero: ");
                linea = Console.ReadLine();
                numeros = int.Parse(linea);

                if (numeros % 2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }
                x = x + 1;

            }

            Console.WriteLine("\nLa cantidad de numeros pares es de: "+pares);
            Console.WriteLine("La cantidad de numeros impares es de: " + impares);

            Console.ReadKey();  
        }
    }
}
