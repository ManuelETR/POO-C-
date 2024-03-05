using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___019___nombreEdadVECTORES
{
    internal class Program
    {
        class Persona
        {
            private int[] edad;
            private string[] nombre;

            public void Carga() 
            {
                nombre = new string[5];
                edad = new int[5];

                for (int i = 0; i < 5; i++) 
                {
                    Console.Write("Introduzca el nombre de la persona: ");
                    nombre[i] = Console.ReadLine();
                    Console.Write("Introduzca la edad de la persona: ");
                    edad[i] = int.Parse(Console.ReadLine());
                }

            }

            public void ImprimirAdultos() 
            {

                for (int i=0; i<5;i++) 
                {
                    if (edad[i]>18)
                    {
                        Console.WriteLine("\nLa persona con el nombre de " + nombre[i] + " es adulto, con una edad de: " + edad[i]);                        
                    }

                }
            
            }

            static void Main(string[] args)
            {
                Persona persona = new Persona();
                persona.Carga();
                persona.ImprimirAdultos();
                Console.ReadKey();
            }
        }
    }
}
