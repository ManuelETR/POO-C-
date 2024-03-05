using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___007___tablaMultiplicarMetodo
{
    internal class Program
    {
        public class Numero
        {
          
            public void Captura() 
            {
                int numero;
                do
                {
                    Console.Write("Introduzca el numero a multiplicar: ");
                    numero = int.Parse(Console.ReadLine());
                    if (numero != -1) 
                    {
                        Multiplica(numero);
                    }
                
                
                } while (numero != -1);

            }

            //Metodo de multiplicar hasta 10
            public void Multiplica(int num)
            {
                for (int mult = num; mult <= num * 10; mult = mult+num) 
                {
                    Console.WriteLine(mult);
                }
            
            }

            static void Main(string[] args)
            {
                Numero num1 = new Numero();
                num1.Captura();

            }

        }
    }
}
