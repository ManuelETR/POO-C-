using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___008___MayorMenorMetodo
{
    internal class Program
    {
        public class MayorMenor
        {

            //Metodo para captura de numeros
            public void Captura() 
            {
                //Captura de Variables (Input)
                Console.Write("Introduce el primer numero: ");
                int numero1 = int.Parse(Console.ReadLine());
                Console.Write("Introduce el segundo numero: ");
                int numero2 = int.Parse(Console.ReadLine());
                Console.Write("Introduce el tercer numero: ");
                int numero3 = int.Parse(Console.ReadLine());

                //Pase de parametros a metodos a utilizar (Metodo Mayor, Metodo Menor)
                int mayor = Mayor(numero1, numero2, numero3);
                int menor = Menor(numero1, numero2, numero3);

                Console.WriteLine("\nEl numero mayor es: " + mayor);
                Console.WriteLine("El numero menor es: " + menor);
            }

            //Metodo para determinar mayor
            public int Mayor(int num1, int num2, int num3) 
            {
                if (num1 > num2 && num1 > num3)
                {
                    return num1;
                }
                else
                {
                    if (num2 > num3)
                    {
                        return num2;
                    }
                    else
                    {
                        return num3;
                    }
                }
            }

            //Metodo para determinar menor
            public int Menor(int num1, int num2, int num3)
            {
                if (num1 < num2 && num1 < num3)
                {
                    return num1;
                }
                else
                {
                    if (num2 < num3)
                    {
                        return num2;
                    }
                    else
                    {
                        return num3;
                    }
                }
            }

            static void Main(string[] args)
            {
                //Creacion de objetos

                MayorMenor num1 = new MayorMenor();
                num1.Captura();
                Console.ReadKey();
            }
        }
    }
}
