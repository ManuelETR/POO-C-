using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___030___PaisesTemperaturas
{
        internal class Program
        {
        class Paises
        {

            private string[] nombres;
            private int[,] temperaturas;
            private int[] media;

            public void Carga() 
            { 
                nombres = new string[4];
                temperaturas = new int[4, 3];

                for (int i = 0; i < nombres.Length; i++) 
                {
                    Console.Write("Introduzca el nombre del pais: ");
                    nombres[i] = Console.ReadLine();
                    for (int j = 0; j < temperaturas.GetLength(1); j++) 
                    {
                        Console.Write("Introduzca temperatura media mensual: ");
                        temperaturas[i, j] = int.Parse(Console.ReadLine());
                    }                
                }
            
            }

            public void ImpresionGeneral() 
            {
                Console.WriteLine("\nTEMPERATURA MEDIA POR MES DE CADA PAIS:  ");
                for (int i = 0; i < nombres.Length; i++)
                {
                    Console.Write(nombres[i] + " ------- ");
                    for (int j = 0; j < temperaturas.GetLength(1); j++)
                    {
                        Console.Write(temperaturas[i, j] + " ");

                    }

                    Console.WriteLine(" ");
                }
            
            }

            public void CalcularMedia() 
            {
                media=new int[4];

                for (int i = 0; i < temperaturas.GetLength(0); i++) 
                {
                    int suma = 0;
                    for (int j = 0; j < temperaturas.GetLength(1); j++)
                    {
                        suma = suma + temperaturas[i,j];

                    }
                    media[i] = suma / 3;
                }
            
            }

            public void ImpresionMEDIA()
            {
                Console.WriteLine("\nTEMPERATURA MEDIA GENERAL POR TRIMESTRE:  ");
                for (int i = 0; i < nombres.Length; i++)
                {
                    Console.Write(nombres[i] + " ------- " + media[i]);
                    Console.WriteLine(" ");
                }

            }

            public void MayorMEDIA() 
            {
                int mayor = media[0]; 
                string pais = nombres[0];

                for (int i = 1; i < nombres.Length; i++) 
                {
                    if (media[i] > mayor ) 
                    { 
                        mayor = media[i];
                        pais = nombres[i];
                    }
                
                }
                Console.WriteLine("\nEL PAIS CON MAYOR TEMPERATURA MEDIA TRIMESTRAL:");
                Console.WriteLine(pais + " ------ " + mayor);



            }

            static void Main(string[] args)
            {
                Paises pais = new Paises();
                pais.Carga();
                pais.ImpresionGeneral();
                pais.CalcularMedia();
                pais.ImpresionMEDIA();
                pais.MayorMEDIA();
                Console.ReadKey();

            }

        }
        }
    
}
