using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___015___NuloCondiconal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            int numero;
            string lista;

            //Asignacion de valor a Variables (Input)
            Console.Write("Introduce el valor del numero: ");
            lista = Console.ReadLine();
            numero = int.Parse(lista);

            //Condicional

            if (numero > 0)
            {
                Console.Write("");
            }
        }
    }
}
