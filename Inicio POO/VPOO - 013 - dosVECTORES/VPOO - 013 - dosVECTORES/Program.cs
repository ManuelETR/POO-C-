using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___013___dosVECTORES
{
    internal class Program
    {
        public class SumaVector
        {
            //Declaracion de vectores
            private int[] serie1;
            private int[] serie2;
            private int[] suma;

            //Metodo Captura
            public void Captura() 
            {
                //Creacion de vectores
                serie1 = new int[4];
                serie2 = new int[4];
                suma = new int[4];

                //4 Capturas del primer vectores
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("Introduzca valor numerico para primer vector:  ");
                    serie1[i] = int.Parse(Console.ReadLine());
                }

                //4 Capturas del segundo vectores
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("Introduzca valor numerico para segundo vector:  ");
                    serie2[i] = int.Parse(Console.ReadLine());
                }

            }

            //Metodo para sumar vectores
            public void SumaVectores()
            {
                //Suma de vectores en el vector suma
                for (int i = 0; i < 4; i++)
                {

                    suma[i] = serie1[i] + serie2[i];

                }
            }

            //Metodo Imprimir
            public void Imprimir() 
            {
                //Impresion del vector 3 
                for (int i = 0; i < 4; i++) 
                {
                    Console.Write("\n El vector resultante de los valores del vector 1 y 2 es: " + suma[i]);
                }
            }

            static void Main(string[] args)
            {
                SumaVector sum1 = new SumaVector();
                sum1.Captura();
                sum1.SumaVectores();
                sum1.Imprimir();

                Console.ReadKey();
            }
        }
    }
}
