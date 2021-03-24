using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{

    public delegate bool Comprobacion(string operacion);
    class Operaciones<T>
    {
        public T Suma(T valor1, T valor2, Comprobacion com, string oper)
        {
            if (com(oper))
            {
                return (dynamic)valor1 + (dynamic)valor2;
            }
            else
            {
                return (dynamic)0;
            }

        }

        public T Resta(T valor1, T valor2, Comprobacion com, string oper)
        {
            if (com(oper))
            {
                return (dynamic)valor1 - (dynamic)valor2;
            }
            else
            {
                return (dynamic)0;
            }
        }

        public T Multiplicacion(T valor1, T valor2, Comprobacion com, string oper)
        {
            if (com(oper))
            {
                return (dynamic)valor1 * (dynamic)valor2;
            }
            else
            {
                return (dynamic)0;
            }
        }

        public T Division(T valor1, T valor2, Comprobacion com, string oper)
        {
            if (com(oper))
            {
                return (dynamic)valor1 / (dynamic)valor2;
            }
            else
            {
                return (dynamic)0;
            }
        }
    }
}
