using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___017___sumaLengthVECTORES
{
    internal class Program
    {
        class Suma
        {
            private int[] numeros;

            public void Carga() 
            {
                Console.Write("Introduzca cantidad de numeros a cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());

                numeros = new int[cantidad];
                for (int i = 0; i < numeros.Length; i++) 
                {
                    Console.Write("Introduzca numero: " );
                    numeros[i] = int.Parse(Console.ReadLine());
                }
            }

            public void SumaNumeros() 
            {
                int suma = 0;

                for (int i = 0; i < numeros.Length; i++) 
                { 
                    suma = suma + numeros[i];
                }

                Console.WriteLine("\nLa suma total de los numeros ingresados es: " + suma);

            }

            static void Main(string[] args)
            {
                Suma numeros = new Suma();
                numeros.Carga();    
                numeros.SumaNumeros();
                Console.ReadKey();
            }
        }
    }
}
