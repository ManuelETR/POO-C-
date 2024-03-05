using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___020___piezasAptasWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            int x=1, cantidad = 0, numero;
            float largo;
            string linea;

            Console.Write("Introduzca la cantidad de piezas a tratar: ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);


            //Ciclo While
            while(x<=numero)
            {
                Console.Write("Introduzca el largo de la pienza a tratar: ");
                linea = Console.ReadLine();
                largo = float.Parse(linea);

                if (largo >= 1.20 && largo <= 1.30)                 
                { 
                    cantidad = cantidad + 1 ;
                }
              
                x = x + 1;

            }

            Console.WriteLine("El total de piezas aptas es de: " + cantidad);
            Console.ReadKey();
        }
    }
}
