using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___011___matutitoVespertidoVECTORES
{
    internal class Program
    {
        public class Salarios 
        {
            private float[] sueldosV, sueldosM;

            //Metodo Captura

            public void Carga()
            {
                sueldosM = new float[4];
                sueldosV = new float[4];

                for (int v = 0; v < 4; v++)
                {
                    Console.Write("Introduce salario de empleado matutino: ");
                    sueldosM[v] = float.Parse(Console.ReadLine());
                }

                for (int v = 0; v < 4; v++)
                {
                    Console.Write("Introduce salario de empleado vespertino: ");
                    sueldosV[v] = float.Parse(Console.ReadLine());
                }

            }


            //Metodo Suma de Salarios
            public void SumaSalarios()
            {
                float sumaM = 0, sumaV = 0;
                for (int v = 0; v < 4; v++) 
                {
                    sumaM = sumaM + sueldosM[v];
                    sumaV=sumaV+ sueldosV[v];
                }

                Console.WriteLine("\nEl monto total a pagar a los empleados matutinos es de: $" + sumaM);
                Console.WriteLine("El monto total a pagar a los empleados vespertinos es de: $" + sumaV);

            }

            static void Main(string[] args)
            {
                Salarios salarios = new Salarios();
                salarios.Carga();
                salarios.SumaSalarios();
                Console.ReadKey();

            }
        }
    }
}
