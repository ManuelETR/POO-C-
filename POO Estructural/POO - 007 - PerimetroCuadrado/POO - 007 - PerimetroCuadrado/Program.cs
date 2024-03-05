using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___007___PerimetroCuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            float lado, perimetro;
            string linea;

            //Asignar valores a Variables
            Console.Write("Introduzca el valor del lado del cuadrado: ");
            linea = Console.ReadLine();
            lado = float.Parse(linea);

            //Operaciones (Metodos)
            perimetro = lado * 4;

            //Despliegue de resultados (Output)
            Console.Write("El valor del perimetro es: " + perimetro);
            Console.ReadKey();
        }
    }
}
