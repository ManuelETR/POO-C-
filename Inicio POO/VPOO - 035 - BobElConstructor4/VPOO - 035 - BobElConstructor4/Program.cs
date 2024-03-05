using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___035___BobElConstructor4
{
    class Operaciones
    {
        private int num1, num2;

        //Constructor
        public Operaciones() 
        {
            Console.Write("Ingrese el primer valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor: ");
            num2 = int.Parse(Console.ReadLine());

        }

        public void Suma() 
        { 
            
            int suma = num1 + num2;

            Console.WriteLine("\nLa suma de los dos numeros es: " + suma);
        
        }

        public void Resta()
        {
            int resta = num1 - num2;

            Console.WriteLine("\nLa resta de los dos numeros es: " + resta);

        }

        public void Multiplicacion()
        {
            int mult = num1 * num2;

            Console.WriteLine("\nLa multiplicacion de los dos numeros es: " + mult);

        }

        public void Division()
        {
            int div = num1 / num2;

            Console.WriteLine("\nLa division de los dos numeros es: " + div);

        }



        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.Suma();
            op.Resta();
            op.Multiplicacion();
            op.Division();
            Console.ReadKey();
        }
    }
}
