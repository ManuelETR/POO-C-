using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___038___Colaboracion3
{
    class Socio
    {

        private string nombre;
        private int antiguedad;

        public Socio()
        {
            Console.Write("Introduzca el nombre del socio: ");
            nombre = Console.ReadLine();

            Console.Write("Introduzca el nombre del socio: ");
            antiguedad = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("El nombre del socio es: " + nombre + "\nLa antiuedad del socio es: " + antiguedad + " años\n");
        }

        public int DevolverAntiguedad() 
        { 
            return antiguedad;
        }
    
    }
    class Club
    {
        private Socio socio1, socio2, socio3;

        public Club() 
        { 
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();

        }

        public void SocioMayor() 
        { 
        
            socio1.Imprimir();
            socio2.Imprimir();
            socio3.Imprimir();

            if (socio1.DevolverAntiguedad() > socio2.DevolverAntiguedad() &&
                socio1.DevolverAntiguedad() > socio3.DevolverAntiguedad())
            {
                Console.WriteLine("El socio mayor es el primero");


            }
            else
            {
                if (socio2.DevolverAntiguedad() > socio3.DevolverAntiguedad())
                {
                    Console.WriteLine("El socio mayor es el segundo");
                }

                else
                {
                    Console.WriteLine("El socio mayor es el tercero");
                }
            }
        }

        static void Main(string[] args)
        {
            Club club = new Club();
            club.SocioMayor();
            Console.ReadKey();
        }
    }
}
