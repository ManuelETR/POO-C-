using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO__001___CalculoSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            string linea;

            //Captura de datos (Input)
            Console.Write("Ingrese Horas trabajadas por el operario: ");
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);

            Console.Write("Ingrese el pago por hora: ");
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);
            
            //Operacion
            sueldo = horasTrabajadas * costoHora;

            //Despliegue de resultados (Output)
            Console.Write("El sueldo total del operario es: $" + sueldo);
            Console.ReadKey();
        }
    }
}
