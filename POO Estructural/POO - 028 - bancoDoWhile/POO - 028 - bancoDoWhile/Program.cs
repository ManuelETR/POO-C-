using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___028___bancoDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroCuenta;
            float saldo, suma=0;
            string linea;

            do
            {
                //Input de cuenta
                Console.Write("Introduce el numero de cuenta: ");
                linea = Console.ReadLine();
                numeroCuenta = int.Parse(linea);


                if (numeroCuenta > 0)
                {
                    //Imput de saldo una vez la cuenta sea mayor a 0
                    Console.Write("Introduce el saldo de la cuenta: ");
                    linea = Console.ReadLine();
                    saldo = float.Parse(linea);

                    if (saldo > 0)
                    {
                        //Si el saldo es positivo es acredora
                        Console.WriteLine("La cuenta " + numeroCuenta + " es acredora\n");

                        //Se suma el saldo de los acredores
                        suma = suma + saldo;
                    }
                    else
                    {
                        if (saldo < 0)
                        {
                            //Si el saldo es negativo es deudora
                            Console.WriteLine("La cuenta " + numeroCuenta + " es deudora\n");
                        }
                        else
                        {
                            //Si el saldo es cero es valor es nulo
                            Console.WriteLine("La cuenta " + numeroCuenta+ " es nula\n");
                        }
                    }
                }

            } while (numeroCuenta>=0);

            //Output del saldo de los acreedores
            Console.Write("\nLa suma total de fondos de las cuntas acredoras es: " + suma);
            Console.ReadKey();
        }
    }
}
