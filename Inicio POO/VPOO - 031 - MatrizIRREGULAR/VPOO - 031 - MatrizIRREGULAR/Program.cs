using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___031___MatrizIRREGULAR
{
    class MatrizIrregular
    {
        private int[][] matriz;

        public void Captura()
        {
            matriz = new int[5][];

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[i + 1];

                for (int j = 0; j < matriz[i].Length; j++)
                {
                    
                    Console.Write("Ingrese el valor de la matriz: ");
                    matriz[i][j] = int.Parse(Console.ReadLine());

                }
            }


        }

        public void ImprimirMatriz()
        {
            Console.WriteLine();
            for (int i = 0; i < matriz.Length; i++) 
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {

                    Console.Write(matriz[i][j] + " ");
                    
                }
                Console.WriteLine();
            }
        
        }

        static void Main(string[] args)
        {
            MatrizIrregular mat = new MatrizIrregular();
            mat.Captura();
            mat.ImprimirMatriz();
            Console.ReadKey();

        }
    }
}
