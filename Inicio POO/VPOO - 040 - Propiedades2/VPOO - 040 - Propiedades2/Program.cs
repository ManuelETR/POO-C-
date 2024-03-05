using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___040___Propiedades2
{
    class Dado
    {
        private int valorDado;
        public int Valor // PROPIEDAD de valorDado
        { 
            get { return valorDado; }
            private set { valorDado = value; }
        }


        private static Random random;

        public Dado()
        {
            random = new Random();
        
        }

        public void Tirar() 
        { 
            Valor = random.Next(1,7);
        
        }

        public void Imprimir() 
        {
            Console.WriteLine("El valor del dado es: " + Valor);
        
        }
    
    }
    class JugarDado
    {
        private Dado dado1, dado2, dado3;

        public JugarDado() 
        { 
            dado1 = new Dado();
            dado2 = new Dado();
            dado3 = new Dado();

        }

        public void Jugar() 
        { 
            dado1.Tirar();
            dado2.Tirar();
            dado3.Tirar();

            dado1.Imprimir();
            dado2.Imprimir();
            dado3.Imprimir();

            if (dado1.Valor == dado2.Valor && dado1.Valor == dado3.Valor)
            {
                Console.WriteLine("\nEl jugador gano");
            }
            else 
            {
                Console.WriteLine("\nEl jugador perdio");
            }

        }

        static void Main(string[] args)
        {
            JugarDado jugar = new JugarDado();
            jugar.Jugar();
            Console.ReadKey();
        }
    }
}
