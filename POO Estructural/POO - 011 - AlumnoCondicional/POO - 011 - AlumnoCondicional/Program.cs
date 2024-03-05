using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___011___AlumnoCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            float nota1, nota2, nota3, promedio;
            string linea;

            //Asignacion de valores a Variables (input)
            //Nota1
            Console.Write("Introduzca el valor de la primera nota: ");
            linea = Console.ReadLine();
            nota1 = float.Parse(linea);

            //Nota1
            Console.Write("Introduzca el valor de la segunda nota: ");
            linea = Console.ReadLine();
            nota2 = float.Parse(linea);

            //Nota1
            Console.Write("Introduzca el valor de la tercer nota: ");
            linea = Console.ReadLine();
            nota3 = float.Parse(linea);

            //Operacion
            promedio = (nota1 + nota2 + nota3)/3;

            //Condicional
            if (promedio >= 7)
            {
                Console.Write("El alumno acredito");
            }
            else
            {
                Console.Write("El alumno no acredito");
            }

            Console.ReadKey();
        }
    }
}
