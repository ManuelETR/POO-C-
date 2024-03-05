using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___01___personaClase
{
    internal class Program
    {
        //Clase Persona
        class Persona
        {
            //Atributos (Variables)
            private string nombre;
            private int edad;


            //Metodos - Funciones
            public void Captura() 
            {
                Console.Write("Introduzca el nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Introduzca la edad: ");
                edad = int.Parse(Console.ReadLine());

            }

            //Metodo Imprimir
            public void Imprimir() 
            {
                Console.WriteLine("El nombre de la persona es: " + nombre);
                Console.Write("La edad de la persona es: " + edad);

            }

            //Metodo Mayor
            public void EdadMayor() 
            {
                if (edad > 18)
                {
                    Console.WriteLine("\nEsta persona es mayor edad");
                }
                else
                {
                    Console.WriteLine("\nEsta persona es menor de edad");
                }
                Console.ReadKey();
            }


            //Main
            static void Main(string[] args)
            {
                //creacion de objetos
                Persona per1 = new Persona();
                per1.Captura();
                per1.Imprimir();
                per1.EdadMayor();
            }

        }
        
    }
}
