using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___016___sueldosLengthVECTORES
{
    internal class Program
    {
        class Sueldos
        {
            private float[] sueldos;

            public void Carga() 
            {
                int cantidad;

                Console.Write("Introduzca la cantidad de sueldos a capturar: ");
                cantidad = int.Parse(Console.ReadLine());

                sueldos = new float[cantidad];

                for (int i= 0; i<sueldos.Length; i++) 
                {
                    Console.Write("Introduzca sueldo: ");
                    sueldos[i] = float.Parse(Console.ReadLine());
                
                }   
            }

            public void Impimir() 
            {
                Console.WriteLine("\nListado de todos los sueldos");

                for (int i= 0; i<sueldos.Length; i++) 
                {
                    Console.WriteLine("$" + sueldos[i]);
                }
           
            }

            static void Main(string[] args)
            {
                Sueldos sueldos = new Sueldos();
                sueldos.Carga();
                sueldos.Impimir();
                Console.ReadKey();
            }
        }
    }
}
