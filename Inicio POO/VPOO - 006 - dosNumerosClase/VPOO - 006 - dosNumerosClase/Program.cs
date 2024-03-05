using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___006___dosNumerosClase
{
    public class Numeros
    {
        //Atributos
        private int numero1, numero2, suma, resta, mutiplicacion;
        private float division;

        //Metodo Carga
        public void Carga()
        {
            Console.Write("Introduzca el valor del primer numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Introduzca el valor del segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
        }

        //Metodo Suma
        public void Suma() 
        {
            suma = numero1 + numero2;
            Console.WriteLine("\nLa suma de los dos numeros introducidos es: " + suma);
        }

        public void Resta()
        {
            resta = numero1 - numero2;
            Console.WriteLine("La resta de los dos numeros introducidos es: " + resta);
        }

        public void Multiplica()
        {
            mutiplicacion = numero1 * numero2;
            Console.WriteLine("La multiplicacion de los dos numeros introducidos es: " + mutiplicacion);
        }

        public void Division()
        {
            division = numero1 / numero2;
            Console.WriteLine("La division de los dos numeros introducidos es: " + division);
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                //Creacion del objeto 

                Numeros num1 = new Numeros();
                num1.Carga();
                num1.Suma();
                num1.Resta();
                num1.Multiplica();
                num1.Division();

                Console.ReadKey();

            }
        }
    }
}
