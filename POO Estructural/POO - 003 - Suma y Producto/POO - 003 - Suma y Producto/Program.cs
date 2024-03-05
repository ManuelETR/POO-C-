using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___003___Suma_y_Producto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int num1, num2, suma, producto;
            string linea;

            //Ingresar datos de Variables (Input)
            Console.Write("Ingrese el valor del primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el valor del segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            //Operaciones
            suma =  num1 + num2;

            producto = num1 * num2;

            //Despliegue de resultados
            Console.WriteLine("El resultado de la suma es: " + suma + "\nY el resultado del producto es: " + producto);
            Console.ReadKey();
        }
    }
}
