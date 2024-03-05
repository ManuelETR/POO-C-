using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___018___numerosInputWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int numero, x=1;
            string linea;

            Console.Write("introduzca un numero positivo para llegar del 1 al numero solicitado: ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            //ciclo while
            while(x<=numero)
            {   
                Console.WriteLine(" - " + x);
                
                x = x + 1;
            }

            Console.ReadKey();  

        }
    }
}
