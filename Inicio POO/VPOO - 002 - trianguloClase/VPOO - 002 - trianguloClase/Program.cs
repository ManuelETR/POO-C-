using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___002___trianguloClase
{
    internal class Program
    {
        public class Triangulo
        {

            //Atributos - Variables
            private int lado1, lado2, lado3;

            //Metodo para entrada de valores
            public void Carga() 
            {
                Console.Write("Introduzca el valor del primer lado: ");
                lado1 = int.Parse(Console.ReadLine());
                Console.Write("Introduzca el valor del segundo lado: ");
                lado2 = int.Parse(Console.ReadLine());
                Console.Write("Introduzca el valor del tercer lado: ");
                lado3 = int.Parse(Console.ReadLine());

            }

            public void Imprime()
            {
                if (lado1 > lado2 && lado1 > lado3)
                {
                    Console.WriteLine("El lado mayor de los lados es: " + lado1);
                }
                else 
                {
                    if (lado2 > lado3)
                    {
                        Console.WriteLine("El lado mayor de los lados es: " + lado2);
                    }
                    else 
                    { 
                        Console.WriteLine("El lado mayor de los lados es: " + lado3);
                    }
                }
            }

            public void Equilatero() 
            {
                if (lado1 == lado2 & lado2 == lado3)
                {
                    Console.WriteLine("El trinagulo es un equilatero (todos los lados son iguales)");
                }
                else
                {
                    Console.WriteLine("El trinagulo no es un equilatero (no todos los lados son iguales)");

                }
            }

            static void Main(string[] args)
            {
                Triangulo triangulo1 = new Triangulo();
                triangulo1.Carga();
                triangulo1.Imprime();
                triangulo1.Equilatero();

                Console.ReadKey();

            }

        }
    }
}
