using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___041___Propiedades3
{
    class Socio 
    {
        private string nombre;
        public string Nombre //PROPIEDAD de nombre
        { get { return nombre; } set { nombre = value; } }


        private int antiguedad;
        public int Antiguedad //PROPIEDAD de antiguedad
        { 
            set 
            { if (value >= 0)
                    antiguedad = value;

                else 
                {
                    Console.WriteLine("No se puede tener antiguedad negativa");
                }
            }

            get { return antiguedad; }
        }
    
    }


    class Club
    {
        private Socio socio1, socio2, socio3;

        public Club() //Constructor de la clase
        { 
            socio1 = new Socio();
            socio1.Nombre = "Manuel";
            socio1.Antiguedad = 9;

            socio2 = new Socio();
            socio2.Nombre = "Sebastian";
            socio2.Antiguedad = 7;

            socio3 = new Socio();
            socio3.Nombre = "Moises";
            socio3.Antiguedad = 8;
        }

        public void MayorAntiguedad() 
        {
            

            if (socio1.Antiguedad > socio2.Antiguedad && socio1.Antiguedad > socio3.Antiguedad)
            {
                Console.WriteLine("El socio con mayor antiguedad es: " + socio1.Nombre);
            }
            else 
            {
                if (socio2.Antiguedad > socio3.Antiguedad)
                {
                    Console.WriteLine("El socio con mayor antiguedad es: " + socio2.Nombre);
                }
                else 
                {
                    Console.WriteLine("El socio con mayor antiguedad es: " + socio3.Nombre);

                }
            }
        
        }


        static void Main(string[] args)
        {
            Club club = new Club();
            club.MayorAntiguedad(); 
            Console.ReadKey();
        }
    }
}
