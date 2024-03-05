using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___010___alturaVECTORES
{
    internal class Program
    {
        class Persona
        {
            private float[] persona; //Declaracion de VECTOR
            private float promedio;
            //Metodo Carga
            public void Carga() 
            { 
                persona = new float[5];  //CREACION DE VECTOR

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Introduzca la altura de la persona: ");
                    persona[i] = float.Parse(Console.ReadLine());
                    
                }
            }

            //Metodo Promedio
            public void Promedio()
            {
                float suma = 0;
                for (int i = 0; i < 5; i++) 
                { 
                    suma = suma + persona[i];
                }

                 promedio = (suma / 5);

                Console.WriteLine("El promedio es de las alturas: " + promedio);

            }

            public void MayoresMenores()
            {

                float mayor = 0, menor = 0;

                for (int i = 0; i < 5; i ++)
                {
                    if (persona[i] > promedio)
                    {
                        mayor++;
                    }
                    else
                    {
                        if (persona[i] < promedio) 
                        {
                            menor++;
                        }
                    }
                }

                Console.WriteLine("La cantidad de personas mayor a la altura promedio es de: " + mayor);
                Console.WriteLine("La cantidad de personas mayor a la altura promedio es de: " + menor);

            }



            static void Main(string[] args)
            {
                //Creacion de Objeto

                Persona persona1 = new Persona();
                persona1.Carga();
                persona1.Promedio();
                persona1.MayoresMenores();
                Console.ReadKey();

            }

        }
    }
}
