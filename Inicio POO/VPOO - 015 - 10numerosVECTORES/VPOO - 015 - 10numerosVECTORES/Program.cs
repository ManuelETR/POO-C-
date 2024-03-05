using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___015___10numerosVECTORES
{
    internal class Program
    {
        class NumeroMenor
        {

            private float[] numero;

            public void Carga()
            {
                numero = new float[10];

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Introduzca un numero: ");
                    numero[i] = int.Parse(Console.ReadLine());
                }

                //EJERCICIO RESUELTO DE MANERA LARGA Y ORTODOXAs
                /*
                if (numero[0] < numero[1] && numero[1] < numero[2] && numero[2] < numero[3] && numero[3] < numero[4] && numero[4] < numero[5] 
                    && numero[5] < numero[6] && numero[6] < numero[7] && numero[7] < numero[8] && numero[8] < numero[9])
                {
                    Console.WriteLine("\nEl vector de numeros esta ordenada de maenor a mayor");
                }
                else
                {

                    Console.WriteLine("\nEl vector de numeros NO esta ordenada de maenor a mayor");

                } */

            }

            public void Orden()
            {
                int orden = 1;

                for (int i = 0; i < 9; i++)
                {
                    if (numero[i + 1] < numero[i])
                    {
                        orden = 0;
                    }

                }

                if (orden == 1)
                {
                    Console.WriteLine("El vector esta ordenado de menor a mayor");
                }
                else
                {
                    if (orden == 0)
                    {
                        Console.WriteLine("El vector NO esta ordenado de menor a mayor");
                    }
                }

            }




            static void Main(string[] args)
            {
                NumeroMenor numero = new NumeroMenor();
                numero.Carga();
                numero.Orden();
                Console.ReadKey();

            }

        }
    }
}
