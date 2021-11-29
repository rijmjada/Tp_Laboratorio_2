using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Recibe un caracter y valida si es un operador
        /// </summary>
        /// <param name="operador"> caracter a validar </param>
        /// <returns> Si el caracter es un operador valido retorna el mismo , caso contrario retornara '+' </returns>
        private static char ValidarOperador(string operador)
        {
            string ret = "+";

            if (operador == "-" || operador == "/" | operador == "*")
            {
                ret = operador;
            }
            return Convert.ToChar(ret);
        }

        /// <summary>
        /// Hace una operacion entre dos numeros
        /// </summary>
        /// <param name="num1"> valor numero 1 </param>
        /// <param name="num2"> valor numero 2 </param>
        /// <param name="operador"> tipo de operador </param>
        /// <returns> Si puede hacer la operacion devuelve el resultado , caso contrario devuelve 0 </returns>
        public static double Operar(Operando num1, Operando num2, string operador)
        {
            double ret = 0;

            switch(Calculadora.ValidarOperador(operador))
            {
                case '-':
                    ret = num1 - num2;
                    break;
                case '/':
                    ret = num1 / num2;
                    break;
                case '*':
                    ret = num1 * num2;
                    break;
                default:
                    ret = num1 + num2;
                    break;
            }

            return ret;
        }
    }
}
