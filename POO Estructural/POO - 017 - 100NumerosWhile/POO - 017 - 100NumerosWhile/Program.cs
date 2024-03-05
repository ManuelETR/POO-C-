using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___017___100NumerosWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables 
            int x=2;

            //Ciclo While
            while(x<=100)
            {
                Console.WriteLine(x);
                Console.Write(" - ");

                //El salto va de dos en dos
                x=x+2;
            }
            Console.ReadKey();  
        }
    }
}
