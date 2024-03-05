using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___025___numerosDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            int numero, unDigito = 0, dosDigitos = 0, tresDigitos = 0;
            string linea;

           
            do 
            {
                //Solicitamos numero a usuario (Input)
                Console.Write("Introduzca un numero entre el 1 al 999 (se termia presionando [ 0 ]): ");
                linea = Console.ReadLine();
                numero = int.Parse(linea);

                if (numero >= 100)
                {
                    tresDigitos = tresDigitos + 1;
                }
                else
                {
                    if (numero >= 10)
                    {
                        dosDigitos = dosDigitos + 1;
                    }
                    else
                    { 
                        unDigito = unDigito + 1;  
                    }
                }


            }while (numero!=0);

            Console.WriteLine("La cantidad de numeros con un digito es de: " + unDigito);
            Console.WriteLine("La cantidad de numeros con dos digitos es de: " + dosDigitos);
            Console.WriteLine("La cantidad de numeros con tres digitos es de: " + tresDigitos);

            Console.ReadKey();  
        }
    }
}
