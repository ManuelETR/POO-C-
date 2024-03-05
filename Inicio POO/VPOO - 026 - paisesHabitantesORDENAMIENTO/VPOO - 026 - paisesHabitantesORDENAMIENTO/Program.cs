using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___026___paisesHabitantesORDENAMIENTO
{
    class Paises
    {
        private string[] nombre;
        private int[] habitantes;

        public void Captura()
        {
            nombre = new string[5];
            habitantes = new int[5];

            for (int i = 0; i < habitantes.Length; i++)
            {
                Console.Write("Introduzca el nombre del Pais: ");
                nombre[i] = Console.ReadLine();

                Console.Write("Introduzca la cantidad de habitantes del pais: ");
                habitantes[i] = int.Parse(Console.ReadLine());

            }

        }

        public void OrdenarPaises()
        {

            for (int i = 0; i < habitantes.Length -1; i++)
            {
                for (int f = 0; f < habitantes.Length-1 ; f++)
                {
                    if (nombre[f].CompareTo(nombre[f + 1])>0)
                    {
                        //Ordenar habitantes
                        int aux = habitantes[f];
                        habitantes[f] = habitantes[f + 1];
                        habitantes[f + 1] = aux;

                        //Ordenar nombres
                        string auxnombre = nombre[f];
                        nombre[f] = nombre[f + 1];
                        nombre[f + 1] = auxnombre;
                    }
                }
            }
        }

        public void OrdenarHabitantes()
        {

            for (int i = 0; i < habitantes.Length; i++)
            {
                for (int f = 0; f < habitantes.Length - 1 - i; f++)
                {
                    if (habitantes[f] < habitantes[f + 1])
                    {
                        //Ordenar habitantes
                        int aux = habitantes[f];
                        habitantes[f] = habitantes[f + 1];
                        habitantes[f + 1] = aux;

                        //Ordenar nombres
                        string auxnombre = nombre[f];
                        nombre[f] = nombre[f + 1];
                        nombre[f + 1] = auxnombre;
                    }
                }
            }
        }


        public void Imprimir()
        {

            for (int i = 0; i < habitantes.Length; i++)
            {
                Console.WriteLine(nombre[i] + " - " + habitantes[i]);
            }
        }

        static void Main(string[] args)
        {
            Paises nombre = new Paises();
            nombre.Captura();
            Console.WriteLine("\nLISTA DE ALUMNOS PAISES ORDENADOS POR ORDEN ALFABETICO:\n");
            nombre.OrdenarPaises();
            nombre.Imprimir();

            Console.WriteLine("\nLISTA DE ALUMNOS PAISES ORDENADOS POR ORDEN DE HABITANTES:\n");
            nombre.OrdenarHabitantes();
            nombre.Imprimir();
            Console.ReadKey();

        }

    }
}
