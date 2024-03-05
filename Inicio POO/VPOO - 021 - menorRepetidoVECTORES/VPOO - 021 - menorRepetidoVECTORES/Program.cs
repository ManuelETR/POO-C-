using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___021___menorRepetidoVECTORES
{
    internal class Program
    {
        class Numeros
        {
            private int[] numeros;
            private int menor;

            public void Carga()
            {
                Console.Write("Introduzca la cantidad de numeros a cargar: ");
                int cantidad = int.Parse(Console.ReadLine());

                numeros = new int[cantidad];
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write("Introduzca numero: ");
                    numeros[i] = int.Parse(Console.ReadLine());

                }

            }

            public void Menor()
            {
                menor = numeros[0];

                for (int i = 1; i < numeros.Length; i++)
                {

                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                        
                    }
                }

                Console.WriteLine("\nEl numero menor es: " + menor);

            }

            public void Repite() 
            {
                int repeticion = 0;
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == menor) 
                    {
                        repeticion++;
                    }
                
                }

                if (repeticion > 1)
                {
                    Console.WriteLine("El numero menor se repite");
                }
                else
                {
                        Console.WriteLine("El numero menor no se repite");                   
                }
            
            }

            static void Main(string[] args)
            {
                Numeros numeros = new Numeros();
                numeros.Carga();
                numeros.Menor();
                numeros.Repite();
                Console.ReadKey();
            }
        }
    }
}
