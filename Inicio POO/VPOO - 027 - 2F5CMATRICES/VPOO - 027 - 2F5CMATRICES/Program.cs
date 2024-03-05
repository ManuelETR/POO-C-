using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___027___2F5CMATRICES
{
    internal class Program
    {
        class Matriz
        {
            private int[,] matriz;

            public void CargaMatriz() 
            {
                matriz = new int[2, 5];

                for (int c = 0; c < 5; c++) 
                {
                    for (int f = 0; f < 2; f++) 
                    {
                        Console.Write("Introduzca numero: ");
                        matriz[f, c] = int.Parse(Console.ReadLine());
                    }
                               
                }                       
            }

            public void ImprimirMatriz() 
            {

                for (int c = 0; c < 2; c++) 
                {
                    for (int f = 0; f < 5; f++) 
                    { 
                        Console.Write(matriz[c,f] + " ");
                   
                    }
                    Console.WriteLine("\n");
                }
                       
            }

            static void Main(string[] args)
            {
                Matriz matriz = new Matriz();
                matriz.CargaMatriz();
                matriz.ImprimirMatriz();
                Console.ReadKey();
            }
        }
    }
}
