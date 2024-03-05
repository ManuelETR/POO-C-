using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___039___Propiedades1
{
    class Cliente 
    {
        private string nombre;
        public string Nombre //PROPIEDAD
        {
            set { nombre = value; }
            get { return nombre; }
        
        }
        private int monto;
        public int Monto //PROPIEDAD
        {
            set 
            {
                if (value >= 0)
                {
                    monto = value;
                }

                else 
                {
                    Console.WriteLine("No se pueden ingresar numeros negativos");
                }
            }
            get { return monto; }
        
        }
    
    }
    class Banco
    {
        private Cliente cliente1, cliente2, cliente3;

        public Banco() 
        { 
            cliente1 = new Cliente();
            cliente1.Nombre = "Juanito";
            cliente1.Monto = 300;

            cliente2 = new Cliente();
            cliente2.Nombre = "Pepe";
            cliente2.Monto = 500;

            cliente3 = new Cliente();
            cliente3.Nombre = "Perez Rico";
            cliente3.Monto = 600;
        }

        public void Operar() 
        {
            cliente1.Monto = cliente1.Monto - 150;
            cliente2.Monto = cliente2.Monto + 250;


        }

        public void DepositoTotal() 
        { 
           int total= cliente1.Monto+cliente2.Monto+cliente3.Monto;
            Console.WriteLine("El monto total es: $" + total);
        
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
