using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___020___sueldoMayorVECTORES
{
    internal class Program
    {
        class Persona
        {
            private string[] nombres;
            private float[] sueldos;

            public void Carga() 
            { 
                
                nombres = new string[5];
                sueldos = new float[5];

                for (int i = 0; i < sueldos.Length; i++)
                {
                    Console.Write("Introduzca el nombre del empleado: ");
                    nombres[i] = Console.ReadLine();

                    Console.Write("Introduzca el salario del empleado: ");
                    sueldos[i] = float.Parse(Console.ReadLine());
                }            
            }

            public void Evaluacion()
            {
                float mayor = sueldos[0];
                int posicion = 0;

                for (int i = 0; i < sueldos.Length; i++)
                {
                    if (sueldos[i] > mayor)
                    {
                        mayor = sueldos[i];

                        posicion = i;
                    }

                }

                Console.WriteLine("\nEl sueldo mayor es de " + nombres[posicion] + " que es de: $" + mayor );
            
            }

            static void Main(string[] args)
            {
                Persona sueldos = new Persona();
                sueldos.Carga();
                sueldos.Evaluacion();

                Console.ReadKey();
            }
        }
    }
}
