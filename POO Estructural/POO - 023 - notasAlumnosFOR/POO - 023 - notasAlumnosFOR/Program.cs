using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___023___notasAlumnosFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota, aprobados= 0, reprobados=0;
            string linea;

            for (int repeticion = 0; repeticion < 10; repeticion++) 
            {
                Console.Write("Introduzca la nota del alumno: ");
                linea = Console.ReadLine();
                nota = int.Parse(linea);

                if (nota >= 7)
                {
                    aprobados = aprobados + 1;
                }
                else
                { 
                    reprobados = reprobados + 1;
                }
            }

            Console.WriteLine("\nEl total de alumnos aprobados es: " + aprobados);
            Console.WriteLine("El total de alumnos reprobados es: " + reprobados);
            Console.ReadKey();
        }
    }
}
