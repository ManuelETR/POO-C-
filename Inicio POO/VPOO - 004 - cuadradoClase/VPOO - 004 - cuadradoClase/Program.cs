using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___004___cuadradoClase
{
    internal class Program
    {
        public class Cuadrado
        {
            //Atributos
            private int lado, area = 0, perimetro = 0;

            //Metodo - Captura de datos
            public void Captura() 
            {
                Console.Write("Introduzca el valor del lado del cuadrado: ");
                lado = int.Parse(Console.ReadLine());
            }

            //Metodo para calcular Perimetro
            public void Perimetro() 
            {
                perimetro = lado + lado + lado + lado;
                Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
            }

            //Metodo para calcular area
            public void Area() 
            {
                area = lado * lado;
                Console.WriteLine("El area del cuadrado es: " + area);
            }

            //MAIN
            static void Main(string[] args)
            {
                Cuadrado cuadrado1 = new Cuadrado();
                cuadrado1.Captura();
                cuadrado1.Perimetro();
                cuadrado1.Area();

                Console.ReadKey();

            }
        }
    }
}
