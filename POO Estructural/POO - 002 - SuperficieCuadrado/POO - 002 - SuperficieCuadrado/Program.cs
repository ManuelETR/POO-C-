using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___002___SuperficieCuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Declaracion de Variables
            int lado;
            int superficie;
            string linea;

            //Ingresar valor de variable Lado (Input)
            Console.Write("Introduzca el valor del lado del cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);

            //Operacion (Metodo)
            superficie = lado * lado;
            /*Un error de logica seria poner por ejemplo un 
            lado * lado *  lado, ya que aunque no tuviera un error
            de compilacion, el resultado seria erroneo*/



            //Despliegue de resultado
            Console.WriteLine("El area del cuadradado es: " + superficie);
            Console.ReadKey(); 

        }
    }
}
