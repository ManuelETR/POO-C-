using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___030___apellidosCadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string apellido1, apellido2;

            Console.Write("Introduce un apellido: ");
            apellido1 = Console.ReadLine();

            Console.Write("Introduce otro apellido: ");
            apellido2 = Console.ReadLine();

            if (apellido1 == apellido2)
            {
                Console.Write("El apellido " + apellido1 + " y el apellido " + apellido2 + " son iguales");
            }
            else
            {
                Console.Write("El apellido " + apellido1 + " y el apellido " + apellido2 + " son distintos");
            }

            Console.ReadKey();

        }
    }
}
