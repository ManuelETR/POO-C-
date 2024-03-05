using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___012___DigitosCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            int numero;
            string linea;

            //Asignacion de valor a Variables (Input)
            Console.Write("Introduzca un numero del 1 al 99: ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            //Condicional
            if (numero <= 9)
            {

                Console.Write("El numero introducido: " + numero + "\nsolo tiene un digito");

            }
            else
            {
                Console.Write("El numero introducido: " +
                    "" + numero + "\ntiene dos digitos");
            }

            Console.ReadKey();
        }
    }
}
