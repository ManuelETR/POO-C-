using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___037___Colaboracion2
{
    public class Dado
    {
        private int numero;
        private static Random rand;

        public Dado() 
        { 
            rand = new Random();
        
        }

        public void Tirar() 
        { 
            numero = rand.Next(1,7);
        
        }

        public void Imprimir()
        {
            Console.WriteLine("El numero aleatorio fue:" + numero);

        }

        public int DevolverValor() 
        {
            return numero;
        }


    }
    class JuegoDeDados
    {
        private Dado dado1, dado2, dado3;

        public JuegoDeDados() 
        { 
            dado1= new Dado();
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

            if (dado1.DevolverValor() == dado2.DevolverValor() && dado2.DevolverValor() == dado3.DevolverValor())
            {

                Console.WriteLine("El jugador gano");
            }
            else
            {
                Console.WriteLine("El jugador perdio");

            }

        }
        

        static void Main(string[] args)
        {
            JuegoDeDados juego = new JuegoDeDados();
            juego.Jugar();
            Console.ReadKey();
        }
    }
}
