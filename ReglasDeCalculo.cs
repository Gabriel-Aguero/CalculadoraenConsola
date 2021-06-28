using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ReglasDeCalculo
    {
        Calculadora c = new Calculadora();

        public decimal calcular(int opcion, decimal num1, decimal num2)
        {
            decimal resultado = 0;
            switch (opcion)
            {
                case 1: resultado = c.sumar(num1, num2);
                    break;
                case 2: resultado = c.restar(num1, num2);
                    break;
                case 3: resultado = c.multiplicar(num1, num2);
                    break;
                case 4: resultado = c.dividir(num1, num2);
                    break;

            }
            return resultado;
        }

        public decimal traerUltimoResultado()
        {
            return c.ultimoResultado;
        }
    }
}
