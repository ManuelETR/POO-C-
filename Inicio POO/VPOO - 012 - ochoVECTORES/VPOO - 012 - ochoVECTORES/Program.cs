using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___012___ochoVECTORES
{
    internal class Program
    {
        public class Operaciones
        {

            private int[] numeros;

            public void Carga()
            {
                numeros = new int[8];
                for (int v = 0; v < 8; v++)
                {
                    Console.Write("Introduzca valor a acumular: ");
                    numeros[v] = int.Parse(Console.ReadLine());
                }
            }

            //Metodo Operaciones
            public void Opera() 
            {
               int suma = 0, suma2=0, mayorA=0;
                for (int v = 0; v < 8; v++)
                {
                    suma = suma + numeros[v];
                }

                for (int v = 0; v < 8; v++) 
                {
                    if (numeros[v] > 36)
                    {
                        suma2 = suma2 + numeros[v];
                    }
                }

                for (int v = 0; v < 8; v++)
                {
                    if (numeros[v] > 50)
                    {
                        mayorA++;
                    }
                }

                Console.WriteLine("\nLa suma total de los valores acumulados es: " + suma);
                Console.WriteLine("\nLa suma total de los valores acumulados mayores a 36 es: " + suma2);
                Console.WriteLine("\nLa cantidad de valores mayores a 50 son: " + mayorA);

            }

            static void Main(string[] args)
            {   
                Operaciones numeros1 = new Operaciones();
                numeros1.Carga();
                numeros1.Opera();
                Console.ReadKey();

            }

        }
    }
}
