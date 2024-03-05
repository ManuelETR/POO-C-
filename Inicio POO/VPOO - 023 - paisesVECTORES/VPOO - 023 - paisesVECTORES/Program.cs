using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___023___paisesVECTORES
{
    internal class Program
    {
        class Paises
        {
            private string[] nombres;

            public void Carga()
            {
                nombres = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Introduce un nombre: ");
                    nombres[i] = Console.ReadLine();
                }
            }

            public void Ordenar()
            {

                for (int i = 0; i < 4; i++)
                {
                    for (int f = 0; f < 4; f++)
                    {
                        //ORDENAMIENTO4
                        if (nombres[f].CompareTo(nombres[f+1]) > 0)
                        {
                            string aux;
                            aux = nombres[f];
                            nombres[f] = nombres[f+1];
                            nombres[f + 1] = aux;
                        }
                    }
                }
            }

            public void ImprimirNombres()
            {
                Console.WriteLine("El vector ordenado queda: \n");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(nombres[i]);
                }

            }

            static void Main(string[] args)
            {
                Paises nombres = new Paises();
                nombres.Carga();
                nombres.Ordenar();
                nombres.ImprimirNombres();
                Console.ReadKey();
            }

        }
    }
}
