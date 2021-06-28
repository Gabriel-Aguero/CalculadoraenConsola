using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Calculadora
    {
        private decimal u = 0;

        public decimal ultimoResultado
        {
            get
            {
                return u;
            }
            set
            {
                u = value;
            }
        }

        /*public decimal ultimoResultado
        {
            get;
            set;
        }*/


        public decimal sumar(decimal numero1, decimal numero2)
        {
            ultimoResultado = numero1 + numero2;
            return ultimoResultado;
        }

        public decimal restar(decimal numero1, decimal numero2)
        {
            ultimoResultado = numero1 - numero2;
            return ultimoResultado;
        }

        public decimal multiplicar(decimal numero1, decimal numero2)
        {
            ultimoResultado = numero1 * numero2;
            return ultimoResultado;
        }

        public decimal dividir(decimal numero1, decimal numero2)
        {
            ultimoResultado = numero1 / numero2;
            return ultimoResultado;
        }
    }
}
