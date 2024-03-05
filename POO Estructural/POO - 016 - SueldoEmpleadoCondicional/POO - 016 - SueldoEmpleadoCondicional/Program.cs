using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___016___SueldoEmpleadoCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaracion de Variables
            float sueldo, aumento;
            int tiempoLaboral;
            string linea;

            //Asignacion de valor a Variables (input)
            //Tiempo laborado
            Console.Write("Introduzca el numero de años laborados del empleado: ");
            linea = Console.ReadLine(); 
            tiempoLaboral = int.Parse(linea);

            //Sueldo del empleado
            Console.Write("Introduzca el sueldo del empleado: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);

            //Limpieza de pantalla
            //Console.Clear();

            //Condicionales
            if (sueldo < 500 && tiempoLaboral >= 10)
            {
                //Operacion Aumentamos su sueldo en 20%
                aumento = ((sueldo * 20)/100) + sueldo;

                //Resultado del aumento (Output)
                Console.Write("El empleado obtendra un aumento del 20%, su sueldo a ganar es: $" + aumento);
            }
            else
            {
                if (sueldo < 500 && tiempoLaboral < 10)
                {
                    //Operacion Aumento en su sueldo en 5% 
                    aumento = ((sueldo * 5)/100) + sueldo;

                    //Resultado del aumento (Output)
                    Console.Write("El empleado obtendra un aumento del 5%, su sueldo a ganar es: $" + aumento);

                }
                else
                {
                    if (sueldo >= 500)
                    {
                        Console.Write("El sueldo del empleado no tendra cambios: $" + sueldo);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
