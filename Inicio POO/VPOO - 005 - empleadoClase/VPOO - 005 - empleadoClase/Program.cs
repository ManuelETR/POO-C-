using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___005___empleadoClase
{
    internal class Program
    {
        public class Empleado
        {
            //Atributos
            private string nombre;
            private float sueldo;


            //metodo de captura
            public void Captura()
            {
                Console.Write("Introduzca el nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.Write("Introduzca el sueldo del empleado: ");
                sueldo = float.Parse(Console.ReadLine());

            }


            //metodo de 
            public void Imprimir() 
            {
                Console.WriteLine("\nEl nombre del empleado es: " + nombre);
                Console.WriteLine("El sueldo del empleado es: $" + sueldo);

            }

            public void Impuestos() 
            {
                if (sueldo > 3000)
                {
                    Console.WriteLine("El empleado necesita pagar impuestos");
                }
                else 
                {
                    Console.WriteLine("El empleado no necesita pagar impuestos");

                }
            }

            //MAIN
            static void Main(string[] args)
            {
                //Creacion de objeto
                Empleado empleado1 = new Empleado();
                empleado1.Captura();
                empleado1.Imprimir();
                empleado1.Impuestos();

                Console.ReadKey();
            }


        }
    }
}
