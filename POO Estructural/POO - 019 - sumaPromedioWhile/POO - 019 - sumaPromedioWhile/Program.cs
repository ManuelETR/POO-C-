using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___019___sumaPromedioWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            int x=1,valor, suma=0;
            float promedio;
            string linea;

            //Ciclo While
            while (x<=10)
            {
                Console.Write("Introduzca un valor a sumar: ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);

                //Suma ACUMULA los numeros ingresados por el usuario
                suma = suma + valor;

                //X es el numero de repeticiones del while
                x = x + 1;
            }

            Console.Clear();
            promedio = suma / 10;

            Console.WriteLine("El total de la suma es: " +  suma);
            Console.WriteLine("El total del promedio respecto a la suma es: " + promedio);

            Console.ReadKey();
        }
    }
}
