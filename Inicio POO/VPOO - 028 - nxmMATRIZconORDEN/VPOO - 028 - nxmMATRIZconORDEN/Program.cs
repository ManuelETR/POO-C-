using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___028___nxmMATRIZconORDEN
{
    internal class Program
    {
        class Matriz
        {
            private int[,] matriz;

            public void CargaMatriz() 
            {
                int filas, columnas;

                Console.Write("Introduzca la cantidadd de filas que tendra la matriz: ");
                filas = int.Parse(Console.ReadLine());

                Console.Write("\nIntroduzca la cantidadd de columnas que tendra la matriz: ");
                columnas = int.Parse(Console.ReadLine());

                matriz = new int[filas, columnas];

                for (int i = 0; i < matriz.GetLength(0); i++) 
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write("\nIntroduzca valor: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }               
                }
            }

            public void Intercalar() 
            { 

                for (int i = 0; i < matriz.GetLength(1); i++) 
                {
                    int aux = matriz[0,i];
                    matriz[0, i] = matriz[1, i];
                    matriz[1,i] = aux;               
                }            
            
            }

            public void ImprimirMatriz() 
            {

                for (int i = 0; i < matriz.GetLength(0); i++) 
                {
                    Console.WriteLine("\n");
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {

                        Console.Write(matriz[i, j] + " ");
                    }
                    
                }
            
            
            }

            static void Main(string[] args)
            {
                Matriz mat = new Matriz();
                mat.CargaMatriz();
                mat.Intercalar();
                mat.ImprimirMatriz();
                Console.ReadKey();

            }

        }
    }
}
