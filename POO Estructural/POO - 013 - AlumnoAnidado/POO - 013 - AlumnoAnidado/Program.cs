using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___013___AlumnoAnidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            float nota1, nota2, nota3, promedio;
            string lista;

            //Asignar valor a Variables
            //Nota1 
            Console.Write("Introduzca el valor de la primera nota: ");
            lista = Console.ReadLine();
            nota1 = float.Parse(lista);

            //Nota2 
            Console.Write("Introduzca el valor de la segunda nota: ");
            lista = Console.ReadLine();
            nota2 = float.Parse(lista);

            //Nota3 
            Console.Write("Introduzca el valor de la tercera nota: ");
            lista = Console.ReadLine();
            nota3 = float.Parse(lista);

            //Operacion
            promedio = (nota1 + nota2 + nota3)/3;

            Console.Clear();
            //Condicional
            if (promedio >= 7)
            {
                Console.Write(promedio + " Alumno Aprobado");
            }
            else
            {
                if (promedio >= 4 && promedio < 7)
                {
                    Console.Write(promedio + " Alumno Regular");
                }
                else 
                {
                    Console.Write(promedio + " Alumno Reprobado");
                }
            }
            Console.ReadKey();
        }
    }
}
