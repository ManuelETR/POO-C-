using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___014___alumnosVECTORES
{
    internal class Program
    {
        class Calificaciones
        {

            private float[] claseA, claseB;
            

            public void Carga() 
            {
                claseA = new float[5];
                claseB = new float[5];

                Console.WriteLine("CALIFICACIONES DE CLASE A");
                for (int f = 0; f < 5; f++) 
                { 
                    Console.Write("Introduzca calificacion de alumno en clase A: ");
                    claseA[f] = float.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nCALIFICACIONES DE CLASE B");
                for (int f = 0; f < 5; f++)
                {
                    
                    Console.Write("Introduzca calificacion de alumno en clas B: ");
                    claseB[f] = float.Parse(Console.ReadLine());
                }

            }

            public void Promedio() 
            {
                float sumaA=0, sumaB=0;

                for (int f = 0; f < 5; f++)
                {
                    sumaA = sumaA + claseA [f];
                    sumaB = sumaB + claseB[f];
                }

                float promedioA = sumaA / 5;
                float promedioB = sumaB / 5;

                if (promedioA > promedioB)
                {
                    Console.WriteLine("La clase A tiene mayor promedio: " + promedioA);

                }
                else 
                {
                    Console.WriteLine("La clase B tiene mayor promedio: " + promedioB);
                }

            }

            static void Main(string[] args)
            {
                Calificaciones calificaciones = new Calificaciones();
                calificaciones.Carga();
                calificaciones.Promedio();
                Console.ReadKey();
            }
        }
    }
}
