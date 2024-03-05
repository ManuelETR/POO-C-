using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___027___piezasKgDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            float pieza, piezasChicas=0, piezasNormales=0, piezasGrandes=0, suma=0;
            string linea;

            do 
            {             
                Console.Write("Escriba el peso de la pieza a tratar (termina cuando se introduce [0]): ");
                linea = Console.ReadLine();
                pieza = float.Parse(linea);
                
                if(pieza>0)
                {
                    if (pieza < 9.8)
                    {
                        piezasChicas++;
                    }
                    else
                    {
                        if (pieza > 10.2)
                        {
                            piezasGrandes++;
                        }

                        else 
                        { 
                            piezasNormales++;   
                        }
                    }
                    suma++;
                }

            } while (pieza != 0);

            //Console.Clear();

            Console.WriteLine("\nEl total de piezas procesadas fue: " + suma);
            Console.WriteLine("El total de piezas menor a 9.8 Kg es: " + piezasChicas);
            Console.WriteLine("El total de piezas mayores a 10.2 Kg es: " + piezasGrandes);
            Console.WriteLine("El total de piezas entre 9.8 & 10.2 Kg es: " + piezasNormales);

            Console.ReadKey();
        }
    }
}
