using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___029___MatrizconVectoresEMPLEADOS
{
    internal class Program
    {
        class Empleado
        {
            private string[] empleados;
            public int[,] sueldos;
            private int[] sueldoTotal;

            public void Carga() 
            {

                empleados = new string[4];
                sueldos = new int[4, 3];

                for (int i = 0; i < empleados.Length; i++) 
                {
                    Console.Write("Introduzca el nombre del empleado: \n");
                    empleados[i] = Console.ReadLine();

                    for (int j = 0; j < sueldos.GetLength(1); j++) 
                    {
                        Console.Write("Introduzca los diferentes montos de sueldo del empleado: ");
                        sueldos[i, j] = int.Parse(Console.ReadLine());
                                            
                    }
                }
            
            }

            public void IngresoAcumulado() 
            {
                sueldoTotal = new int[4];

                for (int i = 0; i < sueldos.GetLength(0); i++)
                {
                    int suma = 0;
                    for (int j = 0; j < sueldos.GetLength(1); j++) 
                    {                        
                        suma = suma + sueldos[i, j];
                    }

                    sueldoTotal[i] = suma; //LA SUMA DE CADA SUELDO DE CADA EMPLEADO (representados en el primer for con [ i ])
                }         
            }

            public void TotalPagado() 
            {
                for (int i = 0; i < empleados.Length; i++)
                {
                    Console.WriteLine("\nEl sueldo del empleado " + empleados[i] + " es de : " + sueldoTotal[i]);
                }           
            }

            public void DeterminarMayor() 
            {   
                int mayor = sueldoTotal[0];
                string empleadoMayor = empleados[0];

                for (int i = 0; i < sueldoTotal.Length; i++)
                {

                        if (sueldoTotal[i] > mayor)
                        {
                            mayor = sueldoTotal[i];
                            empleadoMayor = empleados[i];
                        }
                }
                
                Console.WriteLine("\nEl empleado " + empleadoMayor + " es el que gano mas con un monto de: " + mayor);

            }
            static void Main(string[] args)
            {
                Empleado persona = new Empleado();
                persona.Carga();
                persona.IngresoAcumulado();
                persona.TotalPagado();
                persona.DeterminarMayor();
                Console.ReadKey();
            }
        }
    }
}
