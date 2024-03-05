using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___024___abcdFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            int numero, negativos=0, positivos=0, mult15=0, sumaPares=0;
            string linea;

            //Ciclo for
            for (int veces=0; veces<10; veces++) 
            {
                Console.Write("Introduzca el numero a capturar: ");
                linea = Console.ReadLine();
                numero = int.Parse(linea);

                if (numero<0) 
                {
                    negativos = negativos + 1;
                }
                if (numero >= 0)
                {
                    positivos = positivos + 1;
                }
                if (numero%15==0) 
                { 
                    mult15 = mult15 + 1;
                }
                if (numero%2 == 0)
                { 
                    sumaPares = sumaPares + numero;
                }
            }


            Console.WriteLine("El total de los numeros negativos es: " + negativos);
            Console.WriteLine("El total de los numeros positivos es: " + positivos);
            Console.WriteLine("El total de numeros con multiplos de 15 es: " + negativos);
            Console.WriteLine("La suma total de los numeros pares es: " + sumaPares);

            Console.ReadKey();

        }
    }
}
