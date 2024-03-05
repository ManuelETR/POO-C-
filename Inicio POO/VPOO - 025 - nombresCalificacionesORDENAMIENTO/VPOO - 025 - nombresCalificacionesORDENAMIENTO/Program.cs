using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___025___nombresCalificacionesORDENAMIENTO
{
    internal class Program
    {
        class Alumno
        {
            private string[] nombre;
            private float[] nota;

            public void Captura() 
            {
                nombre = new string[5];
                nota = new float[5];

                for (int i = 0; i < nota.Length; i++) 
                {
                    Console.Write("Introduzca el nombre del alumno: ");
                    nombre[i] = Console.ReadLine();

                    Console.Write("Introduzca la calificacion del alumno: ");
                    nota[i] = float.Parse(Console.ReadLine());

                }
            
            }

            public void Ordenar() 
            { 
            
                for (int i = 0;i <nota.Length;i++)
                {
                    for (int f = 0; f <nota.Length - 1 - i; f++) 
                    {
                        if (nota[f]<nota[f+1]) 
                        { 
                            //Ordenar notas
                            float aux = nota[f];
                            nota[f] = nota[f+1];
                            nota[f+1] = aux;

                            //Ordenar nombres
                            string auxnombre = nombre[f];
                            nombre[f] = nombre[f + 1];
                            nombre[f + 1] = auxnombre;
                        }
                    }
                }          
            }


            public void CalificacionMayor() 
            {
                Console.WriteLine("\nLISTA DE ALUMNOS ORDENADOS DE MAYOR A MENOR CALIFICACION\n");
                for (int i = 0; i < nota.Length; i++)
                { 
                    Console.WriteLine(nombre[i] + " calificacion: " + nota[i]);
                }           
            }

            static void Main(string[] args)
            {
                Alumno nombre = new Alumno();
                nombre.Captura();
                nombre.Ordenar();  
                nombre.CalificacionMayor();
                Console.ReadKey();

            }

        }
    }
}
