using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___009___empleadoVector
{
    internal class Program
    {
        class SueldoEmpleados
        {
            private int[] sueldo; //DECLARACION DE UN VECTOR

            public void Carga()
            {
                sueldo = new int[5]; // SINTAXIS PARA VECTOR

                for ( int f = 0; f<5; f++)                
                {
                    Console.Write("introduce el sueldo del empleado: ");
                    sueldo[f] = int.Parse(Console.ReadLine()); 
                }
            
            }

            public void Imprimir()
            {
                Console.WriteLine("\nLista de sueldos de empleado");
                for (int f = 0; f < 5; f++)
                { 
                    Console.WriteLine("El sueldo es: " + sueldo[f]);
                
                }
            }


            static void Main(string[] args)
            {
                //Creacion de Objetos
                SueldoEmpleados sueldo1 = new SueldoEmpleados();
                sueldo1.Carga();
                sueldo1.Imprimir();
                Console.ReadKey();
            }

        }
    }
}
