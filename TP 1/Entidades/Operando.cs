using System;

namespace Entidades
{
    public class Operando
    {
        /// <summary>
        /// Atributo publico de tipo double
        /// </summary>
        #region Atributos

        public double numero;

        #endregion

        /// <summary>
        /// Propiedad solo Set que llama a la funcion 'ValidarNumero()'
        /// </summary>
        #region Propiedades
        public string Numero
        {
            set
            {
                this.numero = ValidarNumero(Convert.ToString(value));
            }
        }

        #endregion


        #region Constructores
        /// <summary>
        /// Constructor inicializa en 0
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor recibe tipo de dato double 
        /// </summary>
        /// <param name="numero"> valor a asignar </param>
        public Operando(double numero) : this(numero.ToString())
        {

        }

        /// <summary>
        /// Constructor recibe tipo de dato string
        /// </summary>
        /// <param name="strNumero"> valor a asignar </param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }



        #endregion


        #region Metodos Clase
        /// <summary>
        /// Chequea si el valor recibido es un numero 
        /// </summary>
        /// <param name="_numero"> Valor ingresado de tipo string </param>
        /// <returns>
        /// 0 si no se pudo convertir, caso contrario el numero ingresado
        /// </returns>
        private static double ValidarNumero(string _numero)
        {
            double ret = 0;

            if (Double.TryParse(_numero, out double number))
            {
                ret = number;
            }

            return ret;
        }

        /// <summary>
        /// Chequea si el valor recibido es Binario
        /// </summary>
        /// <param name="_binario"> numero a validar de tipo string </param>
        /// <returns> True si es binario , false caso contrario </returns>
        private bool EsBinario(string _binario)
        {
            bool ret = true;

            for (int i = 0; i < _binario.Length - 1; i++)
            {
                if (_binario[i] != '0' && _binario[i] != '1')
                {
                    ret = false;
                    break;
                }
            }

            return ret;
        }


        /// <summary>
        /// Convierte de Binario a Decimal
        /// </summary>
        /// <param name="_binario"> numero a convertir </param>
        /// <returns> "Valor inválido" o el numero convertido a sistema decimal </returns>
        public string BinarioDecimal(string _binario)
        {
            string ret = "Valor inválido";

            if (EsBinario(_binario) == true)
            {
                ret = Convert.ToString(Convert.ToInt64(_binario, 2));
            }

            return ret;
        }

        /// <summary>
        /// Convierte de Decimal a Binario
        /// </summary>
        /// <param name="_numero">numero a convertir </param>
        /// <returns>"Valor inválido" o el numero en Binario </returns>
        public string DecimalBinario(double _numero)
        {
            string ret = "Valor inválido";
            
            if (_numero >= 1)
            {
                // Casteo para quedarme con un numero entero
                ret = Convert.ToString((long)_numero, 2);
            }

            return ret;
        }


        /// <summary>
        /// Convierte de Decimal a Binario
        /// </summary>
        /// <param name="_numero"> numero a convertir </param>
        /// <returns> "Valor inválido" o el numero en Binario </returns>
        public string DecimalBinario(string _numero)
        {
            string ret = "Valor inválido";
            double tempSobrecarga;

            if (double.TryParse(_numero, out tempSobrecarga) == true)
            {
                ret = DecimalBinario(tempSobrecarga);
            }

            return ret;
        }


        #endregion


        #region Sobrecargas Operadores Estaticos

        /// <summary>
        /// Sobre carga del operador '-'
        /// </summary>
        /// <param name="n1"> 1° obj a restar </param>
        /// <param name="n2"> 2° obj a restar</param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        ///  Sobre carga del operador '+'
        /// </summary>
        /// <param name="n1"> 1° obj a sumar </param>
        /// <param name="n2"> 2° obj a sumar </param>
        /// <returns></returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobre carga del operador '*'
        /// </summary>
        /// <param name="n1"> 1° obj a multiplicar </param>
        /// <param name="n2"> 2° obj a multiplicar </param>
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobre carga del operador '/'
        /// </summary>
        /// <param name="n1"> 1° obj a dividir </param>
        /// <param name="n2"> 2° obj a dividir </param>
        /// <returns></returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double ret = double.MinValue;

            if (n2.numero != 0)
            {
                ret = n1.numero / n2.numero;
            }

            return ret;
        }

        #endregion

    }
}
