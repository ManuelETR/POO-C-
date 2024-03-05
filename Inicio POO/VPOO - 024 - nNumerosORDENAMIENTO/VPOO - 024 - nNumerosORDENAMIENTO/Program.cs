using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___024___nNumerosORDENAMIENTO
{
    internal class Program
    {
        class Numeros
        {
            private int[] numeros;

            public void Captura() 
            {
                Console.Write("HOLA!, Introduce la cantidad de numeros en el vector: ");
                int cantidad = int.Parse(Console.ReadLine());

                numeros = new int[cantidad];
                for (int i = 0; i < numeros.Length; i++) 
                {
                    Console.Write("Introduce un numero: ");
                    numeros[i] = int.Parse(Console.ReadLine()); 
                }           
            }

            public void Ordenar() 
            {

                for (int i = 0; i < numeros.Length; i++) 
                {
                    for (int j = 0; j < numeros.Length - 1; j++) 
                    {
                        if (numeros[j]>numeros[j+1]) 
                        {
                            int aux = numeros[j];
                            numeros[j] = numeros[j+1];
                            numeros[j+1] = aux;
                        
                        }
                    }
                }        
            }

            public void ImpimirVector() 
            {
                Console.WriteLine("\nEl Ordenamiento correcto es: ");

                for (int i = 0; i < numeros.Length; i++) 
                { 
                    Console.WriteLine(numeros[i]);                
                }        
            }

            static void Main(string[] args)
            {
                Numeros numeros = new Numeros();
                numeros.Captura();
                numeros.Ordenar();
                numeros.ImpimirVector();
                Console.ReadKey();
            }
        }
    }
}
