using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___036___Colaboracion1
{
    class Clientes
    {
        private string nombre;
        private int monto;

        //Constructor
        public Clientes(string nom)
        {
            nombre = nom;
            monto = 0;

        }

        public void Depositar(int m)
        {
            monto = monto + m;
        }

        public void Extraer(int m)
        {

            monto = monto - m;

        }

        public int RetornarMonto()
        {
            return monto;

        }

        public void Imprimir()
        {
            Console.WriteLine("\nEl nombre del cliente es: " + nombre +
                "\nY el monto final es: $"+monto);
        
        }

    }
    class Banco
    {
        private Clientes cliente1, cliente2, cliente3;
        
        //constructor
        public Banco()
        {
            cliente1 = new Clientes("Charlie");
            cliente2 = new Clientes("Sebastian");
            cliente3 = new Clientes("Moises");

        }

        public void Operar() 
        {

            cliente1.Depositar(400);
            cliente2.Depositar(400);
            cliente3.Depositar(400);
            cliente1.Depositar(200);
            cliente3.Depositar(100);
            cliente2.Depositar(300);
            cliente1.Extraer(200);
            cliente2.Extraer(400);
            cliente3.Extraer(500);
        }
        public void DepositoTotal()
        {
            int total = cliente1.RetornarMonto() + 
                        cliente2.RetornarMonto() + 
                        cliente3.RetornarMonto();
            Console.WriteLine("El total del dinero en el baco es de: $" + total);

            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }

        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.Operar();
            banco.DepositoTotal();
            Console.ReadKey();

        }
    }
}
