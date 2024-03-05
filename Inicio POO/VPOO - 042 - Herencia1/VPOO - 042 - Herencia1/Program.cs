using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPOO___042___Herencia1
{
    class Operacion 
    {
        //Atributos - Variables
        protected int valor1, valor2, resultado;
        
        //Propiedades de las variables declaradas
        public int Valor1 
        { 
            set
            { 
                valor1 = value; 
            } 
            get 
            { return valor1; 
            } 
        }
        public int Valor2 
        { 
            set 
            { 
                valor2 = value; 
            } 
            get 
            { 
                return valor2; 
            } 
        }
        public int Resultado 
        { 
            set 
            { 
                resultado = value; 
            } 
            get 
            { 
                return resultado; 
            } 
        }

    }


    class Suma:Operacion 
    {
        public void Operar() 
        { 
            Resultado = Valor1 + Valor2;
        }
    
    }

    class Resta : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 - Valor2;
        }

    }
        
    class Prueba
    {
        static void Main(string[] args)
        {
            Suma suma = new Suma();
            suma.Valor1 = 9;
            suma.Valor2 = 10;
            suma.Operar();

            Console.WriteLine("El primer valor es: " + suma.Valor1 + "\nEl segundo valor es: " + suma.Valor2 + 
                "\nLa suma de los valores es: " + suma.Resultado);

        

            Resta resta = new Resta();
            resta.Valor1 = 28;
            resta.Valor2 = 7;
            resta.Operar();

            Console.WriteLine("El primer valor es: " + resta.Valor1 + "\nEl segundo valor es: " + resta.Valor2 +
                "\nLa resta de los valores es: " + resta.Resultado);


            Console.ReadKey();
        }
    }
}
