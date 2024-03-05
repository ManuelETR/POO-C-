using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___010___Operaciones_Condiconales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            float num1, num2, suma, resta, producto, division;
            string linea;

            //Asignacion de valores a Variables (input)
            //Valor 1
            Console.Write("Introduce el valor del primer numero: ");
            linea = Console.ReadLine();
            num1 = float.Parse(linea);

            //Valor 2
            Console.Write("Introduce el valor del segundo numero: ");
            linea = Console.ReadLine();
            num2 = float.Parse(linea);

            Console.Clear();

            //Condiconal
            if (num1 > num2)
            {
                //Operaciones
                suma = num1 + num2;
                resta = num1 - num2;

                Console.Write("La suma de los dos numeros es: " + suma
                    + "\nLa resta de los dos numeros es: " + resta);
            }
            else
            {
                //Operaciones
                producto = num1 * num2;
                division = num1 / num2;

                Console.Write("El producto de los dos numeros es: " + producto
                    + "\nLa division de los dos numeros es: " + division);
            }

            Console.ReadKey();
        }
    }
}
