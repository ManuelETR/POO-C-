using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___003___cuadranteClase
{
    internal class Program
    {
        public class Punto
        {
            //Atributos
            private int x, y;


            //Metodo Captura de x & y
            public void Captura() 
            {
                Console.Write("Introduzca el valor de X: " );
                x = int.Parse(Console.ReadLine());

                Console.Write("Introduzca el valor de Y: ");
                y = int.Parse(Console.ReadLine());      
            }

            //Metodo Cuadrante
            public void Cuadrante()
            {
                if (x > 0 & y > 0)
                {
                    Console.WriteLine("\nEl punto esta en el primer cuadrante");
                }
                else
                {
                    if (x < 0 & y > 0)
                    {
                        Console.WriteLine("\nEl punto esta en el segundo cuadrante");

                    }
                    else
                    {
                        if (x < 0 & y < 0)
                        {
                            Console.WriteLine("\nEl punto esta en el tercer cuadrante");
                        }
                        else
                        {
                            Console.WriteLine("\nEl punto esta en el cuarto cuadrante");
                        }
                    }
                }
            
            }




            static void Main(string[] args)
            {
                //Creacion de Objeto

                Punto punto1 = new Punto();
                punto1.Captura();
                punto1.Cuadrante();

                Console.ReadKey();

            }



        }
    }
}
