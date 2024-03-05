using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___032___BobElConstructor1
{
    class Empleado
    {
        private int[] salarios;

        public Empleado() 
        { 
            salarios = new int[5];

            for (int i = 0; i < salarios.Length; i++)
            {
                Console.Write("Introduzca el salario del empleado: ");
                salarios[i] = int.Parse(Console.ReadLine());
            }                
        }

        public void Imprimir() 
        {
            Console.WriteLine("------SALARIOS---------");
            int contador = 0; 
            for (int i =0; i<salarios.Length;i++) 
            {   
                contador++;
                Console.WriteLine("El salario del empleado " + contador + " es: " + salarios[i]);
                
            }
        
        }
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Imprimir();
            Console.ReadKey();

        }
    }
}
