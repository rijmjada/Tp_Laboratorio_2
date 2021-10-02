using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
     public abstract class Vehiculo
    {

        #region Atributos

        private string chasis;
        private ConsoleColor color;
        private EMarca marca;

        #endregion

        #region Propiedades

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de Vehiculo
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        protected Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public  virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Retorna los datos de un objeto de tipo Vehiculo
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();
            if (!(p is null))
            {
                sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
                sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
                sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
                sb.AppendFormat("TAMAÑO: {0}\r\n", p.Tamanio.ToString());
            }

            return sb.ToString();
        }

        #endregion

        #region Enumerados
        /// <summary>
        /// Enumerado de las marcas
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        /// <summary>
        /// Enumerado de los tamaños
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        #endregion

        #region  Operadores

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool ret = false;

            if (!(v1 is null) && !(v2 is null))
            {
                ret = v1.chasis == v2.chasis;
            }
            return ret;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        #endregion

    }
}
