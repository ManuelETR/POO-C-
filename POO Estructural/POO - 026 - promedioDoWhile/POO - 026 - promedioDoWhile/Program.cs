using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___026___promedioDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            int numeros, suma=0, numeroPromedio = 0;
            float promedio=0;
            string linea;

            do 
            {
                Console.Write("Introzuca numero a promediar (fin de la captura con [ 0 ]): ");
                linea = Console.ReadLine();
                numeros = int.Parse(linea);

                if (numeros != 0)
                {
                    suma = suma + numeros;
                    numeroPromedio++;
                }

                else
                {
                    if (numeros ==0) 
                    {
                        promedio = suma / numeroPromedio;
                    }
                }
            
            } while (numeros != 0);

            Console.Clear();

            Console.WriteLine("El total de la suma de los numeros es: " + suma);
            Console.WriteLine("El total del promedio respecto a la suma es: " + promedio);    

            Console.ReadKey();
        }
    }
}
