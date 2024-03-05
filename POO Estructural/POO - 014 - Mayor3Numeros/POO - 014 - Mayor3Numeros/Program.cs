using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___014___Mayor3Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            float num1, num2, num3;
            string linea;

            //Asignacion de valores a Variables
            //numero1
            Console.Write("Introduzca el valor del primer numero: ");
            linea = Console.ReadLine();
            num1 = float.Parse(linea);

            //numero2
            Console.Write("Introduzca el valor del segundo numero: ");
            linea = Console.ReadLine();
            num2 = float.Parse(linea);

            //numero3
            Console.Write("Introduzca el valor del tercer numero: ");
            linea = Console.ReadLine();
            num3 = float.Parse(linea);

            //Condicional
            if (num1 > num2 && num1 > num3)
            {
                Console.Write("El numero mayor es: " + num1);
            }
            else
            {
                if (num2 > num1 && num2 > num3)
                {
                    Console.Write("El numero mayor es: " + num2);
                }
                else
                {
                    if (num3 > num1 && num3 > num2)
                    {
                        Console.Write("El numero mayor es: " + num3);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
