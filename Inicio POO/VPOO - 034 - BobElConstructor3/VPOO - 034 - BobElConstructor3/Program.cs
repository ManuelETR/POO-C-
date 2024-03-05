using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___034___BobElConstructor3
{
    class Empleado
    {
        private string nombre;
        private float sueldo;

        //Constructor
        public Empleado() 
        {
            Console.Write("Introduce el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("Introduce el sueldo del empleado: ");
            sueldo = float.Parse(Console.ReadLine());

        }

        public void Imprimir() 
        {
            Console.WriteLine("El nombre del empleado es: " + nombre 
                + "\nY su sueldo es: $" + sueldo);
        
        }

        public void Impuesto() 
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado debe pagar impuestos");

            }
            else
            { 
                Console.WriteLine("El empleado no debe pagar impuestos");
            }
        
        }

        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Imprimir();
            empleado.Impuesto();
            Console.ReadKey();

        }
    }
}
