using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___008___PagoImpuesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            float sueldo;
            string linea;

            //Asignacion de valores para Variables (input)
            Console.Write("Ingrese el sueldo del empleado: ");
            linea = Console.ReadLine(); 
            sueldo = float.Parse(linea);

            if (sueldo > 3000)
            {
                Console.Write("Este empleado necesita pagar impuestos");
            }
            else
                Console.Write("Este empleado no necesita pagar impuestos");

            Console.ReadKey();

        }
    }
}
