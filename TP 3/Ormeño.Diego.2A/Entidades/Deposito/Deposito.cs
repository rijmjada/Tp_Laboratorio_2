using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Deposito
{
    public class Deposito<T> where T : class
    {
        #region Atributos

        public int _capacidadMaxima;
        public List<T> _lista;

        #endregion

        #region Constructores

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        #endregion

        #region Sobrecarga Operadores

        /// <summary>
        /// Retorna true, si pudo agregar el objeto T al depósito de T, false, caso contrario.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator +(Deposito<T> d, T a)
        {
            bool ret = false;

            if ((d is not null && a is not null) && (d._capacidadMaxima > d._lista.Count))
            {
                d._lista.Add(a);
                ret = true;
            }

            return ret;
        }

        /// <summary>
        /// Retorna true, si pudo remover el objeto T del depósito de T, false, caso contrario.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator -(Deposito<T> d, T a)
        {
            bool ret = false;
            int index = d.GetIndice(a);

            if (index != -1)
            {
                d._lista.Remove(a);
                ret = true;
            }

            return ret;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Retorna el valor del índice en el cual se encuentra el objeto T pasada como parámetro. Se debe recorrer la lista  genérica y retornar el índice
        /// de la primera ocurrencia, -1 si no se encuentra en la lista.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int GetIndice(T a)
        {
            int ret = -1;

            if (a is not null)
            {
                for (int i = 0; i < this._lista.Count; i++)
                {
                    if (_lista[i] == a)
                    {
                        ret = i;
                        break;
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Está asociado al operador +.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Agregar(T a)
        {
            return this + a;
        }

        /// <summary>
        /// Está asociado al operador -.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Remover(T a)
        {
            return this - a;
        }

        #endregion

        #region SobreEscritura

        /// <summary>
        /// Polimorfismo en ToString.Retorna una cadena conteniendo la información del depósito T (capacidad y todo el detalle de los objetos T que contiene).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad Deposito: {0}\r\n", this._capacidadMaxima);
            sb.AppendLine("Listado de Stock\n");

            foreach (T item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }
            
            return sb.ToString();
        }


       


        #endregion
    }
}
