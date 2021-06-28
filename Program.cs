using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pantalla p = new Pantalla();
            ReglasDeCalculo r = new ReglasDeCalculo();
            decimal num1, num2;
            int opcion;
            do
            {
                p.dibujarPantalla();
                opcion = p.leerOpcion();
                p.borrarPantalla();
                if ((opcion != 0) && (opcion != 5))
                {
                    num1 = p.pedirPrimerValor();
                    num2 = p.pedirSegundoValor();
                    p.borrarPantalla();
                   
                    p.mostrarResultado(r.calcular(opcion, num1, num2));
                }
                else
                    if (opcion == 5)
                    {
                        p.mostrarUltimoResultado(r.traerUltimoResultado());
                    }

                Console.ReadKey();
                p.borrarPantalla();

            } while (opcion != 0);
        }      
    }
}
