using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___022___OrdenamientoVECTORES
{
    internal class Program
    {
        class Ordenamiento
        {
            private int[] numeros;

            public void Carga() 
            {
                numeros = new int[5];
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write("Introduce un numero: ");
                    numeros[i] = int.Parse(Console.ReadLine());                    
                }
            }

            public void Ordenar() 
            {
                
                for (int i = 0; i < 4; i++) 
                {
                    for (int f=0; f<4 ;f++)
                    {
                        //ORDENAMIENTO4
                        if (numeros[f] > numeros[f+1]) 
                        {
                            int aux = numeros[f];
                            numeros[f] = numeros[f+1];
                            numeros[f+1] = aux;              
                        }
                    }                   
                }
            }

            public void ImprimirVector() 
            {
                Console.WriteLine("El vector ordenado queda: \n");
                for (int i = 0; i < numeros.Length; i++)
                { 
                    Console.WriteLine(numeros[i]);
                }

            }

            static void Main(string[] args)
            {
                Ordenamiento numero = new Ordenamiento();
                numero.Carga();
                numero.Ordenar();
                numero.ImprimirVector();
                Console.ReadKey();
            }

        }
    }
}
