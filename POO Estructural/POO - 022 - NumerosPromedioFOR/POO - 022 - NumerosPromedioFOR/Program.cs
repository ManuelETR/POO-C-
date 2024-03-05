using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___022___NumerosPromedioFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, suma = 0;
            float promedio;
            string linea;

            for (int veces = 1; veces < 10; veces++)
            {
                Console.Write("Introduzca un numero: ");
                linea = Console.ReadLine();
                numero = int.Parse(linea);

                suma = suma + numero;
            }

            promedio = suma / 10;
            Console.WriteLine("El total de la suma de los numeros es de: " + suma);
            Console.WriteLine("El promedio de dicha suma es: "+ promedio);

            Console.ReadKey();  
        }
    }
}
