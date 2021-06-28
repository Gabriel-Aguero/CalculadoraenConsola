using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Pantalla
    {
        public void dibujarPantalla()
        {
            Console.BackgroundColor = ConsoleColor.Blue; 
            Console.ForegroundColor = ConsoleColor.Black; // da color a la letra
            Console.Clear();
           // Console.WriteLine("-----------------------------------------------\n\n");
            Console.WriteLine("\n                    ------------MENU PRINCIPAL---------------------\n\n");
            Console.WriteLine("                               0-Salir \n " +
            "                              1-Sumar \n "+
            "                              2-Restar \n "+
            "                              3-Multiplicar \n "+
            "                              4-Dividir \n "+
            "                              5-Trear ultimo resultado \n");
            Console.Write("Seleccione una opcion: ");
        }

        public int leerOpcion()
        {
            int opcion;
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        public void mostrarResultado(decimal resultado)
        {
            Console.WriteLine("\n El resultado de la operacion es: " + resultado);
        }

        public void mostrarUltimoResultado(decimal resultado)
        {
            Console.WriteLine("\n El resultado de la ultima operacion es: " + resultado);
        }

        public void borrarPantalla()
        {
            Console.Clear();
        }

        public decimal pedirPrimerValor()
        {
            decimal numero;
            Console.Write("Ingrese el primer valor: ");
            numero = decimal.Parse(Console.ReadLine());
            return numero;
        }

        public decimal pedirSegundoValor()
        {
            decimal numero;
            Console.Write("Ingrese el segundo valor: ");
            numero = decimal.Parse(Console.ReadLine());
            return numero;
        }
    }
}
