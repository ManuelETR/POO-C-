using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___004___CuatroNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables 
            int num1, num2, num3, num4, suma, producto;
            string linea;

            //Ingresar valor de Variables (Input)
            //Valor 1
            Console.Write("Ingrese el valor del primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            //Valor 2
            Console.Write("Ingrese el valor del segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            //Valor 3
            Console.Write("Ingrese el valor del tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            //Valor 4
            Console.Write("Ingrese el valor del cuarto numero: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            //Realizacion de Operaciones
            suma = num1 + num2;
            producto = num3 * num4;

            //Despliegue de resultados (Output)
            Console.WriteLine("El resultado de la suma de los dos primeros numeros es: " + suma
                + "\nY el resultado del producto del tercero y el cuarto numero es: " + producto);
            Console.ReadKey();

        }
    }
}
