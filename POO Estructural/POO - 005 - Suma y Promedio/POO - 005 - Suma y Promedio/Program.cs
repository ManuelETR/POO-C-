using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___005___Suma_y_Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaracion de variables
            int num1, num2, num3, num4, suma;
            float promedio;
            string linea;

            //Ingresar valores de Variables (Input)
            //Primer numero
            Console.Write("Ingrese el valor del primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            //Segundo numero
            Console.Write("Ingrese el valor del segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            //Tercer numero
            Console.Write("Ingrese el valor del tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            //Cuarto numero
            Console.Write("Ingrese el valor del cuarto numero: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            //Operaciones
            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;

            //Despliegue de resultados
            Console.WriteLine("El resultaod de la suma es: " + suma + 
                "\nY el resultado del promedio respecto a la suma es: " + promedio);
            Console.ReadKey();

        }
    }
}
