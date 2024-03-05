using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___006___ArticuloCompra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de Variables
            float precioArticulo, pagoCliente;
            int cantidadArticulo;
            string linea;

            //Ingresar valores de Variables (Input)
            //Precio Articulo
            Console.Write("Ingrese el precio del articulo: ");
            linea = Console.ReadLine();
            precioArticulo = float.Parse(linea);

            //Cantidad de Articulo
            Console.Write("Ingrese la cantidad de articulo a comprar: ");
            linea = Console.ReadLine();
            cantidadArticulo = int.Parse(linea);

            //Operaciones
            pagoCliente = precioArticulo * cantidadArticulo;

            //Despliegue de resultados
            Console.Write("El total a pagar por el cliente es de: $" + pagoCliente);
            Console.ReadKey();
        }
    }
}
